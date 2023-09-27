namespace Domain;

public class Ordr
{
    public required Address BillingAddress { get; set; }

    public required string Contents { get; set; }

    public Customer Customer { get; set; } = null!;

    public Guid Id { get; set; } = Guid.NewGuid();

    public required Address ShippingAddress { get; set; }
}

public record Address
{
    public required string City { get; init; }
    public required string Country { get; init; }
    public required string Line1 { get; init; }
    public string? Line2 { get; init; }
    public required int PostalCode { get; init; }
    public required string State { get; init; }
}

public class Customer
{
    public required Address Address { get; set; }

  public Guid Id { get; set; } = Guid.NewGuid();

    public required string Name { get; set; }

    public List<Ordr> Orders { get; } = new List<Ordr>();
}