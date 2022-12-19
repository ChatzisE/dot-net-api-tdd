using CloudCustomers.API.Controllers;
using CloudCustomers.API.Models;
using CloudCustomers.API.Services;
using CloudCustomers.UnitTests.Fixtures;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace CloudCustomers.UnitTests.Systems.Services;

public class TestUsersService
{
    [Fact] public async Task GetAllUsers_WhenCalled_InvokesHttpGetRequest()
    {
        // Arrange
        //var sut = new UsersService();
        // Act
        await sut.GetAllUsers();
        // Assert
        // Verify HTTP request is made!
    }
}