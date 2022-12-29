﻿using Microsoft.AspNetCore.Mvc;

namespace ProductScrapper
{
    public delegate Task<IEnumerable<ProductDto>> ListProductsAsync();
    public delegate Task<ProductDto> GetByCodeAsync(long code);
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
            app.MapGet("products/{code:long}",
                ([FromServices] IProductRepository productRepository,long code) => GetByCodeAsync(productRepository.GetByCodeAsync,code));
            //TODO: Allow content pagination
            app.MapGet("products",
                ([FromServices] IProductRepository productRepository) => ListAsync(productRepository.ListAsync));
        }

        public static async Task<IResult> ListAsync(ListProductsAsync listProductsAsync)
        {                        
            try
            {
                var products = await listProductsAsync();
                if (!products.Any())                
                    return Results.NoContent();                
                
                var result = Results.Ok(products);
                return result;
            }
            catch (Exception ex)
            {
                //TODO:Log
                return Results.StatusCode(500);
            }            
        }

        public static async Task<IResult> GetByCodeAsync(GetByCodeAsync getByCodeAsync, long code)
        {
            try
            {
                var product = await getByCodeAsync(code);
                if (product == default)
                    return Results.NoContent();

                var result = Results.Ok(product);
                return result;
            }
            catch(Exception ex)
            {
                //TODO: Log
                return Results.StatusCode(500);
            }
        }
    }
}
