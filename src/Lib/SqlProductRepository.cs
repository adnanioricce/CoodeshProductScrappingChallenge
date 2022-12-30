using Dapper;
using System.Data;
using System.Runtime.CompilerServices;

namespace ProductScrapper
{
    public delegate IDbConnection CreateConnectionWith(string connectionString);
    public delegate IDbConnection CreateConnection();
    public class SqlProductRepository : IProductRepository
    {
        private CreateConnection _createConnection;
        public SqlProductRepository(CreateConnection createConnection)
        {
            _createConnection = createConnection;
        }
        public async Task BulkCreateAsync(IEnumerable<ProductDto> products)
        {            
            await AppConnection.OnConnection(_createConnection, async (conn) =>
                await conn.ExecuteAsync(@"
                INSERT INTO [Products](Code,Barcode,Status,ImportedAt,Url,ProductName,Quantity,Categories,Packaging,Brands,ImageUrl) 
                VALUES(@Code,@Barcode,@Status,@ImportedAt,@Url,@ProductName,@Quantity,@Categories,@Packaging,@Brands,@ImageUrl)"
                , products.Select(p => p with { ImportedAt = DateTimeOffset.UtcNow.ToString() })));
        }

        public async Task Create(ProductDto product)
        {
            await BulkCreateAsync(new[] { product });
        }

        public async Task<ProductDto> GetByCodeAsync(long code)
        {
            return await AppConnection.OnConnection(_createConnection,
                async (conn) => {
                    using var reader = await conn.ExecuteReaderAsync("SELECT * FROM dbo.[Products] WHERE Code = @Code", new { Code = code });
                    if (reader.Read())
                    {
                        return ProductDto.Read(reader);
                    }
                    return default;
                });
        }

        public async Task<ProductDto> GetByIdAsync(long id)
        {
            return await AppConnection.OnConnection(_createConnection,
                async (conn) => await conn.QueryFirstAsync<ProductDto>("SELECT * FROM dbo.[Products] WHERE Id = @Id", new { Id = id }));
        }

        public async Task<IEnumerable<ProductDto>> ListAsync()
        {
            try
            {
                Func<IDbConnection,Task<IEnumerable<ProductDto>>> readRows = async (conn) => {
                    using var reader = await conn.ExecuteReaderAsync("SELECT * FROM dbo.[Products]");
                    var products = new List<ProductDto>();
                    while (reader.Read())
                    {
                        products.Add(ProductDto.Read(reader));
                    }
                    return products;
                };
                var result = await AppConnection.OnConnection(_createConnection,readRows);
                return result;
            }
            catch(Exception ex)
            {
                return Enumerable.Empty<ProductDto>();
            }            
        }

        public async Task UpdateRemainingFields(ProductDto product)
        {
            await UpdateRemainingFields(new[] { product });
        }
        public async Task UpdateRemainingFields(IEnumerable<ProductDto> products)
        {
            await AppConnection.OnConnection(_createConnection, async (conn) =>
                await conn.ExecuteAsync(@"
                UPDATE [Products] 
                SET Barcode = @Barcode
                   ,Status = @Status
                   ,ImportedAt = @ImportedAt
                   ,Quantity = @Quantity
                   ,Categories = @Categories
                   ,Packaging = @Packaging
                   ,Brands = @Brands                 
                WHERE Id = @Id"
                , products));
        }
    }
}
