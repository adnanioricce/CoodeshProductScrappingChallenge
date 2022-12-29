﻿namespace ProductScrapper
{
    public sealed class ProductScrapper
    {        
        private readonly ProductParser _parser = new ProductParser();
        //Get list of products...
        public async Task<IEnumerable<ProductDto>> ScrapProductListAsync(Func<string?,Task<string>> getStringAsync,string url)
        {            
            var pageStr = await getStringAsync(url);
            if(pageStr == null)            
                return Enumerable.Empty<ProductDto>();
            var products = await _parser.ParseProductsFromPage(pageStr);
            return products;
        }
        // then, scrap remaining data individually one by one

        public async Task<ProductDto> ScrapProductDescription(Func<string?, Task<string>> getStringAsync, string url,ProductDto productDto)
        {
            return new ProductDto();
        }
    }
}
