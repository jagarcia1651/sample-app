using MediatR;

namespace SampleApp.Application.Customers.List;
public record ListCustomersQuery(string CompanyId) : IRequest<ListCustomersResult>;
