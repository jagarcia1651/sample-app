using FastEndpoints;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using SampleApp.Application.Customers.List;

namespace SampleApp.Api.Features.v1.Customers.List;

public class ListCustomersEndpoint(ISender sender) : Endpoint<ListCustomersRequest, Results<Ok<List<CustomerRecord>>, NotFound, ProblemDetails>>
{
    public override void Configure()
    {
        AllowAnonymous();
        Get(CustomerConstants.List);
        Description(x => x.WithTags(CustomerConstants.Tag));
    }

    public override async Task<Results<Ok<List<CustomerRecord>>, NotFound, ProblemDetails>> ExecuteAsync(ListCustomersRequest request, CancellationToken cancellationToken)
    {
        var query = new ListCustomersQuery(request.CompanyId);

        ListCustomersResult result = await sender.Send(query, cancellationToken);

        if (result.IsT2)
        {
            AddError(result.AsT2.Value);
            return new ProblemDetails();
        }

        if (result.IsT1)
        {
            return TypedResults.NotFound();
        }

        return TypedResults.Ok(result.AsT0.Select(CustomerRecord.MapFromModel).ToList());
    }
}
