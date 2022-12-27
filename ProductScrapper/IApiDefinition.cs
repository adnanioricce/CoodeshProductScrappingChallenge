namespace ProductScrapper
{
    public interface IApiDefinition
    {
        void SetupServices(IServiceCollection services);
        void SetupEndpoints(WebApplication app);
    }
}
