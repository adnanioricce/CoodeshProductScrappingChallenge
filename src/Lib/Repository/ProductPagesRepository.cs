using Dapper;
using ProductScrapper.Lib;
using ProductScrapper.Lib.Models;
using ProductScrapper.Lib.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repository
{
    public class ProductPagesRepository
    {
        private readonly CreateConnection _createConnection;
        private readonly HttpClient _client = new HttpClient();
        private readonly ProductScrapperService _scrapperService;
        public ProductPagesRepository(CreateConnection createConnection, ProductScrapperService scrapperService)
        {
            _createConnection = createConnection;            
            _scrapperService = scrapperService;
        }

        public async Task BulkCreateAsync(IEnumerable<Product> products)
        {
            await AppConnection.OnConnection(_createConnection, async (conn) =>
            {
                return await conn.ExecuteAsync("INSERT INTO [ProductDrafts](Url,Status) VALUES(@Url,@Status)", products);
            });
        }

        public async Task<IEnumerable<ProductScrapPage>> GetPagesToScrapAsync()
        {
            var pagesToScrap = await AppConnection.OnConnection(_createConnection, async (conn) =>
            {
                var query = @"SELECT * FROM [ProductDrafts] as p
                WHERE p.Status = 0
                ORDER BY p.Id";
                return await conn.QueryAsync<ProductScrapPage>(query);
            });
            return pagesToScrap;            
        }
        public async Task RegisterPagesToScrapAsync()
        {
            var baseUrl = "https://world.openfoodfacts.org/";
            var lastPage = await _scrapperService.ScrapLastProductPage(_client.GetStringAsync, baseUrl);
            Enumerable.Range(1, lastPage).Select(page => new ProductScrapPage($"{baseUrl}"));
        }
    }
}
