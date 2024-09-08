using MediatR;

namespace SampleApp.Application.Customers.List;
public class ListCustomersHandler : IRequestHandler<ListCustomersQuery, ListCustomersResult>
{
    public async Task<ListCustomersResult> Handle(ListCustomersQuery request, CancellationToken cancellationToken)
    {
        var result = new List<CustomerModel> { new("John", "Doe"), new("Jane", "Smith") };

        return await Task.FromResult(result);
    }
}
