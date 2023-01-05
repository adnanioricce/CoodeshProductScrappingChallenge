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
        private readonly HttpClient _client;
        public ScrapperWorker(ProductScrapperService scrapper,
            IProductRepository productRepository,            
            ILogger<ScrapperWorker> logger)
        {
            _scrapper = scrapper;
            _productRepository = productRepository;            
            _logger = logger;
            _timer = new PeriodicTimer(TimeSpan.FromHours(8.0));
            _client = new HttpClient();            
        }       
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await Scrap();
            while (await _timer.WaitForNextTickAsync(stoppingToken)
                    && !stoppingToken.IsCancellationRequested)
            {
                await Scrap();
            }
        }        
        private async Task Scrap()
        {
            int scrapIndex = 1;                        
            var lastPageNumber = await _scrapper.ScrapLastProductPage(_client.GetStringAsync, _initialUrl);
            while(scrapIndex < lastPageNumber)
            {
                try
                {
                    _logger.LogInformation("Scrapping list of products to be scrapped...");
                    var url = _initialUrl + scrapIndex;
                    var products = await _scrapper.ScrapProductListAsync(_client.GetStringAsync, url) ?? Enumerable.Empty<Product>();                    
                    _logger.LogInformation("Scrapping each product individually");
                    var elements = products.Select((Product, Index) => (Index, Product));                    
                    Parallel.ForEach(elements, async (el) =>
                    {
                        var (Index, Product) = el;
                        try
                        {
                            _logger.LogInformation($"[Scrapping {url}] Product: {Product.ToString()}");
                            var scrappedProduct = await _scrapper.ScrapProductDescription(_client.GetStringAsync, _initialUrl + Product.Url, Product);
                            _logger.LogInformation($"[Scrapping {url}] [Product Code:{Product.Code}] Saving product...");
                            await _productRepository.Create(scrappedProduct);
                            _logger.LogInformation($"[Scrapping {url}] [Product Code:{Product.Code}] product Saved!");                            
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError($"[Scrapping {url}] [Product Code:{Product.Code}] Error when trying to scrap product {Product.ToString()} \n exception: {ex.ToString()}");
                        }
                    });                    
                    scrapIndex += 1;
                }
                catch(Exception ex)
                {
                    _logger.LogError("An exception was throwed when trying to scrap page {0} with url {1}", scrapIndex, _initialUrl + scrapIndex);
                }
            }            
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            if(_timer != null)
            {                
                _timer.Dispose();                
            }
            if (_client != null) {                 
                _client.Dispose();
            }
            return base.StopAsync(cancellationToken);
        }
    }
}
