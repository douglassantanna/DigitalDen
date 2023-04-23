using DigitalDen.Api.Users.Contracts;
using DigitalDen.Api.Users.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DigitalDen.Api.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    private readonly Supabase.Client _supabase;
    public UserController(Supabase.Client supabase)
    {
        _supabase = supabase;
    }
    [HttpPost("create")]
    public async Task<IActionResult> Create(CreateUserRequest userRequest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        else
        {
            var user = new User
            {
                Name = userRequest.Name,
                Email = userRequest.Email,
                Password = userRequest.Password
            };
            var response = await _supabase
                .From<User>()
                .Insert(user);

            var newUser = response.Models.FirstOrDefault();

            return Ok(newUser?.Id);
        }
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> Get(Guid id)
    {

        var response = await _supabase
            .From<User>()
            .Where(user => user.Id == id)
            .Get();

        var user = response.Models.FirstOrDefault();
        if (user is null)
        {
            return NotFound();
        }

        var userResponse = new UserResponse
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            Role = user.Role,
            CreatedDate = user.CreatedDate
        };
        return Ok(userResponse);
    }

    [HttpGet("get-all")]
    public async Task<IActionResult> GetAll()
    {
        var response = await _supabase
            .From<User>()
            .Get();

        var users = response.Models.Select(user => new UserResponse
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
            Role = user.Role,
            CreatedDate = user.CreatedDate
        });

        return Ok(users);
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> Update(Guid id, UpdateUserRequest userRequest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        else
        {
            var model = await _supabase
                .From<User>()
                .Where(user => user.Id == id)
                .Single();

            if (model is null)
            {
                return NotFound();
            }
            model.Name = userRequest.Name;
            model.Email = userRequest.Email;
            model.Password = userRequest.Password;

            await model.Update<User>();

            return Ok(model.Id);
        }
    }
}