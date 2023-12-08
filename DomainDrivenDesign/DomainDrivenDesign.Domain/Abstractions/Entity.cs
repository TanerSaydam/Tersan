namespace DomainDrivenDesign.Domain.Abstractions;
public abstract class Entity
{
    public Entity()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; init; }

    public override bool Equals(object? obj)
    {
        if(obj is null || obj is not Entity entity)
        {
            return false;
        }

        return entity.Id == Id;
    }
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}