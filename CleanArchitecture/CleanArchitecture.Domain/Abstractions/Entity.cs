namespace CleanArchitecture.Domain.Abstractions;
public abstract class Entity
{
    public Entity()
    {
        Id = Guid.NewGuid();
        IsDeleted = false;
    }
    public Guid Id { get; set; }
    public bool IsDeleted { get; set; }
}

