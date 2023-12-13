using UnderstandingDependecies.WebApi.Models;

namespace UnderstandingDependecies.WebApi.Repositories;

public interface IUserRepository
{
    Task<List<User>> GetAllAsync(CancellationToken cancellationToken = default);
}