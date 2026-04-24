namespace Shop;

public record Product
{
    public int ProductId { get; init; }
    public string ProductName { get; init; } = string.Empty;
    public int CurrentStock { get; init; }
    public int CurrentPrice { get; init; }
    public DateOnly PriceIssueDate { get; init; }
}