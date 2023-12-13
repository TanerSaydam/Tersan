using Microsoft.EntityFrameworkCore;
using UnderstandingDependecies.WebApi.Context;
using UnderstandingDependecies.WebApi.Models;

namespace UnderstandingDependecies.WebApi.Repositories;

public sealed class UserRepository(ApplicationDbContext context) : IUserRepository
{
    public async Task<bool> CreateAsync(User user, CancellationToken cancellationToken = default)
    {
        await context.AddAsync(user, cancellationToken);
        var result = await context.SaveChangesAsync(cancellationToken);
        return result > 0;
    }

    public async Task<List<User>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await context.Users.ToListAsync(cancellationToken);
    }

    public async Task<bool> NameIsExist(string fullName, CancellationToken cancellationToken = default)
    {
        return await context.Users.AnyAsync(p => p.FullName == fullName, cancellationToken);
    }
}
