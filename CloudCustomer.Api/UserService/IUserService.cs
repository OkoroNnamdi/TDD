using CloudCustomer.Api.Model;

namespace CloudCustomer.Api.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
    }
}
