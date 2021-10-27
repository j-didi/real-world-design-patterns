namespace RealWorldDesignPatterns.Strategy.Contract
{
    public record ShippingQuery(
        string ZipCode,
        decimal Height,
        decimal Width,
        decimal Weight,
        EShippingStrategy ShippingCompany
    );
}