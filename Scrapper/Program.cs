using Scrapper;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddHostedService<ScrapperWorker>();
    })
    .Build();

await host.RunAsync();
