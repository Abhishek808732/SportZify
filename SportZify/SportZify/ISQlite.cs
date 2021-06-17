using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportZify
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
