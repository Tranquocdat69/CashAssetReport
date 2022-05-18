IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.UseServiceCollectionConfiguration(hostContext.Configuration);
    })
    .Build();

host.UseHostConfiguration();
await host.RunAsync();
