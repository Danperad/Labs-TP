using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
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
            double x1, y1, x2, y2, r2, x3, y3, r3;
            int g3;
            x1 = Convert.ToDouble(textBoxX1.Text);
            y1 = Convert.ToDouble(textBoxY1.Text);
            x2 = Convert.ToDouble(textBoxX2.Text);
            y2 = Convert.ToDouble(textBoxY2.Text);
            r2 = Convert.ToDouble(textBoxR2.Text);
            x3 = Convert.ToDouble(textBoxX3.Text);
            y3 = Convert.ToDouble(textBoxY3.Text);
            r3 = Convert.ToDouble(textBoxR3.Text);
            g3 = Convert.ToInt32(textBoxG3.Text);

            Point tochka = new Point();
            tochka.pointX = x1;
            tochka.pointY = y1;
            textBoxOutput.Text += "Точка" + Environment.NewLine;
            textBoxOutput.Text += "x= " + tochka.pointX + "\t";
            textBoxOutput.Text += "y= " + tochka.pointY + Environment.NewLine;
            textBoxOutput.Text += Environment.NewLine + Environment.NewLine;

            Circle circle = new Circle();
            circle.pointX = x2;
            circle.pointY = y2;
            circle.Rad = r2;
            textBoxOutput.Text += "Круг" + Environment.NewLine;
            textBoxOutput.Text += "x= " + circle.pointX + "\t";
            textBoxOutput.Text += "y= " + circle.pointY + "\t";
            textBoxOutput.Text += "r= " + circle.Rad + Environment.NewLine;
            textBoxOutput.Text += "Длина окружности " + string.Format("{0:F3}", circle.lenght()) + Environment.NewLine;
            textBoxOutput.Text += "Площадь круга " + string.Format("{0:F3}", circle.square()) + Environment.NewLine;
            textBoxOutput.Text += Environment.NewLine + Environment.NewLine;

            Segment segment = new Segment();
            segment.pointX = x3;
            segment.pointY = y3;
            segment.Rad = r3;
            segment.Grad = g3;
            textBoxOutput.Text += "Сегмент" + Environment.NewLine;
            textBoxOutput.Text += "x= " + segment.pointX + "\t";
            textBoxOutput.Text += "y= " + segment.pointY + "\t";
            textBoxOutput.Text += "r= " + segment.Rad + "\t";
            textBoxOutput.Text += "g= " + segment.Grad + Environment.NewLine;
            textBoxOutput.Text += "Длина дуги " + string.Format("{0:F3}", segment.lenght()) + Environment.NewLine;
            textBoxOutput.Text +=
                "Периметр сегмента " + string.Format("{0:F3}", segment.perimetr()) + Environment.NewLine;
            textBoxOutput.Text += "Площадь сегмента " + string.Format("{0:F3}", segment.square()) + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxOutput.Clear();
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}