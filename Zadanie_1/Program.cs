using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_1
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
    static class Program
    {
      
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
