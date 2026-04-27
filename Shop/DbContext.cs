using System.Collections.Generic;
using Dapper;

namespace Shop;
using Microsoft.Data.Sqlite;
public class DbContext
{
    private string _connectionString { get; }

    public DbContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IEnumerable<StockItem> GetStock()
    {
        using var db = new SqliteConnection(_connectionString);
        db.Open();

        const string sql = "SELECT * FROM view_product_stock";

        return db.Query<StockItem>(sql);
    }

    public IEnumerable<Sale> GetSale()
    {
        using var db = new SqliteConnection(_connectionString);
        db.Open();

        const string sql = "SELECT * FROM view_product_sales";

        return db.Query<Sale>(sql);
        
    }
    
}