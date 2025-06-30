using Microsoft.Extensions.DependencyInjection;

namespace Baim.Identity.Services.Modules;

public static class ApplicationModule
{
    public static IServiceCollection AddIdentityServices(this IServiceCollection services)
    {
        //services.AddScoped<IUserRepository, UserRepository>()

        return services;
    }
}
