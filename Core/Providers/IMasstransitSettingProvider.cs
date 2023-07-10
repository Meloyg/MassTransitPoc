namespace Core.Providers;

public interface IMasstransitSettingProvider
{
    string GetHost();
    string GetUsername();
    string GetPassword();
    string GetVirtualHost();
}