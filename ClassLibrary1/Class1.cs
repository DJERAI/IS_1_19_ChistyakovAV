using MySql.Data.MySqlClient;

namespace ClassLibrary1
{
    internal class Connect
    {

        public string connStr = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";
        public MySqlConnection conn;



        public string Display()
        {
            return connStr;
        }

    }
    public class Class1
    {

    }
}