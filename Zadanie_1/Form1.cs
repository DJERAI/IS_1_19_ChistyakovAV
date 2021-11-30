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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            CPU<string> cp1 = new CPU<string>(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            GPU<string> gp1 = new GPU<string>(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, Convert.ToInt32(textBox7.Text), textBox8.Text, Convert.ToInt32(textBox9.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    abstract class Komplect<T>
    {
        public T article;
        public double price;
        public string year;

        public Komplect(T art,double Price,string ye)
        {
            article = art;
            price = Price;
            year = ye;
        }
        public abstract void Display(ListBox lb);
    }
    class CPU<T> : Komplect<T>
    {
        private double Mhz;
        private int yadra;
        private int potoki;

     

        public double mhz
        {
            get { return Mhz; }
            set { Mhz = value; }
        }
        public int Yadra
        {
            get { return yadra; }
            set { yadra = value; }
        }
        public int Potoki
        {
            get { return potoki; }
            set { potoki = value; }
        }

       public CPU(T art,double Price,string year,double mhz,int yadr,int potok)
            :base(art,Price,year)
        {
            Mhz = mhz;
            yadra = yadr;
            potoki = potok;
            
        }
        public override void Display(ListBox lb)
        {
            lb.Items.Add($"Артикул - {article}");
            lb.Items.Add($"Цена - {price}");
            lb.Items.Add($"Год выпуска - {year}");
            lb.Items.Add($"Частота процессора - {Mhz}");
            lb.Items.Add($"Количество ядер процессора - {yadra}");
            lb.Items.Add($"Количество потоков процессора - {potoki}");

        }

    }    
    class GPU<T>: Komplect<T>
    {
        private double GPUmhz;
        private string name;
        private int RAM;
     
        public double MHZ
        {
            get { return GPUmhz; }
            set { GPUmhz = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int RAm
        {
            get { return RAM; }
            set { RAM = value; }
        }
         public GPU(T art,double price,string ye,double gpu,string n,int ram)
            :base(art,price,ye)
        {
            GPUmhz = gpu;
            name = n;
            RAM = ram;
        }
        public override void Display(ListBox lb)
        {
            lb.Items.Add($"Артикул - {article}");
            lb.Items.Add($"Цена - {price}");
            lb.Items.Add($"Год выпуска - {year}");
            lb.Items.Add($"Частота Видеокарты  - {GPUmhz}");
            lb.Items.Add($"Производитель - {name}");
            lb.Items.Add($"Объём памяти - {RAM}");
        }
    }
}
