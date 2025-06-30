using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shared.Configuration.Settings;
using Baim.Identity.Data.DbContexts;

namespace Baim.Identity.Data.Modules;

public static class DataModule
{
    public static IServiceCollection AddDataModule(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<IdentityDbContext>((sp, options) =>
        {
            var connection = sp.GetRequiredService<ConnectionStringsSettings>().IdentityDb;
            options.UseNpgsql(connection);
        });

        return services;
    }
}
