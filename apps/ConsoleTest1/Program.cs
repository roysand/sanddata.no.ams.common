using ConsoleTest1;
using sanddata.no.ams.common.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using sanddata.no.ams.common.Infrastructure.Config;
using sanddata.no.ams.common.Infrastructure.Persistence;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var configuration = new ConfigurationBuilder()
    .AddJsonFile("local.settings.json")
    .Build();

using IHost host = CreateHostBuilder(args, configuration).Build();

// create a service scope
using var scope = host.Services.CreateScope();

var services = scope.ServiceProvider;

try
{
    await services.GetRequiredService<App>().Run(args);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

IHostBuilder CreateHostBuilder(string[] strings, IConfiguration config)
{
    return Host.CreateDefaultBuilder()
        .ConfigureServices((_, service) =>
        {
            service.AddTransient<IConfig, Config>();
            service.AddTransient<IApplicationDbContext, ApplicationDbContext>();
            service.AddSingleton<App>();
        })
        .ConfigureHostConfiguration(hostConfig =>
        {
            hostConfig.AddConfiguration(config);
        });
}