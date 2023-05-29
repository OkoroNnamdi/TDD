using cloudcustomer.UnitTests.Fixtures;
using CloudCustomer.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cloudcustomer.UnitTests.Systems.Service
{
    public  class TestUserService
    {
        [Fact ]
        public async Task GetAllUsers_WhenCalled_InvokesHttpGetResponse()
        {
            //Arrange 
            var expectedResponse = UsersFixture.GetTestUsers();
            var handlerMock =MockHttpMessageHandler<User>
        }
    }
}
