namespace Shop;

public record Sale(){
    
    public int SaleId { get; init; }
    public string SaleDate { get; init; }// TODO Нужно переделать тип даных на DateOnly.
    public string Buyer { get; init; }
    public string ProductName { get; init; }
}