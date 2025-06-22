using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shared.Configuration.Settings;
using Shared.Common.Interfaces.Modules;
using Baim.Identity.Data.DbContexts;

namespace Identity.Data.Modules;

public class IdentityDataModule : IModule
{
    public void Register(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<IdentityDbContext>((sp, options) =>
        {
            var connection = sp.GetRequiredService<ConnectionStringsSettings>().IdentityDb;
            options.UseNpgsql(connection);
        });
    }
}
