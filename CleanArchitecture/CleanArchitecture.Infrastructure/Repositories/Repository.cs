using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Infrastructure.Context;

namespace CleanArchitecture.Infrastructure.Repositories;

public class Repository<T>(ApplicationDbContext context) : IRepository<T>
    where T : class
{
    public async Task CreateAsync(T entity, CancellationToken cancellationToken = default)
    {
        await context.Set<T>().AddAsync(entity, cancellationToken);
    }

    public IQueryable<T> GetAll()
    {
        return context.Set<T>().AsQueryable();
    }
}
