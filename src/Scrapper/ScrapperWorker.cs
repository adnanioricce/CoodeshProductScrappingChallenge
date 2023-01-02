using ProductScrapper;

namespace Scrapper
{
    public sealed class ScrapperWorker : BackgroundService
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
            using var client = new HttpClient();
            _logger.LogInformation("Scrapping list of products to be scrapped...");
            var products = await _scrapper.ScrapProductListAsync(client.GetStringAsync, _initialUrl) ?? Enumerable.Empty<ProductDto>();            
            var productsFilled = new ProductDto[products.Count()];            
            _logger.LogInformation("Scrapping each product individually");
            var elements = products.Select((Product, Index) => (Index, Product));            
            foreach (var (Index,Product) in elements)
            {                                
                _logger.LogInformation("Scrapping product {0} of code {1}", Index, Product.Code);
                productsFilled[Index] = await _scrapper.ScrapProductDescription(client.GetStringAsync,$"{_initialUrl}{Product.Url}", Product);
            }            
            _logger.LogInformation("Saving all products");
            await _productRepository.BulkCreateAsync(productsFilled);
        }
    }
}
