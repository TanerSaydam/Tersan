using Microsoft.EntityFrameworkCore;
using UnderstandingDependecies.WebApi.Context;
using UnderstandingDependecies.WebApi.Models;

namespace UnderstandingDependecies.WebApi.Repositories;

public sealed class UserRepository(ApplicationDbContext context) : IUserRepository
{
    public async Task<List<User>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await context.Users.ToListAsync(cancellationToken);
    }
}
