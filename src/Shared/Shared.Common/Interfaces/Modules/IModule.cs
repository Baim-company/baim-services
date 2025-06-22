using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Shared.Common.Interfaces.Modules;

public interface IModule
{
    void Register(IServiceCollection services, IConfiguration configuration);
}
