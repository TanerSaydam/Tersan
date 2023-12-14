namespace DDD.Products;

public sealed record Price
{
    public Price(decimal value)
    {
        if(value < 0) throw new ArgumentException("value");

        Value = value;
    }
    public decimal Value { get; init; }
}
