using FastEndpoints;

namespace SampleApp.Api.Features.v1;

public class SwaggerEndpoint : EndpointWithoutRequest
{
    public override void Configure()
    {
        AllowAnonymous();
        Get("/");
        Description(x => x.WithTags(string.Empty));
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        await SendRedirectAsync("/swagger");
    }
}
