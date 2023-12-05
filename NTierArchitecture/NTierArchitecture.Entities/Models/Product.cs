namespace NTierArchitecture.Entities.Models;
public sealed class Product
{
    public Product()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; } //20Xasd12asdawda //123c-ad564-15645 //1 2 3 4        
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }    
}
