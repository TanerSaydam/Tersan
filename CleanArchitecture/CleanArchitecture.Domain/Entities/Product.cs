using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Entities;
public sealed class Product : Entity
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public DateTime CreatedDate { get; set; }
}
