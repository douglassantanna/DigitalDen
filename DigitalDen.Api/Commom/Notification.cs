namespace DigitalDen.Api.Commom;
public class Notification
{
    public Notification(Guid userId, string message)
    {
        Id = Guid.NewGuid();
        UserId = userId;
        Message = message;
        IsRead = false;
        CreatedDate = DateTime.UtcNow;
    }

    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Message { get; set; } = string.Empty;
    public bool IsRead { get; set; }
    public DateTime CreatedDate { get; private set; }

}
