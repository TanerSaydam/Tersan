namespace CleanArchitecture.Domain.Repositories;

public interface IRepository<T>
{
    Task CreateAsync(T entity, CancellationToken cancellationToken = default);
    IQueryable<T> GetAll();
}