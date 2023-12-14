namespace DDD.Products;
public sealed class Product
{
    public Product(string name, decimal price)
    {    
        Id = Guid.NewGuid();
        Name = new(name);
        Price = new(price);
    }
    public Guid Id { get; private set; }
    public Name Name { get; private set; }
    public Price Price { get; private set; }

    public void ChangeName(string name)
    {
        Name = new(name);
    }

    public void ChangePrice(decimal price)
    {
        Price = new(price);
    }
}
