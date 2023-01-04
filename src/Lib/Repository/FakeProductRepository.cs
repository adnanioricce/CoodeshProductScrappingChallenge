using ProductScrapper;
using ProductScrapper.Lib.Models;

namespace ProductScrapper.Lib.Repository
{
    public sealed class FakeProductRepository : IProductRepository
    {
        private readonly List<Product> products = new List<Product>() {
            new Product(){
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
        public Task<Product> GetByIdAsync(long id)
        {
            Product product = products.Where(p => p.Id == id).FirstOrDefault();
            return Task.FromResult(product);
        }
        public Task<Product> GetByCodeAsync(long code)
        {
            Product product = products.Where(p => p.Code == code).FirstOrDefault();
            return Task.FromResult(product);
        }
        public Task<IEnumerable<Product>> ListAsync()
        {
            return Task.FromResult(products.AsEnumerable());
        }
        public Task Create(Product product)
        {
            products.Add(product);
            return Task.CompletedTask;
        }

        public Task BulkCreateAsync(IEnumerable<Product> products)
        {
            //TODO:
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Product>> ListAsync(int page, int pageCount)
        {
            return Task.FromResult(products.Skip(page).Take(pageCount));
        }
    }
}
