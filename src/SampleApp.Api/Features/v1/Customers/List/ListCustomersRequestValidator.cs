using FastEndpoints;
using FluentValidation;

namespace SampleApp.Api.Features.v1.Customers.List;

public class ListCustomersRequestValidator : Validator<ListCustomersRequest>
{
    public ListCustomersRequestValidator()
    {
        RuleFor(request => request.CompanyId)
            .NotEmpty()
            .WithMessage($"Please provide a valid value for {nameof(ListCustomersRequest.CompanyId)}");
    }
}

