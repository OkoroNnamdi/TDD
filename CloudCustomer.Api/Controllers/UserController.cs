using Microsoft.AspNetCore.Mvc;

namespace CloudCustomer.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    public UserController()
    {
        
    }
    [HttpGet(Name ="GetUsers")]
    public async Task<IActionResult > Get()
    {
        return Ok("All is Good");
    }
}
