using FluentAssertions;
using FluentValidation;
using NSubstitute;
using UnderstandingDependecies.WebApi.DTOs;
using UnderstandingDependecies.WebApi.Models;
using UnderstandingDependecies.WebApi.Repositories;
using UnderstandingDependecies.WebApi.Services;
using Xunit;

namespace UnderstandingDependencies.WebApi.Tests.Unit;
public class UserServiceTests
{
    private readonly IUserService _sut;
    private readonly IUserRepository _userRepository = Substitute.For<IUserRepository>();
    //private readonly Mock<IUserRepository> _userRepository = new();
    public UserServiceTests()
    {
        _sut = new UserService(_userRepository);
    }

    [Fact]
    public async Task GetAllAsync_ShouldReturnEmptyList_WhenNoUsersExist()
    {
        // Arrange
        _userRepository.GetAllAsync().Returns(Array.Empty<User>().ToList()); //NSubstitute Kütüphanesi ile Kullanımı
        //_userRepository.Setup(s=> s.GetAllAsync(default)).ReturnsAsync(Array.Empty<User>().ToList()); //Moq Kütüphanesi

        // Act
        var users = await _sut.GetAllAsync();

        // Assert
        users.Should().BeEmpty();
    }

    [Fact]
    public async Task CreateAsync_ShouldThrownAnError_WhenUserCreateDtoAreNotValid()
    {
        // Arrange
        CreateUserDto request = new("");

        // Act
        var action = async () =>  await _sut.CreateAsync(request);

        // Assert
        await action.Should().ThrowAsync<ValidationException>();
    }

    [Fact]
    public async Task CreateAsync_ShouldThrownAnError_WhenFullNameIsNotUnique()
    {
        // Arrange
        _userRepository.NameIsExist(Arg.Any<string>()).Returns(true);

        // Act
        var action = async () => await _sut.CreateAsync(new("Taner Saydam"));

        // Assert
        await action.Should().ThrowAsync<ArgumentException>();
    }

    [Fact]
    public void CreateAsync_ShouldCreateUserDtoToUserObject()
    {
        // Arrange
        CreateUserDto request = new("Taner Saydam");

        // Act
        var user = _sut.CreateUserDtoToUserObject(request);

        // Assert
        user.FullName.Should().Be(new(request.FullName));
    }

    [Fact]
    public async void CreateAsync_ShouldCreateUser_WhenCreateUserDtoIsValidAndUnique()
    {
        // Arrange
        _userRepository.NameIsExist(Arg.Any<string>()).Returns(false);
        _userRepository.CreateAsync(Arg.Any<User>()).Returns(true);

        // Act
        var result = await _sut.CreateAsync(new CreateUserDto("Taner Saydam"));

        // Assert
        result.Should().BeTrue();
    }
}
