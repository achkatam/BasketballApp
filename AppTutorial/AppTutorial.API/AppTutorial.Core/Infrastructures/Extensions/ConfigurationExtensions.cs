namespace BasketballTeam.API.Infrastructures.Extensions;

using ViewModels.AuthViewModels;

public static class ConfigurationExtensions
{
    public static string GetDefaultConnectionString(this IConfiguration configuration)
        => configuration.GetConnectionString("DefaultConnection");

    public static AppSettings GetAppSettings(this IConfiguration configuration)
        => configuration.GetSection("ApplicationSettings").Get<AppSettings>();
}