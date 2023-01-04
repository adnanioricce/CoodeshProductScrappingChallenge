namespace ProductScrapper
{
    using AngleSharp;
    using AngleSharp.Dom;
    using AngleSharp.Html.Parser;

    public class ProductParser
    {
        private readonly HtmlParser _parser = new HtmlParser();
        /// <summary>
        /// Parse a list of products from the page
        /// </summary>
        /// <param name="str">the HTML string with the product data to be scrapped</param>
        /// <returns>a <see cref="IEnumerable{T}"/> of <see cref="ProductDto"/></returns>
        public async Task<IEnumerable<ProductDto>> ParseProductsFromPage(string str)
        {
            var parsedContent = await _parser.ParseDocumentAsync(str);
            var products = parsedContent.QuerySelectorAll(".search_results li a");
            //var product = products[0];
            //var productStr = product.Html();
            //File.WriteAllText("product.html",productStr);
            return products.Select(p => ParseProduct(p));
        }
        /// <summary>
        /// Parse product descrption page
        /// </summary>
        /// <param name="str">the HTML string with the product data to be scrapped</param>
        /// <returns>a <see cref="IEnumerable{T}"/> of <see cref="ProductDto"/></returns>
        public async Task<ProductDto> ParseProductDescriptionPage(string str,ProductDto previousProduct)
        {
            var parsedContent = await _parser.ParseDocumentAsync(str);
            var productSection = parsedContent.QuerySelector("#product");
            var barcode = productSection?.QuerySelector("#barcode_paragraph")?.TextContent?.Trim();
            var code = productSection?.QuerySelector("#barcode")?.TextContent;
            var commonName = productSection?.QuerySelector("#field_generic_name")?.TextContent?.Trim();
            var packaging = 
                productSection?.QuerySelectorAll("#field_packaging_value a.tag.user_defined")?.Select(p => p.TextContent)?.ToArray()
                ?? Enumerable.Empty<string>().ToArray();
            var brands =
                productSection?.QuerySelector("#field_brands")?.TextContent?.Trim();
            var categories = productSection?.QuerySelector("#field_categories")?.TextContent?.Trim();
            var quantity = productSection?.QuerySelector("#field_quantity_value")?.TextContent?.Trim();
            var product = previousProduct with
            {
                Barcode = barcode ?? ""
                ,Brands = brands ?? ""
                ,Categories = categories ?? ""
                ,Quantity = quantity ?? ""
                ,Packaging = string.Join(",",packaging)                
                ,Code = Convert.ToInt64(code)
                ,Status = ProductStatus.Imported   
                ,ProductName = commonName ?? ""                
            };
            return product;            
        }
        /// <summary>
        /// Parse the given <see cref="IElement"/> as a <see cref="ProductDto"/>
        /// </summary>
        /// <param name="p">a <see cref="IElement"/></param>
        /// <returns>a <see cref="ProductDto"/> with the data from the given <see cref="IElement"/></returns>
        public static ProductDto ParseProduct(IElement p)
        {            
            string url = p.GetAttribute("href") ?? "";
            var urlParts = url.Replace("https://", "").Split("/");
            var code = "";
            try
            {
                code = urlParts[2];
            }
            catch(Exception ex)
            {
                throw;
            }
            string imageUrl = p.QuerySelector("img")?.GetAttribute("src") ?? "";            
            return new ProductDto
            {
                Code = Convert.ToInt64(code)
                //,ProductName = productName
                //,Brands = brands
                //,Quantity = quantity
                ,Url = url
                ,ImageUrl = imageUrl
                ,Status = ProductStatus.Draft
            };            
        }
        /// <summary>
        /// Get the last index of the pagination of products of the page.
        /// </summary>
        /// <param name="content">the HTML content with the paginated product grid</param>
        /// <returns>the last page of the pagination grid</returns>
        public async Task<int> ParseLastProductPage(string content)
        {
            var doc = await _parser.ParseDocumentAsync(content);
            var pages = doc.QuerySelectorAll("#pages li")
                ?.Select(p => int.TryParse(p.TextContent ?? "", out var r) ? r : 0)
                ?.ToArray();
            pages = pages ?? Enumerable.Empty<int>().ToArray();
            return pages.Any() ? pages.Max() : -1;
        }
    }
}