using Lib.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ProductScrapper
{
    public delegate Task<IEnumerable<Product>> ListProductsAsync(int page,int pageCount);
    public delegate Task<Product> GetByCodeAsync(long code);
    public class ProductEndpoints : IApiDefinition
    {        
        public ProductEndpoints()
        {            
        }
        public void SetupServices(IServiceCollection services)
        {
            //Configura as dependências
            services.AddSingleton<CreateConnection>(AppConnection.CreateConnection);            
            services.AddTransient<IProductRepository, SqlProductRepository>();            
        }
        public void SetupEndpoints(WebApplication app)
        {
            //Configura os endpoints
            app.MapGet("products/{code:long}",
                ([FromServices] IProductRepository productRepository,long code) => GetByCodeAsync(productRepository.GetByCodeAsync,code));
            //TODO: Allow content pagination
            app.MapGet("products",
                ([FromServices] IProductRepository productRepository,int page,int pageCount) => ListAsync(productRepository.ListAsync,page,pageCount));
        }
        private static async Task<IResult> Handle(Func<Task<IResult>> func)
        {
            try
            {
                return await func();
            }
            catch (Exception)
            {

                return Results.StatusCode(500);
            }
        }
        public static async Task<IResult> ListAsync(ListProductsAsync listProductsAsync,int page,int pageCount)
        {
            return await Handle(async () =>
            {
                var products = await listProductsAsync(page, pageCount);
                if (!products.Any())
                    return Results.NoContent();

                var result = Results.Ok(products);
                return result;
            });            
        }

        public static async Task<IResult> GetByCodeAsync(GetByCodeAsync getByCodeAsync, long code)
        {
            return await Handle(async () => { 
                var product = await getByCodeAsync(code);
                if (product == default)
                    return Results.NoContent();

                var result = Results.Ok(product);
                return result;
            });
        }
    }
}
