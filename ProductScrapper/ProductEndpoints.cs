using Microsoft.AspNetCore.Mvc;

namespace ProductScrapper
{
    public class ProductEndpoints : IApiDefinition
    {        
        public ProductEndpoints()
        {            
        }
        public void SetupServices(IServiceCollection services)
        {
            //Configura as dependências
            services.AddTransient<IProductRepository, FakeProductRepository>();
        }
        public void SetupEndpoints(WebApplication app)
        {
            //Configura os endpoints
            app.MapGet("products/{code:long}", GetByIdAsync());
            //TODO: Allow content pagination
            app.MapGet("products", ListAsync);
        }

        public static async Task<IResult> ListAsync([FromServices] IProductRepository productRepository)
        {                        
            try
            {
                var products = await productRepository.ListAsync();
                if (!products.Any())
                {
                    return Results.NoContent();
                }

                return Results.Ok(products);
            }
            catch (Exception ex)
            {
                //TODO:Log
                return Results.StatusCode(500);
            }            
        }

        public static Func<IProductRepository, long, Task<ProductDto?>> GetByIdAsync()
        {
            return async ([FromServices] IProductRepository productRepository, long code) =>
            {
                var product = await productRepository.GetByCodeAsync(code);
                return product;
            };
        }
    }
}
