using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectDB;
using MySql.Data.MySqlClient;


namespace Zadanie_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Connect_DB con2 = new Connect_DB();
            MySqlConnection conn = new MySqlConnection(con2.connStr);
            string sql = $"SELECT idStud,fioStud,drStud FROM t_datetime";
            try
            {
                conn.Open();
                MySqlDataAdapter IDataAdapter = new MySqlDataAdapter(sql, conn);

                DataSet ds = new DataSet();

                IDataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];   

            }
            catch
            {
                MessageBox.Show("Шляпа какая-то");
            }
            finally
            {
                conn.Close();
            }
        }
        string id_rows5 = "0";

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Left))
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                dataGridView1.CurrentRow.Selected = true;
                string index_rows5;
                index_rows5 = dataGridView1.SelectedCells[0].RowIndex.ToString();
                id_rows5 = dataGridView1.Rows[Convert.ToInt32(index_rows5)].Cells[2].Value.ToString();
                DateTime a = DateTime.Today;
                DateTime b = Convert.ToDateTime(dataGridView1.Rows[Convert.ToInt32(index_rows5)].Cells[2].Value.ToString());
                string Days =(a-b).ToString();//число дней
                MessageBox.Show("С момента рождения прошло  " + Days.Substring(0, Days.Length - 9) + "  дней");
                
            }
        }

        
    }
}
