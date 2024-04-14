using Infrastructure.Services;

namespace WebAppASP.Configurations;

public static class ServicesConfiguration
{
    public static void RegisterServices(this IServiceCollection services, IConfiguration configure)
    {
        services.AddScoped<AccountService>();
    }
}
