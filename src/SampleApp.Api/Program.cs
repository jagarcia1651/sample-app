using SampleApp.Api;
using SampleApp.Application;
using SampleApp.Infrastructure;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApplication()
    .AddInfrastructure()
    .AddApi();

builder.WebHost.UseUrls("https://localhost:5001");

WebApplication app = builder.Build();

app.AddApi();

app.UseHttpsRedirection();

app.Run();
