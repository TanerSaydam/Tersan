using DomainDrivenDesign.Domain.Users;
using DomainDrivenDesign.Infrastructure.Context;

namespace DomainDrivenDesign.Infrastructure.Repositories;
public sealed class UserRepository(ApplicationDbContext context) : IUserRepository
{
    public async Task CreateAsync(CreateUserDto createUser, CancellationToken cancellationToken = default)
    {
        User user = new(createUser.Name, createUser.Email, createUser.Country, createUser.City, createUser.Street, createUser.FullAddress, createUser.Amount, createUser.Currency);


        await context.Set<User>().AddAsync(user, cancellationToken);
    }

    public IQueryable<User> GetAll()
    {
        return context.Set<User>().AsQueryable();
    }
}
