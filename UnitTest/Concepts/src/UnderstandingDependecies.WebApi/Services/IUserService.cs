using UnderstandingDependecies.WebApi.Models;

namespace UnderstandingDependecies.WebApi.Services;

public interface IUserService
{
    Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default);
}
