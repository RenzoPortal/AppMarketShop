using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMarketShop.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
