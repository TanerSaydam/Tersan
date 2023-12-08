namespace DomainDrivenDesign.Domain.Users;
public interface IUserRepository
{
    Task CreateAsync(CreateUserDto createUser, CancellationToken cancellationToken = default);
    IQueryable<User> GetAll();
}
