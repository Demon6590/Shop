using System;
using System.Data;
using Dapper;

namespace Shop;

public class DateOnlyHandler: SqlMapper.TypeHandler<DateOnly>
{
    public override void SetValue(IDbDataParameter parameter, DateOnly value)
    {
        
        parameter.DbType = DbType.String;
        parameter.Value = value.ToString("yyyy.mm.dd");
        
    }
    public override DateOnly Parse(object value)
    {
        if (value is string stringValue)
        {
            return DateOnly.Parse(stringValue);
        }
        return DateOnly.FromDateTime((DateTime)value);
    }
}