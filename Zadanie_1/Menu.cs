﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
