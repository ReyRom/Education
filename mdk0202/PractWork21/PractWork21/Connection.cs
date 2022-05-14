using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractWork21
{
    public static class Connection
    {
        public static event EventHandler UserChanged;

        static User currentUser;
        public static User CurrentUser 
        { 
            get => currentUser; 
            set 
            {  
                currentUser = value;
                UserChanged?.Invoke(currentUser, EventArgs.Empty);
            } 
        }

        public static string serverName = @"prserver\SQLEXPRESS";
        public static string dbName = "pcs9114";
        public static string login = "pcs9114";
        public static string password = "9114";

        public static string ConnectionString
        {
            get
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = serverName;
                builder.InitialCatalog = dbName;
                builder.UserID = login;
                builder.Password = password;
                return builder.ConnectionString;
            }
        }
    }
}
