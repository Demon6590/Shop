namespace Shop;

public record StockItem(){
    public int Id { get; init; }
    public string Name { get; init; }
    public int Stock { get; init; }
}