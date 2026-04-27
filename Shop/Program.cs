using System;
using System.Reflection;
using Dapper;
using Shop;
Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
SqlMapper.AddTypeHandler(new DateOnlyHandler());
var dbContext = new DbContext(@"Data Source=C:\Users\college\RiderProjects\Shop\Shop.db;");


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