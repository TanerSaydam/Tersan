using System.Linq.Expressions;

namespace CleanArchitecture.Domain.Repositories;
public interface IRepository<T>
{
    Task AddAsync(T entity, CancellationToken cancellationToken = default);
    Task AddSaveAsync(T entity, CancellationToken cancellationToken = default);
    IQueryable<T> GetAll();
    IQueryable<T> GetWhere(Expression<Func<T, bool>> expression);    
    Task<bool> AnyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
}
