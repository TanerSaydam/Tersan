using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Entities;

public sealed class Category : Entity
{
    public string Name {  set; get; }
}
