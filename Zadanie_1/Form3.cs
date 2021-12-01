using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataTable table = new DataTable();

        string id_selected_rows = "0";
        public void GetSelectedIDString()
        {
            //Переменная для индекс выбранной строки в гриде
            string index_selected_rows;
            //Индекс выбранной строки
            index_selected_rows = dataGridView1.SelectedCells[0].RowIndex.ToString();
            //ID конкретной записи в Базе данных, на основании индекса строки
            id_selected_rows = dataGridView1.Rows[Convert.ToInt32(index_selected_rows)].Cells[1].Value.ToString();
            //Указываем ID выделенной строки в метке
            MessageBox.Show(id_selected_rows);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Connect con1 = new Connect();
            con1.conn = new MySqlConnection(con1.connStr);
            {
                try
                {
                   con1.conn.Open();
                    string sql = $"SELECT id, fio, theme_kurs FROM t_stud";
                 
                    MyDA.SelectCommand = new MySqlCommand(sql,con1.conn);
                    
                    MyDA.Fill(table);
                    
                    bSource.DataSource = table;
                    
                    dataGridView1.DataSource = bSource;
                   
                   con1.conn.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка подключения");
                }
            }
        }

       
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Магические строки
            dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
            dataGridView1.CurrentRow.Selected = true;
            //Метод получения ID выделенной строки в глобальную переменную
            GetSelectedIDString();
        }
    }
}
