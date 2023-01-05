using AngleSharp.Dom;
using Azure;
using Microsoft.Data.SqlClient;
using ProductScrapper.Lib.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using System.Threading.Tasks;
using ProductScrapper.Lib.Repository;

namespace IntegrationTests.CSharp
{
    using System;
    using Xunit;
    using Microsoft.Data.SqlClient;
    using System.Data;
    public class ProductRepositoryTests
    {
       
        [Theory]
        [InlineData(0, 50)]        
        public async Task Test_product_read(int page,int pageCount) {
            try
            {
                var createConn = () => new SqlConnection("Server=localhost,1741;Database=ProductScrapper;User Id=SA;Password=!P4ssword;TrustServerCertificate=True");
                var repository = new SqlProductRepository(new CreateConnection(createConn));
                var products = await repository.ListAsync(page, pageCount);
            }
            catch (Exception ex)
            {
                Assert.Fail($"Was not possible to read products, exception was throwed:{ex.ToString()}");
            }
        }
        [Fact]        
        public async Task test_product_creation()
        {
            var createConn = () => new SqlConnection("Server=localhost,1741;Database=ProductScrapper;User Id=SA;Password=!P4ssword;TrustServerCertificate=True");
            var product = new Product
            {
                Id = 0,
                Code = 3661112502850L,
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
            };
            var repository = new SqlProductRepository(new CreateConnection(createConn));
            try
            {
                await repository.Create(product);
                var productSaved = await repository.GetByCodeAsync(product.Code);                
            }
            catch (Exception ex)
            {
                Assert.Fail($"Exception when trying to save product:{ex.ToString()}");
            }
        }
    }
}