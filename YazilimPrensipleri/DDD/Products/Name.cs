namespace DDD.Products;

public sealed record Name
{
    public Name(string value)
    {
        if(string.IsNullOrEmpty(value)) throw new ArgumentNullException("value");

        Value = value;
    }
    public string Value { get; init; }
}
