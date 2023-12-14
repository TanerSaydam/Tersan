using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Entities;

public sealed class Product : Entity
{
    public string Name { get; set; }    
    public decimal Price { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}
