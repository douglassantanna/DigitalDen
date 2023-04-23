namespace DigitalDen.Api.Transactions.Entities;
public class Wallet
{
    public Wallet(Guid userId, string name, string? address)
    {
        Id = Guid.NewGuid();
        UserId = userId;
        Name = name;
        Address = address;
        CreatedDate = DateTime.UtcNow;
    }

    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string? Address { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public ICollection<Asset> Assets { get; private set; } = new List<Asset>();
}
