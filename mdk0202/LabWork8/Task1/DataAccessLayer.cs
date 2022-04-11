using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class DataAccessLayer
    {
        public static string server = "prserver\\SQLEXPRESS";
        public static string database = "pcs9114";
        public static string login ="pcs9114";
        public static string password="9114";

        public static string ConnectionString
        {
            get
            {
                SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder();
                sqlConnection.DataSource = server;
                sqlConnection.UserID = login;
                sqlConnection.Password = password;
                sqlConnection.InitialCatalog = database;
                return sqlConnection.ConnectionString;
            }
        }

        public static int ExecuteCommand(string query)
        {
            using (SqlConnection connection = new(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                return command.ExecuteNonQuery();
            }
        }
        public static object ExecuteScalarCommand(string query)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                return command.ExecuteScalar();
            }
        }
        public static DataTable ExecuteReaderCommand(string query)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                var table = new DataTable();
                table.Load(command.ExecuteReader());
                return table;
            }
        }

        public static DataTable GetTableSchema(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT TOP(1) * FROM {tableName}", connection);
                SqlDataReader dataReader = command.ExecuteReader();
                return dataReader.GetSchemaTable();
            }
        }

        public static List<string> GetTables()
        {
            List<string> tables = new List<string>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT table_name FROM INFORMATION_SCHEMA.TABLES", connection);
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        tables.Add(dataReader[0].ToString());
                    }
                }
            }
            return tables;
        }
        public static List<string> GetTableColumns(string tableName)
        {
            List<string> columns = new List<string>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE table_name = '{tableName}'", connection);
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        columns.Add(dataReader[0].ToString());
                    }
                }
            }
            return columns;
        }
    }
}
