using UnderstandingDependecies.WebApi.Models;

namespace UnderstandingDependecies.WebApi.Repositories;

public interface IUserRepository
{
    Task<bool> CreateAsync(User user, CancellationToken cancellationToken = default);
    Task<bool> NameIsExist(string fullName, CancellationToken cancellationToken = default);
    Task<List<User>> GetAllAsync(CancellationToken cancellationToken = default);
}