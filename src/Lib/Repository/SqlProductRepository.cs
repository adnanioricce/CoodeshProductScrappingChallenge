using Dapper;
using ProductScrapper;
using System.Data;

namespace Lib.Repository
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
        public async Task BulkCreateAsync(IEnumerable<Product> products)
        {            
            foreach (var product in products)
            {
                var existingProduct = await GetByCodeAsync(product.Code);
                var isDefault = existingProduct == default;
                var isEqual = existingProduct == product;
                if (!isDefault && !isEqual)
                {
                    await Create(product with
                    {
                        ImportedAt = DateTimeOffset.UtcNow.ToString()
                    });
                    continue;
                }
                if (!isEqual)
                {
                    await Update(product with
                    {
                        ImportedAt = DateTimeOffset.UtcNow.ToString()
                    });
                }
            }            
        }

        public async Task Create(Product product)
        {
            await BulkCreateAsync(new[] { product });
        }

        public async Task<Product> GetByCodeAsync(long code)
        {
            return await AppConnection.OnConnection(_createConnection,
                async (conn) =>
                {
                    using var reader = await conn.ExecuteReaderAsync("SELECT * FROM dbo.[Products] WHERE Code = @Code", new { Code = code });
                    if (reader.Read())
                    {
                        return Product.Read(reader);
                    }
                    return default;
                });
        }

        public async Task<Product> GetByIdAsync(long id)
        {
            return await AppConnection.OnConnection(_createConnection,
                async (conn) => await conn.QueryFirstAsync<Product>("SELECT * FROM dbo.[Products] WHERE Id = @Id", new { Id = id }));
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            try
            {
                Func<IDbConnection, Task<IEnumerable<Product>>> readRows = async (conn) =>
                {
                    using var reader = await conn.ExecuteReaderAsync("SELECT * FROM dbo.[Products]");
                    var products = new List<Product>();
                    while (reader.Read())
                    {
                        products.Add(Product.Read(reader));
                    }
                    return products;
                };
                var result = await AppConnection.OnConnection(_createConnection, readRows);
                return result;
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Product>();
            }
        }

        public async Task<IEnumerable<Product>> ListAsync(int page, int pageCount)
        {
            try
            {
                var query = $@"
        SELECT * FROM dbo.[Products] 
        ORDER BY Code
        OFFSET {page * pageCount}        
        ROWS FETCH NEXT {pageCount} ROWS ONLY";
                Func<IDbConnection, Task<IEnumerable<Product>>> readRows = async (conn) =>
                {
                    using var reader = await conn.ExecuteReaderAsync(query);
                    var products = new List<Product>();
                    while (reader.Read())
                    {
                        products.Add(Product.Read(reader));
                    }
                    return products;
                };
                var result = await AppConnection.OnConnection(_createConnection, readRows);
                return result;
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Product>();
            }
        }
        public async Task Update(Product product)
        {
            var query = @"
                UPDATE [Products] 
                SET
                   Code = @Code
                   ,Barcode = @Barcode
                   ,Url = @Url
                   ,ProductName = @ProductName
                   ,Status = @Status
                   ,ImportedAt = @ImportedAt
                   ,Quantity = @Quantity
                   ,Categories = @Categories
                   ,Packaging = @Packaging
                   ,Brands = @Brands       
                   ,ImageUrl = @ImageUrl
                WHERE Id = @Id";
            await AppConnection.OnConnection(_createConnection, async (conn) => await conn.ExecuteAsync(query, product));
        }       
    }
}
