using CloudCustomer.Api.UserService;
using Microsoft.AspNetCore.Mvc;

namespace CloudCustomer.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    public UserController()
    {
        
    }

    [HttpGet(Name ="GetUsers")]
    public async Task<IActionResult > Get()
    {
        return Ok("All is Good");
    }
}
