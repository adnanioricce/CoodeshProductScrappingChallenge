namespace ProductScrapper
{
    public class FakeProductRepository : IProductRepository
    {
        private readonly List<ProductDto> products = new List<ProductDto>() {
            new ProductDto(){
                Id = 1,
                Code = 3661112502850,
                Barcode = "3661112502850(EAN / EAN-13)",
                Status = ProductStatus.Imported,
                //ImportedAt = DateTimeOffset.Parse("2020-02-07T16:00:00Z"),
                ImportedAt = "2020-02-07T16:00:00Z",
                Url = "https://world.openfoodfacts.org/product/3661112502850",
                ProductName = "Jambon de Paris cuit à l'étouffée",
                Quantity = "240 g",
                Categories = "Meats, Prepared meats, Hams, White hams",
                Packaging = "Film en plastique, Film en plastique",
                Brands = "Tradilège, Marque Repère",
                ImageUrl = "https://static.openfoodfacts.org/images/products/366/111/250/2850/front_fr.3.400.jpg"
            }
        };
        public Task<ProductDto> GetByIdAsync(long id)
        {
            ProductDto product = products.Where(p => p.Id == id).FirstOrDefault();
            return Task.FromResult(product);
        }
        public Task<ProductDto> GetByCodeAsync(long code)
        {
            ProductDto product = products.Where(p => p.Code == code).FirstOrDefault();
            return Task.FromResult(product);
        }
        public Task<IEnumerable<ProductDto>> ListAsync()
        {
            return Task.FromResult(products.AsEnumerable());
        }
        public Task Create(ProductDto product)
        {
            products.Add(product);
            return Task.CompletedTask;
        }

        public Task BulkCreateAsync(IEnumerable<ProductDto> products)
        {
            //TODO:
            return Task.CompletedTask;
        }
        public Task UpdateRemainingFields(ProductDto product)
        {
            return Task.CompletedTask;
        }
    }
}
