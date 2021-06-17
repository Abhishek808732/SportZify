using System;
using System.Diagnostics;
using System.IO;
using SportZify;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SportZify.iOS.SQLite_iOS))]
namespace SportZify.iOS
{
    public class SQLite_iOS : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var dbFile = "RegDB.db3";
            var appPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libPath = Path.Combine(appPath, "..", "Library");
            var dbPath = Path.Combine(libPath, dbFile);
            Debug.WriteLine($"DB File Path : {dbPath}");
            var cn = new SQLiteConnection(dbPath);
            return cn;
        }
    }
}
