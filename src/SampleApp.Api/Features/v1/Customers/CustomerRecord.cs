using SampleApp.Application.Customers;

namespace SampleApp.Api.Features.v1.Customers;

public record CustomerRecord(string FirstName, string LastName)
{
    public static CustomerRecord MapFromModel(CustomerModel model)
    {
        return new CustomerRecord(model.FirstName, model.LastName);
    }
};
