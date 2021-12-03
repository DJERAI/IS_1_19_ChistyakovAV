using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConnectDB
{
    public class Connect_DB
    {
        public string connStr = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";
        public MySqlConnection conn;



        public string Display()
        {
            return connStr;
        }
    }
}
