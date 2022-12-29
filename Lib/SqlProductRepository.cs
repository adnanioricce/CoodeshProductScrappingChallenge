using Dapper;
using ProductScrapper;
using System.Data;

namespace Lib
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
                , products));
        }

        public async Task Create(ProductDto product)
        {
            await BulkCreateAsync(new[] { product });
        }

        public async Task<ProductDto> GetByCodeAsync(long code)
        {
            return await AppConnection.OnConnection(_createConnection,
                async (conn) => await conn.QueryFirstAsync<ProductDto>("SELECT * FROM dbo.[Products] WHERE Code = @Code", new { Code = code }));
        }

        public async Task<ProductDto> GetByIdAsync(long id)
        {
            return await AppConnection.OnConnection(_createConnection,
                async (conn) => await conn.QueryFirstAsync<ProductDto>("SELECT * FROM dbo.[Products] WHERE Id = @Id", new { Id = id }));
        }

        public async Task<IEnumerable<ProductDto>> ListAsync()
        {
            return await AppConnection.OnConnection(_createConnection,
                async (conn) => await conn.QueryAsync<ProductDto>("SELECT * FROM dbo.[Products]"));
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
