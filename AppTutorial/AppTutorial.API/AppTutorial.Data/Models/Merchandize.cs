namespace BasketballTeam.Data.Models;

using Enums;

public class Merchandize
{
    public Guid Id { get; set; }

    public MerchType MerchType { get; set; }

    public decimal Price { get; set; }

    public string? Size { get; set; }
}