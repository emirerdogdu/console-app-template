using Microsoft.Extensions.Configuration;

public class App
{
    private readonly IConfiguration _config;

    public App(IConfiguration config)
    {
        _config = config;
    }

    public void Run()
    {
        Console.WriteLine($"App is running ({_config.GetValue<string>("Version")})");
    }
}
