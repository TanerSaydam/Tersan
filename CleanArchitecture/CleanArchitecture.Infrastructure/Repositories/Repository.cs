using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CleanArchitecture.Infrastructure.Repositories;
public class Repository<T>(ApplicationDbContext context) : IRepository<T>
    where T : class
{
    public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        await context.Set<T>().AddAsync(entity, cancellationToken);
    }

    public async Task AddSaveAsync(T entity, CancellationToken cancellationToken = default)
    {
        await context.Set<T>().AddAsync(entity, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
    {
        return await context.Set<T>().AnyAsync(expression, cancellationToken);
    }

    public IQueryable<T> GetAll()
    {
        return context.Set<T>().AsQueryable();
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
    {
        return context.Set<T>().Where(expression).AsQueryable();
    }
}
