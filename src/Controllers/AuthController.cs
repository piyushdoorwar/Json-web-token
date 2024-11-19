using API.Application.Services;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController(JwtTokenService jwtTokenService) : ControllerBase
{
    private readonly JwtTokenService _jwtTokenService = jwtTokenService;

    [HttpPost("login")]
    public string Login()
    {
        var token = _jwtTokenService.GenerateToken();
        return token;
    }
}
