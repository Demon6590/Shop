namespace Shop;

public record Sale(){
    
    public int SaleId { get; init; }
    // TODO Доделать добовление даты. Происходит конфликт потомучто в бд дата хронится как TEXN
    public DateOnly SaleDate { get; init; }
    
    
    public string Buyer { get; init; }
    public string ProductName { get; init; }
}