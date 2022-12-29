using ProductScrapper;
namespace Scrapper
{
    internal sealed class ScrapperWorker : BackgroundService
    {
        private readonly ProductScrapper.ProductScrapper _scrapper;
        private readonly IProductRepository _productRepository;
        private readonly string _initialUrl = "https://world.openfoodfacts.org/";
        public ScrapperWorker(ProductScrapper.ProductScrapper scrapper,IProductRepository productRepository)
        {
            _scrapper = scrapper;
            _productRepository = productRepository;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var client = new HttpClient();
            var products = await _scrapper.ScrapProductListAsync(client.GetStringAsync, _initialUrl) ?? Enumerable.Empty<ProductDto>();
            //TODO: Save products
            //await _productRepository.BulkCreateAsync(products);
            //TODO: Scrap remaining data for each products
            var productsFilled = new ProductDto[products.Count()];
            foreach(var (Index,Value) in products.Select((p,index) => (index,p) ))
            {
                productsFilled[Index] = await _scrapper.ScrapProductDescription(client.GetStringAsync, _initialUrl,Value);                
            }
            await _productRepository.BulkCreateAsync(products);
        }
    }
}
