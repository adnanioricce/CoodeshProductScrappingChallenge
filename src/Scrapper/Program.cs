using ProductScrapper;
using Scrapper;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<CreateConnection>(AppConnection.CreateConnection);
        services.AddTransient<ProductScrapper.ProductScrapper>();
        services.AddTransient<IProductRepository, SqlProductRepository>();
        //services.AddHostedService<Worker>();
        services.AddHostedService<ScrapperWorker>();
    })
    .Build();

await host.RunAsync();
