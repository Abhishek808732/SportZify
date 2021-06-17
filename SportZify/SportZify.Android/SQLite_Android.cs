using System;
using System.Diagnostics;
using System.IO;
using SportZify;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SportZify.Droid.SQLite_Android))]
namespace SportZify.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var dbFile = "RegDB.db3";
            string libPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var dbPath = Path.Combine(libPath, dbFile);
            var cn = new SQLiteConnection(dbPath);
            Debug.WriteLine($"DB Path: {dbPath}");
            return cn;
        }
    }
}
