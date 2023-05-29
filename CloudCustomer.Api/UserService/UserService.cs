using CloudCustomer.Api.Model;

namespace CloudCustomer.Api.UserService
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
