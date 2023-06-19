using System;
using System.Data;
using System.Data.SQLite;

namespace OutliveUrCode
{
    public static class SQLHelper
    {
        public const string connectionString = "Data Source=OutliveUrCode.db;Version=3;";
        public static void initSQL()
        {
            SQLiteConnection.CreateFile("OutliveUrCode.db");
            // 新建SQLite数据库
            using (var db = new SQLiteConnection(connectionString))
            {
                db.Open();
                var table = db.CreateCommand();
                table.CommandText = "CREATE TABLE IF NOT EXISTS data (id INTEGER PRIMARY KEY AUTOINCREMENT, date TEXT, drinking INTEGER, sedentary INTEGER)";
                table.ExecuteNonQuery();
            }
        }

        public static void saveSQL(DateTime date, int drinking, int sedentary)
        {
            initSQL();
            using (var db = new SQLiteConnection(connectionString))
            {
                db.Open();
                var table = db.CreateCommand();
                //存入上一天的日期,喝水与久坐数据
                table.CommandText = $"INSERT INTO data (date, drinking, sedentary) VALUES (\"{date.ToString("MMM.dd")}\", \"{drinking}\", \"{sedentary}\")";
                table.ExecuteNonQuery();
            }
        }

        public static DataTable readSQL()
        {
            DataTable dt = new DataTable();
            using (var db = new SQLiteConnection(connectionString))
            {
                db.Open();
                var table = db.CreateCommand();
                table.CommandText = "SELECT * FROM data";
                var reader = table.ExecuteReader();
                dt.Load(reader);
            }
            return dt;
        }
    }
}