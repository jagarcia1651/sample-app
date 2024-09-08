using OneOf;
using OneOf.Types;

namespace SampleApp.Application.Customers.List;

[GenerateOneOf]
public partial class ListCustomersResult : OneOfBase<List<CustomerModel>, NotFound, Error<string>> { };
