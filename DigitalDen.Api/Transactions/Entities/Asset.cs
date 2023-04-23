using DigitalDen.Api.Transactions.ValueObjects;

namespace DigitalDen.Api.Transactions.Entities;
public class Asset
{
    public Asset(string name, Money amount)
    {
        Id = Guid.NewGuid();
        Name = name;
        Amount = amount;
        CreatedDate = DateTime.UtcNow;
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public Money Amount { get; private set; } = null!;
    public DateTime CreatedDate { get; private set; }
    public ICollection<Wallet> Wallets { get; private set; } = new List<Wallet>();
    public ICollection<Transaction> Transactions { get; private set; } = new List<Transaction>();
}