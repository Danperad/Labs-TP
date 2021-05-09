using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    struct Product
    {
        public string Prod; //ФИО
        public string FIO; // Должность
        public string Date_Sell; // Дата рождения
        public int Num_Tov; //Ученая степеть
        public int Sell_Price; //Стажработы

        public Product(string f, string p, string d, int deg, int e) //конструктор
        {
            Prod = f;
            FIO = p;
            Date_Sell = d;
            Num_Tov = deg;
            Sell_Price = e;
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OutputFirst.RowHeadersVisible = false;
            OutputFirst.ColumnCount = 5;
            OutputFirst.Columns[0].HeaderText = "Товар";
            OutputFirst.Columns[1].HeaderText = "Покупатель";
            OutputFirst.Columns[2].HeaderText = "Дата покупки";
            OutputFirst.Columns[3].HeaderText = "Количество";
            OutputFirst.Columns[4].HeaderText = "Стоимость";

            OutputSecond.RowHeadersVisible = false;
            OutputSecond.ColumnCount = 2;
            OutputSecond.Columns[0].HeaderText = "Покупатель";
            OutputSecond.Columns[1].HeaderText = "Стоимость";
        }

        Product[] Tovar = new Product[100];
        int count = 0;


        private void Add_Click(object sender, EventArgs e)
        {
            if (count == 100)
            {
                MessageBox.Show("Потолок");
                return;
            }

            Tovar[count].Prod = Name_prod.Text;
            Tovar[count].FIO = FIO.Text;
            Tovar[count].Date_Sell = Time_Date.Value.ToString("dd.MM.yyyy");
            Tovar[count].Num_Tov = Convert.ToInt32(NumTov.Text);
            Tovar[count].Sell_Price = Convert.ToInt32(PriceTov.Text);
            OutputFirst.Rows.Add(Tovar[count].Prod, Tovar[count].FIO, Tovar[count].Date_Sell,
                Tovar[count].Num_Tov.ToString(), Tovar[count].Sell_Price.ToString());
            count++;
            OutputFirst.AutoResizeColumns();
        }

        private void Add_Dock_Click(object sender, EventArgs e)
        {
            if (count == 100)
            {
                MessageBox.Show("Потолок");
                return;
            }
            string[] asa = File.ReadAllLines(@".\Список.txt").ToArray();
            for (int i = 0; i < asa.Length; i++)
            {
                string[] tov_divide = asa[i].Split('|');
                Tovar[i].Prod = tov_divide[0];
                Tovar[i].FIO = tov_divide[1];
                Tovar[i].Date_Sell = tov_divide[2];
                Tovar[i].Num_Tov = Convert.ToInt32(tov_divide[3]);
                Tovar[i].Sell_Price = Convert.ToInt32(tov_divide[4]);
                OutputFirst.Rows.Add(Tovar[count].Prod, Tovar[count].FIO, Tovar[count].Date_Sell,
                    Tovar[count].Num_Tov.ToString(), Tovar[count].Sell_Price.ToString());
                count++;
            }
            OutputFirst.AutoResizeColumns();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            OutputSecond.Rows.Clear();
            for (int i = 0; i < count; i++)
            {
                // start
                bool isHere = false;
                for (int j = 0; j < OutputSecond.Rows.Count; j++)
                {
                    if (Tovar[i].FIO == (string) OutputSecond.Rows[j].Cells[0].Value)
                    {
                        isHere = true;
                        break;
                    }
                }

                if (isHere)
                {
                    continue;
                }

                // finish Если уже есть в выводе
                int sum = 0;

                for (int j = i; j < count; j++)
                {
                    if (Tovar[i].FIO == Tovar[j].FIO) sum += Tovar[j].Sell_Price;
                }

                OutputSecond.Rows.Add(Tovar[i].FIO, sum.ToString());
            }
            OutputSecond.AutoResizeColumns();
        }

        private void добавитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Click(sender, e);
        }

        private void выполнитьЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find_Click(sender, e);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}