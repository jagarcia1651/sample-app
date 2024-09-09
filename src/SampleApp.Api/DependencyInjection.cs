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

        services.AddCors(options =>
        {
            options.AddPolicy("AllowReactApp",
                builder =>
                {
                    builder.WithOrigins("http://localhost:8080")
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
        });

        return services;
    }

    public static WebApplication AddApi(this WebApplication app)
    {
        app.UseFastEndpoints().UseSwaggerGen();

        app.UseCors("AllowReactApp");

        return app;
    }
}
