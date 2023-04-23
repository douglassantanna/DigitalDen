using DigitalDen.Api.Authentication.Contracts;
using Microsoft.AspNetCore.Mvc;
using Postgrest;

namespace DigitalDen.Api.Controllers;
[ApiController]
[Route("api/authentication")]
public class AuthenticationController : ControllerBase
{
    private readonly Supabase.Client _supabase;
    private readonly ILogger<AuthenticationController> _logger;

    public AuthenticationController(Supabase.Client supabase, ILogger<AuthenticationController> logger)
    {
        _supabase = supabase;
        _logger = logger;
    }
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest loginRequest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        else
        {
            try
            {
                var session = await _supabase
                .Auth
                .SignIn(loginRequest.Email, loginRequest.Password);

                if (session?.TokenType is null)
                {
                    return BadRequest();
                }

                return Ok(session.AccessToken);
            }
            catch (RequestException ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }

        }
    }

    [HttpPost("signin")]
    public async Task<IActionResult> SignIn(SignInRequest signInRequest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        else
        {
            var session = await _supabase
                .Auth
                .SignUp(signInRequest.Email, signInRequest.Password);

            return Ok(session);
        }
    }
}