namespace Shop;

public record StockItem(){
    public int Id { get; init; }
    public string PductName { get; init; }
    public int RemainingStock { get; init; }
}