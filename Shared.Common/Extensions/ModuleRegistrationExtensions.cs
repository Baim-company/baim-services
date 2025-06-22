using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shared.Common.Interfaces.Modules;
using System.Reflection;

namespace Shared.Common.Extensions;

public static class ModuleRegistrationExtensions
{
    public static void RegisterAllModules(this IServiceCollection services, IConfiguration config)
    {
        services.RegisterModules(config, AppDomain.CurrentDomain
            .GetAssemblies()
            .Where(a => !a.IsDynamic)
            .ToArray());
    }

    public static void RegisterModules(this IServiceCollection services, IConfiguration config, params Assembly[] assemblies)
    {
        var modules = assemblies
            .SelectMany(a => a.GetTypes())
            .Where(t => typeof(IModule).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
            .Select(Activator.CreateInstance)
            .Cast<IModule>();

        foreach (var module in modules)
        {
            module.Register(services, config);
        }
    }
}
