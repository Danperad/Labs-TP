using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7_dop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            double x1, y1, x2, y2, r2;
            x1 = Convert.ToDouble(textBox2.Text);
            y1 = Convert.ToDouble(textBox3.Text);
            x2 = Convert.ToDouble(textBox4.Text);
            y2 = Convert.ToDouble(textBox5.Text);
            r2 = Convert.ToDouble(textBox6.Text);
            Point tochka = new Point();
            tochka.pointX = x1;
            tochka.pointY = y1;
            textBox1.Text += "Точка" + Environment.NewLine;
            textBox1.Text += "x= " + tochka.pointX + "\t";
            textBox1.Text += "y= " + tochka.pointY + Environment.NewLine;
            textBox1.Text += Environment.NewLine + Environment.NewLine;
            textBox1.Text += "Круг" + Environment.NewLine;
            textBox1.Text += "Невозможно создать экземпляр абстрактного класса Circle "
                             + Environment.NewLine;
            textBox1.Text += Environment.NewLine + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}