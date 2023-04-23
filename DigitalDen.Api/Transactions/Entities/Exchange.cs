namespace DigitalDen.Api.Transactions.Entities;
public class Exchange
{
    public Exchange(string name, string? websiteUrl)
    {
        Id = Guid.NewGuid();
        Name = name;
        WebsiteUrl = websiteUrl;
        CreatedDate = DateTime.UtcNow;
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string? WebsiteUrl { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public ICollection<Transaction> Transactions { get; private set; } = new List<Transaction>();
}
