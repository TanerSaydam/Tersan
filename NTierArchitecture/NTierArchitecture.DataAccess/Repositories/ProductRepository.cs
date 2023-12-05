using Microsoft.EntityFrameworkCore;
using NTierArchitecture.DataAccess.Context;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.DataAccess.Repositories;
public class ProductRepository(ApplicationDbContext context)
{
    public async Task AddAsync(Product product, CancellationToken cancellationToken = default)
    {
        await context.Set<Product>().AddAsync(product);        
    }

    public IQueryable<Product> GetAll()
    {
        return context.Set<Product>().AsQueryable();
    }

    public async Task<bool> IsNameExistsAsync(string name, CancellationToken cancellationToken = default)
    {
        return await context.Set<Product>().AnyAsync(p => p.Name == name, cancellationToken);
    }
}
