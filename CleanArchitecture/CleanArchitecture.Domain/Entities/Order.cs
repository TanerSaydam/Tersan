using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Entities;

public sealed class Order : Entity
{
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    public decimal Price { get; set; }
}
