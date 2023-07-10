namespace Core.Providers;

public class MasstransitSettingProvider: IMasstransitSettingProvider
{
    public string GetHost()
    {
        getva
    }

    public string GetUsername()
    {
        throw new NotImplementedException();
    }

    public string GetPassword()
    {
        throw new NotImplementedException();
    }

    public string GetVirtualHost()
    {
        throw new NotImplementedException();
    }
    
    private IDictionary GetValues()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
        var configuration = builder.Build();
        return configuration.GetSection("Masstransit").Get<Dictionary<string, string>>();
    }
}