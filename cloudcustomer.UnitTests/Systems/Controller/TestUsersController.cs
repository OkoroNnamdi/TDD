using cloudcustomer.UnitTests.Fixtures;
using CloudCustomer.Api.Controllers;
using CloudCustomer.Api.Model;
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
        var MockService = new Mock<IUserService>();
        MockService.Setup(service => service.GetAllUsers())
           .ReturnsAsync(UsersFixture.GetTestUsers());
        var sut = new UserController(MockService.Object);

       
        //Act

        var result =(OkObjectResult)await  sut.Get();

        //Assert
        result.Should().BeOfType<OkObjectResult>();
        var ObjectResult = (OkObjectResult)result;
        ObjectResult.StatusCode.Should().Be(200);
       

    }
    [Fact]
    public async Task Get_OnSucess_InvokeUserServiceExactlyOnce()
    {
        //Arrange
        var MockService = new Mock<IUserService>();
        MockService.Setup(service=>service.GetAllUsers())
            .ReturnsAsync(new List<User>());

        var sut = new UserController(MockService.Object);


        //Act

        var result = await sut.Get();

        //Assert
        MockService.Verify(service =>service.GetAllUsers(),Times.Once);

    }
    [Fact]
    public async Task Get_OnSucess_ReturnListOfUsers()
    {
        //Arrange
        var MockService = new Mock<IUserService>();
        MockService.Setup(service => service.GetAllUsers())
            .ReturnsAsync(UsersFixture.GetTestUsers());
        var sut = new UserController(MockService.Object);
        //act 
        var result = await sut.Get();
        //Assert
        result.Should().BeOfType <OkObjectResult >();
        var objectResult =(OkObjectResult )result;
        objectResult.Value.Should().BeOfType<List<User>>();
    }
    [Fact]
    public async Task Get_OnNotFound_Returns404()
    {
        //Arrange
        var MockService = new Mock<IUserService>();
        MockService.Setup(service => service.GetAllUsers())
            .ReturnsAsync(new List<User>());
        var sut = new UserController(MockService.Object);
        //act 
        var result = await sut.Get();
        //Assert
        result.Should().BeOfType<NotFoundResult>();
       var ObjectResult = (NotFoundResult )result;
        ObjectResult.StatusCode.Should().Be(404);
    }

}