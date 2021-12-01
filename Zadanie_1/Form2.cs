using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zadanie_1
{
  
    public partial class Form2 : Form
    {
       
        class Connect
        {

          public  string connStr = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";
          public  MySqlConnection conn;
                   
         
           
            public string Display()
            {
             return connStr;
            }
         
        }
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect con1 = new Connect();
            con1.conn = new MySqlConnection(con1.connStr);

            con1.Display();
            try
            {
                con1.conn.Open();
                MessageBox.Show($"Подключение");
               

            }
            catch
            {
                MessageBox.Show($"Не работает что-то дружочек");
               
            }
            finally
            {
                con1.conn.Close();
            }

            
            
        }
    }
}
