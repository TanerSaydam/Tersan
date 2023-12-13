using FluentValidation;
using UnderstandingDependecies.WebApi.DTOs;
using UnderstandingDependecies.WebApi.Models;
using UnderstandingDependecies.WebApi.Repositories;
using UnderstandingDependecies.WebApi.Validators;

namespace UnderstandingDependecies.WebApi.Services;

public sealed class UserService(IUserRepository userRepository) : IUserService
{
    public async Task<bool> CreateAsync(CreateUserDto request, CancellationToken cancellationToken = default)
    {
        CheckValidation(request);
        await CheckIsNameUnique(userRepository, request, cancellationToken);

        User user = CreateUserDtoToUserObject(request);

        var result = await userRepository.CreateAsync(user, cancellationToken);

        return result;
    }

    private static async Task CheckIsNameUnique(IUserRepository userRepository, CreateUserDto request, CancellationToken cancellationToken)
    {
        var nameIsExist = await userRepository.NameIsExist(request.FullName, cancellationToken);
        if (nameIsExist)
        {
            throw new ArgumentException("Bu ad daha önce kaydedilmiş");
        }
    }

    private static void CheckValidation(CreateUserDto request)
    {
        CreateUserDtoValidator validationRules = new();
        var validationResult = validationRules.Validate(request);
        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors[0].ErrorMessage);
        }
    }

    public User CreateUserDtoToUserObject(CreateUserDto request)
    {
        User user = new()
        {
            Id = Guid.NewGuid(),
            FullName = request.FullName,
        };

        return user;
    }

    public async Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var users = await userRepository.GetAllAsync(cancellationToken);
        return users;
    }
}
