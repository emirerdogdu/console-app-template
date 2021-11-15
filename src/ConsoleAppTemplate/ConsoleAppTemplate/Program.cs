using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var services = ConfigureServices();
var serviceProvider = services.BuildServiceProvider();

serviceProvider.GetService<App>()?.Run();

static IServiceCollection ConfigureServices()
{
    var services = new ServiceCollection();

    var config = LoadConfiguration();
    services.AddSingleton(config);

    /* add services here*/

    services.AddTransient<App>();

    return services;
}

static IConfiguration LoadConfiguration()
{
    var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

    return builder.Build();
}