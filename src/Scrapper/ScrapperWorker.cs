using ProductScrapper;
using System.Collections.Concurrent;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Scrapper
{
    internal sealed class ScrapperWorker : BackgroundService
    {
        private readonly ProductScrapper.ProductScrapper _scrapper;
        private readonly IProductRepository _productRepository;
        private readonly string _initialUrl = "https://world.openfoodfacts.org/";
        private readonly ILogger<ScrapperWorker> _logger;
        public ScrapperWorker(ProductScrapper.ProductScrapper scrapper,IProductRepository productRepository,ILogger<ScrapperWorker> logger)
        {
            _scrapper = scrapper;
            _productRepository = productRepository;
            _logger = logger;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var client = new HttpClient();
            _logger.LogInformation("Scrapping list of products to be scrapped...");
            var products = await _scrapper.ScrapProductListAsync(client.GetStringAsync, _initialUrl) ?? Enumerable.Empty<ProductDto>();            
            var productsFilled = new ProductDto[products.Count()];            
            _logger.LogInformation("Scrapping each product individually");
            var elements = products.Select((p, index) => (index, p));            
            foreach (var el in elements)
            {                                
                _logger.LogInformation("Scrapping product {0} of code {1}", el.index, el.p.Code);
                productsFilled[el.index] = await _scrapper.ScrapProductDescription(client.GetStringAsync,$"{_initialUrl}{el.p.Url}", el.p);
            }            
            _logger.LogInformation("Saving all products");
            await _productRepository.BulkCreateAsync(productsFilled);
        }
    }
}
