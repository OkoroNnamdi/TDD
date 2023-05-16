using CloudCustomer.Api.Controllers;
using CloudCustomer.Api.UserService;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace cloudcustomer.UnitTests.Systems.Controller;

public class TestUsersController
{
    [Fact]
    public async Task  Get_Onsucess_ReturnStatusCode200()
    {
        //Arrange
       var sut = new UserController();
        //Act

        var result =(OkObjectResult)await  sut.Get();

        //Assert
        result.StatusCode.Should().Be(200);


    }
    [Fact]
    public async Task Get_OnSucess_InvokeUserService()
    {
        //Arrange
        var MockService = new Mock<IUserService>();
        var sut = new UserController(MockService.Object);
        //Act

        var result = (OkObjectResult)await sut.Get();

        //Assert
        result.StatusCode.Should().Be(200);
    }
}