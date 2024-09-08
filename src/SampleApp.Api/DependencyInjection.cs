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
            options.AddPolicy("AllowLocalhost5000",
                builder =>
                {
                    builder.WithOrigins("http://localhost:5000")
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
        });

        return services;
    }

    public static WebApplication AddApi(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseFastEndpoints().UseSwaggerGen();

            app.UseCors("AllowLocalhost5000");
        }

        return app;
    }
}
