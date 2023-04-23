using DigitalDen.Api.Enums;

namespace DigitalDen.Api.Users.Contracts;
public class UserResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public ERole Role { get; set; } = ERole.User;
    public DateTime CreatedDate { get; set; }
}