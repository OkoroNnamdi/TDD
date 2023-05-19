using CloudCustomer.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace cloudcustomer.UnitTests.Fixtures
{
   public  static  class UsersFixture
    {
        public static List<User> GetTestUsers() => new()
        {
            new User()
            {
                Id = 1,
                Name = "Test",
                 Email = "okoronnamdi4044@gmail.com",
                 Address = new Address()
                 {
                     Street ="38 first East circular",
                     City = "Benin",
                     ZipCode = "1234"
                 }
            },
            new User()
            {
                Id = 2,
                Name = "Chukwu",
                 Email = "okoronnamdi4044@gmail.com",
                 Address = new Address()
                 {
                     Street ="38 first East circular",
                     City = "Benin",
                     ZipCode = "1234"
                 }
            }
        };
       
        
    }
}
