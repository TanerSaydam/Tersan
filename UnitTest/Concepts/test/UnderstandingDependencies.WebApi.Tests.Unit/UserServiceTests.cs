using FluentAssertions;
using Moq;
using NSubstitute;
using UnderstandingDependecies.WebApi.Context;
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
}
