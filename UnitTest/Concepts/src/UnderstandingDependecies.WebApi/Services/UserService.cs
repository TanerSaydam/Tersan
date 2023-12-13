using System.Diagnostics;
using UnderstandingDependecies.WebApi.Models;
using UnderstandingDependecies.WebApi.Repositories;

namespace UnderstandingDependecies.WebApi.Services;

public sealed class UserService(IUserRepository userRepository) : IUserService
{    
    public async Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var users = await userRepository.GetAllAsync(cancellationToken);
        return users;
    }
}
