using System;

namespace Shop;

public record Sale()
{
    public int SaleId { get; init; }
    public DateOnly SaleDate {get; init; }
    public string Buyer { get; init; }
    public string ProductName { get; init; }
    public decimal SalePrice { get; init; }
}