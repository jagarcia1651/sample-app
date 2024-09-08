using FastEndpoints;
using FastEndpoints.Swagger;
using SampleApp.Api;
using SampleApp.Application;
using SampleApp.Infrastructure;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApplication()
    .AddInfrastructure()
    .AddApi();

WebApplication app = builder.Build();

app.AddApi();

app.UseHttpsRedirection();

app.Run();
