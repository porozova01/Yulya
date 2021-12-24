using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yulya
{
    class DB
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "magazinstr";
            string username = "root";
            string password = "root";
            return DBUtils.GetDbConnection(host, port, database, username, password);
        }
    }
}
