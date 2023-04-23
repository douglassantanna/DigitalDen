using DigitalDen.Api.Enums;
using Postgrest.Models;
using Postgrest.Attributes;

namespace DigitalDen.Api.Users.Entities;
[Table("Users")]
public class User : BaseModel
{
    public User()
    {

    }
    [PrimaryKey("id", false)]
    public Guid Id { get; set; }
    [Column("name")]
    public string Name { get; set; } = string.Empty;
    [Column("email")]
    public string Email { get; set; } = string.Empty;
    [Column("password")]
    public string Password { get; set; } = string.Empty;
    [Column("role")]
    public ERole Role { get; set; } = ERole.User;
    [Column("created_date")]
    public DateTime CreatedDate { get; private set; } = DateTime.UtcNow;
    // public ICollection<Wallet> Wallets { get; private set; } = new List<Wallet>();
    // public ICollection<Notification> Notifications { get; private set; } = new List<Notification>();
}