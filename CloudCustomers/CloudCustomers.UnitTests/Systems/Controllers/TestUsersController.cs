using CloudCustomers.API.Controllers;
using CloudCustomers.API.Models;
using CloudCustomers.API.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace CloudCustomers.UnitTests.Systems.Controllers;

public class TestUsersController
{
    [Fact]
    public async Task Get_OnSuccess_ReturnsStatusCode200()
    {
        var mockUserService = new Mock<IUsersService>();
        // Arrange
        var sut = new UsersController(mockUserService.Object);
        // Act
        var result = (OkObjectResult)await sut.Get();
        // Assert
        result.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task Get_OnSuccess_InvokesUsersServiceExactlyOnce()
    {
        // Arrange
        var mockUserService = new Mock<IUsersService>();
        mockUserService
            .Setup(service => service.GetAllUsers())
            .ReturnsAsync(new List<User>());

        var sut = new UsersController(mockUserService.Object);

        // Act
        var result = await sut.Get();
        // Assert
        mockUserService.Verify(
            service => service.GetAllUsers(),
            Times.Once());
    }

    [Theory] // to run the test multiple times with different params
    [InlineData("foo")]
    [InlineData("bar")]
    public void Test2(string input)
    {
    }
}