using Shop;
Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
var dbContext = new DbContext(@"Data Source=C:\Users\Demon659\RiderProjects\Shop\Shop.db;");


var sales = dbContext.GetSale();
var stocks = dbContext.GetStock();

foreach (var sale in sales)
{
    Console.WriteLine(sale);
}


foreach (var stock in stocks)
{
    Console.WriteLine(stock);
}