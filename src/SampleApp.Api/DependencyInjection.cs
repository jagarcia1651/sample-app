using System.Reflection;
using FastEndpoints;
using FastEndpoints.Swagger;

namespace SampleApp.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddApi(this IServiceCollection services)
    {
        services
            .AddFastEndpoints()
            .SwaggerDocument(o => o.AutoTagPathSegmentIndex = 0);

        services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }

    public static WebApplication AddApi(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseFastEndpoints().UseSwaggerGen();
        }

        return app;
    }
}
