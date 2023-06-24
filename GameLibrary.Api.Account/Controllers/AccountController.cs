using GameLibrary.Core.Requests;
using Microsoft.AspNetCore.Mvc;

namespace GameLibrary.Api.Account.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
    public AccountController()
    {
        
    }

    [HttpPost("register")]
    public IActionResult Register()
    {
        return Ok();
    }

    /// <summary>
    /// Endpoint for login user
    /// </summary>
    /// <param name="loginRequest">Login request's body. Contains property: username, password</param>
    /// <returns></returns>
    [HttpGet("login")]
    public IActionResult Login([FromBody] LoginRequest loginRequest)
    {
        return Ok($"{loginRequest.UserName} \n{loginRequest.Password}");
    }

    [HttpGet("logout")] 
    public IActionResult Logout()
    {
        return Ok();
    }

    [HttpGet("activate")]
    public IActionResult ActivateAccount([FromQuery] string profileObjectId)
    {
        return Ok();
    }
}
