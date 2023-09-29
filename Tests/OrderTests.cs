using Domain;
using Xunit;

namespace Tests;

public class OrderTests
{
    [Fact]
    public void Order_InitializesIdToNewGuid()
    {
        Address address = new Address { Line1 = "123 Main St", City = "Somewhere", State = "ST", PostalCode = "12345", Country = "USA" };
        Assert.NotEqual(default, new Order { Contents = "Stuff", BillingAddress = address, ShippingAddress = address });
    }
}