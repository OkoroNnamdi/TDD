using CloudCustomer.Api.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

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
}