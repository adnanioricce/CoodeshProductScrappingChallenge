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
            var products = parsedContent.QuerySelectorAll("#products_all li");
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
            var barcode = productSection?.QuerySelector("#barcode_paragraph")?.TextContent;
            var commonName = productSection?.QuerySelector("#field_generic_name")?.TextContent;
            var packaging = 
                productSection?.QuerySelectorAll("#field_packaging_value a.tag.user_defined")?.Select(p => p.TextContent)?.ToArray()
                ?? Enumerable.Empty<string>().ToArray();
            var brands =
                productSection?.QuerySelector("#field_brands")?.TextContent;
            var categories = productSection?.QuerySelector("#field_categories")?.TextContent;
            var quantity = productSection?.QuerySelector("#field_quantity_value")?.TextContent;
            var product = previousProduct with
            {
                Barcode = barcode ?? ""
                ,Brands = brands ?? ""
                ,Categories = categories ?? ""
                ,Quantity = quantity ?? ""
                ,Packaging = string.Join(",",packaging)                
            };
            return product;            
        }
        public static ProductDto ParseProduct(IElement p)
        {            
            string url = p.QuerySelector(".list_product_a")?.GetAttribute("href") ?? "";
            var urlParts = url.Replace("https://", "").Split("/");                        
            var code = urlParts[2];
            string imageUrl = p.QuerySelector(".list_product_img")?.GetAttribute("src") ?? "";
            string productDesc = p.QuerySelector(".list_product_name")?.TextContent ?? "";
            string[] productNameParts = productDesc.Split("-");
            var productName = productNameParts[0].Trim();
            return new ProductDto
            {
                Code = Convert.ToInt64(code)
                ,ProductName = productName
                //,Brands = brands
                //,Quantity = quantity
                ,Url = url
                ,ImageUrl = imageUrl
                ,Status = ProductStatus.Draft
            };            
        }
    }
}