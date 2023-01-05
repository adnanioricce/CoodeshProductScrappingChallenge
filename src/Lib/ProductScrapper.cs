namespace ProductScrapper.Lib
{
    using Models;
    public sealed class ProductScrapperService
    {        
        private readonly ProductParser _parser = new ProductParser();
        //Get list of products...
        public async Task<IEnumerable<Product>> ScrapProductListAsync(Func<string?,Task<string>> getStringAsync,string url)
        {            
            var pageStr = await getStringAsync(url);
            if(pageStr == null)            
                return Enumerable.Empty<Product>();
            
            var products = await _parser.ParseProductsFromPage(pageStr);
            return products;
        }        
        // then, scrap remaining data individually one by one
        public async Task<Product> ScrapProductDescription(Func<string?, Task<string>> getStringAsync, string url,Product productDto)
        {
            var content = await getStringAsync(url);
            var productFilled = await _parser.ParseProductDescriptionPage(content, productDto);
            return productFilled with
            {
                Url = url
            };
        }
        public async Task<int> ScrapLastProductPage(Func<string?, Task<string>> getStringAsync, string url)
        {
            var content = await getStringAsync(url);
            var lastProductPage = await _parser.ParseLastProductPage(content);
            return lastProductPage;
        }
       
    }
}
