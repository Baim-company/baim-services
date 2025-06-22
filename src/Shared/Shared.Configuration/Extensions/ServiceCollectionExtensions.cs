using Shared.Configuration.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace Shared.Configuration.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSharedConfiguration(this IServiceCollection services)
    {
        services.AddSingleton<ConnectionStringsSettings>();
        services.AddSingleton<JwtSettings>();
        services.AddSingleton<SmtpSettings>();
        services.AddSingleton<QueueSettings>();
        return services;
    }
}
