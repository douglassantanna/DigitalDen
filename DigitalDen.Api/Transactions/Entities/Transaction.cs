using DigitalDen.Api.Enums;

namespace DigitalDen.Api.Transactions.Entities;
public class Transaction
{
    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public Guid? ExchangeId { get; private set; }
    public Guid WalletId { get; private set; }
    public Asset Asset { get; private set; }
    public ETransactionType Type { get; private set; }
    public decimal Fee { get; private set; }
    public string? Notes { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public DateTime UpdatedDate { get; private set; }

    public Transaction(Guid userId,
                       Guid? exchangeId,
                       Guid walletId,
                       Asset asset,
                       ETransactionType type,
                       decimal fee,
                       string? notes)
    {
        Id = Guid.NewGuid();
        UserId = userId;
        ExchangeId = exchangeId;
        WalletId = walletId;
        Asset = asset;
        Type = type;
        Fee = fee;
        Notes = notes;
        CreatedDate = DateTime.UtcNow;
    }
    public void UpdateTransaction(Guid userId,
                                  Guid? exchangeId,
                                  Guid walletId,
                                  Asset asset,
                                  ETransactionType type,
                                  decimal fee,
                                  string? notes)
    {
        UserId = userId;
        ExchangeId = exchangeId;
        WalletId = walletId;
        Asset = asset;
        Type = type;
        Fee = fee;
        Notes = notes;
        UpdatedDate = DateTime.UtcNow;
    }
}