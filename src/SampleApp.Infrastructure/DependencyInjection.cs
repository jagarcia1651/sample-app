using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace SampleApp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }
}
