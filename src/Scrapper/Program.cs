using ProductScrapper.Lib;
using ProductScrapper.Lib.Repository;
using Scrapper;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<CreateConnection>(AppConnection.CreateConnection);
        services.AddTransient<ProductScrapperService>();
        services.AddTransient<IProductRepository, SqlProductRepository>();
        //services.AddHostedService<Worker>();
        services.AddHostedService<ScrapperWorker>();
    })
    .Build();

await host.RunAsync();
