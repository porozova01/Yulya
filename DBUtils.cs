using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yulya
{
    class DBUtils
    {
        public static MySqlConnection
            GetDbConnection(string host, int port, string database, string username, string password)
        {
            string connString = "Server =" + host + "; database = " + database + "; port = " + port + "; username = " + username + "; password = " + password + ";";
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}
