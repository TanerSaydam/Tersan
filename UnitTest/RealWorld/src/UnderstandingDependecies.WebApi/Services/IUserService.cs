using UnderstandingDependecies.WebApi.DTOs;
using UnderstandingDependecies.WebApi.Models;

namespace UnderstandingDependecies.WebApi.Services;

public interface IUserService
{
    Task<bool> CreateAsync(CreateUserDto request, CancellationToken cancellationToken = default);
    Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default);
    User CreateUserDtoToUserObject(CreateUserDto request);
}
