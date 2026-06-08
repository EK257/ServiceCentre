using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Windows.Forms;

namespace ServiceCenter.Data
{
    public class DatabaseHelper
    {
        private static string dbName = "service_center.db";
        private string connectionString = $"Data Source={dbName};";

        public DatabaseHelper()
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                string sql = @"
                CREATE TABLE IF NOT EXISTS Orders (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ClientName TEXT,
                    ClientPhone TEXT,
                    DeviceType TEXT,
                    DeviceModel TEXT,
                    DeviceSerial TEXT,
                    Status TEXT,
                    Problem TEXT,
                    TotalPrice DECIMAL,
                    CreatedDate DATETIME
                );

                CREATE TABLE IF NOT EXISTS Inventory (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Articul TEXT,
                    Quantity INTEGER,
                    Price DECIMAL
                );

                CREATE TABLE IF NOT EXISTS Services (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Price DECIMAL
                );

                CREATE TABLE IF NOT EXISTS OrderDetails (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    OrderId INTEGER,
                    ItemType TEXT,
                    ItemId INTEGER,
                    Quantity INTEGER,
                    PriceAtTime DECIMAL
                );";

                using (var command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable ExecuteQuery(string sql, SqliteParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqliteCommand(sql, connection))
                    {
                        if (parameters != null) command.Parameters.AddRange(parameters);
                        using (var reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка БД: " + ex.Message);
            }
            return dt;
        }

        public int ExecuteNonQuery(string sql, SqliteParameter[] parameters = null)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqliteCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var p in parameters) command.Parameters.Add(p);
                    }
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}