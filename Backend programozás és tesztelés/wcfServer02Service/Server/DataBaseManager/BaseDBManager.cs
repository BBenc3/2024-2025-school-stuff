using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.DataBaseManager
{
    public class BaseDBManager
    {
        public static MySqlConnection Connection
        {
            get
            {
                MySqlConnection connection = new MySqlConnection();
                string constring = "SERVER=localhost;DATABASE=wcfserver02;uid=root;password=;SSLMODE=none;";
                connection.ConnectionString = constring;

                return connection;
            }
        }

        protected BaseDBManager() { }
    }
}