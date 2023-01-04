using ProductScrapper;
using ProductScrapper.Lib;
using ProductScrapper.Lib.Models;
using ProductScrapper.Lib.Repository;

namespace Scrapper
{
    public sealed class ScrapperWorker : BackgroundService
    {
        private readonly ProductScrapperService _scrapper;
        private readonly IProductRepository _productRepository;
        private readonly string _initialUrl = "https://world.openfoodfacts.org/";
        private readonly ILogger<ScrapperWorker> _logger;
        private readonly PeriodicTimer _timer;        
        public ScrapperWorker(ProductScrapperService scrapper,
            IProductRepository productRepository,
            ILogger<ScrapperWorker> logger)
        {
            _scrapper = scrapper;
            _productRepository = productRepository;
            _logger = logger;
            _timer = new PeriodicTimer(TimeSpan.FromHours(8.0));            
        }
        private void Handle(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception throwed:{0}", ex);
                throw;
            }
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {            
            while (await _timer.WaitForNextTickAsync(stoppingToken)
                    && !stoppingToken.IsCancellationRequested)
            {
                await Scrap();
            }
        }

        private async Task Scrap()
        {
            int scrapIndex = 0;
            try
            {
                using var client = new HttpClient();
                var lastPageNumber = await _scrapper.ScrapLastProductPage(client.GetStringAsync, _initialUrl);
                while(scrapIndex < lastPageNumber)
                {
                    _logger.LogInformation("Scrapping list of products to be scrapped...");
                    var url = _initialUrl + scrapIndex;
                    var products = await _scrapper.ScrapProductListAsync(client.GetStringAsync, url) ?? Enumerable.Empty<Product>();
                    var productsFilled = new Product[products.Count()];
                    _logger.LogInformation("Scrapping each product individually");
                    var elements = products.Select((Product, Index) => (Index, Product));
                    foreach (var (Index, Product) in elements)
                    {
                        _logger.LogInformation("Scrapping product {0} of code {1}", Index, Product.Code);
                        productsFilled[Index] = await _scrapper.ScrapProductDescription(client.GetStringAsync, _initialUrl + Product.Url, Product);
                    }
                    _logger.LogInformation("Saving all products...");
                    await _productRepository.BulkCreateAsync(productsFilled);
                    _logger.LogInformation($"Products of page {url} saved! all products...");
                    ++scrapIndex;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("An exception was throwed when trying to scrap page {0} with url {1}", scrapIndex, _initialUrl + scrapIndex);
            }
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            return base.StopAsync(cancellationToken);
        }
    }
}
