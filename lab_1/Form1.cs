using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_lub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label8.Text = "";
            if (numericUpDown4.Value < numericUpDown5.Value)
            {
                label8.Text = "Макс значение не м.б. меньше мин значения!";
                return;
            }

            int count, current = 0;
            count = (Convert.ToInt32(numericUpDown2.Value) -
                     Convert.ToInt32(numericUpDown1.Value)) /
                Convert.ToInt32(numericUpDown3.Value) + 1;
            for (int n = Convert.ToInt32(numericUpDown1.Value);
                n <=
                Convert.ToInt32(numericUpDown2.Value);
                n +=
                    Convert.ToInt32(numericUpDown3.Value))
            {
                int[] vptr = new int[n];
                Random rand = new Random();
                for (int j = 0; j < n; j++)
                {
                    vptr[j] = rand.Next(Convert.ToInt32(numericUpDown5.Value), Convert.ToInt32(numericUpDown4.Value));
                }

                if (checkBox1.Checked)
                {
                    dataGridView1.ColumnCount = n + 1;
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = "Исходный массив";
                    for (int j = 0; j < n; j++)
                    {
                        dataGridView1.Rows[i].Cells[j + 1].Value =
                            vptr[j];
                    }

                    i++;
                }

                sort(vptr, n);
                current += 1;
                progressBar1.Value = 100 * current / count;
            }
        }

        private void sort(int[] massiv, int n)
        {
            int k = 0, kolSrav = 0, kolObm = 0, y = 0;
            for (int j = 0; j < n; j++)
            {
                if (massiv[j] == 0) k++;
                else massiv[j - k] = massiv[j];
            }

            n -= k;
            kolSrav += n;
            if (n == 0)
            {
                label8.Text = "В массиве одни нули";
                return;
            }

            for (y = 0; y < n - 1; y++)
            for (int j = y + 1; j < n; j++)
            {
                if (massiv[y] > 0 && massiv[j] > 0 && massiv[y] < massiv[j])
                {
                    swap(ref massiv[y], ref massiv[j]);
                    kolObm++;
                }

                if (massiv[y] < 0 && massiv[j] < 0 && massiv[y] > massiv[j])
                {
                    swap(ref massiv[y], ref massiv[j]);
                    kolObm++;
                }

                kolSrav += 6;
            }

            if (checkBox1.Checked)
            {
                dataGridView1.AutoResizeColumns();
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = "Получен массив";
                for (int j = 0; j < n; j++)
                {
                    dataGridView1.Rows[i].Cells[j + 1].Value = massiv[j];
                }

                i++;
            }

            if (Convert.ToInt32(numericUpDown1.Value) ==
                Convert.ToInt32(numericUpDown2.Value))
            {
                label8.Text = "Количество сравнений=" +
                              Convert.ToString(kolSrav) + " Количество обменов=" + Convert.ToString(kolObm);
            }

            if (checkBox2.Checked)
            {
                chart1.Series[0].Points.AddXY(n, kolSrav);
                chart2.Series[0].Points.AddXY(n, kolObm);
            }
        }


        void swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            i = 0;
            button1.Enabled = true;
        }

        int axis_x, axis_y;

        private void button3_Click(object sender, EventArgs e)
        {
            int i, j, kolvoDel;
            button3.Enabled = false;
            if (numericUpDown7.Value < numericUpDown8.Value)
            {
                label9.Text = "Макс значение не м.б. меньше мин значения!";
                return;
            }

            axis_x = Convert.ToInt32(numericUpDown6.Value);
            axis_y = axis_x;
            int[,] matrix;
            matrix = new int[axis_y, axis_x];
            Random rand = new Random();
            dataGridView2.AutoResizeColumns();
            dataGridView2.ColumnCount = axis_x;
            for (i = 0; i < axis_x; i++)
            {
                dataGridView2.Rows.Add();
                for (j = 0; j < axis_y; j++)
                {
                    matrix[i, j] =
                        rand.Next(Convert.ToInt32(numericUpDown8.Value),
                            Convert.ToInt32(numericUpDown7.Value));

                    dataGridView2.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            //q = 0;
            kolvoDel = 0;
            dataGridView3.AutoResizeColumns();
            dataGridView3.Columns.Add("", "");
            for (int k = 0; k < axis_y-1; k++)
            {
                dataGridView3.Rows.Add();
            }
            if (axis_y > 2)
            {
                for (int k = 0; k < axis_x; k++)
                {
                    if (matrix[2, k] <= 0)
                    {
                        for (int l = 0; l < axis_y; l++)
                        {
                            dataGridView3.Rows[l].Cells[dataGridView3.Columns.Count-1].Value = matrix[l,k];
                        }
                        dataGridView3.Columns.Add("", "");
                    }
                    else
                    {
                        kolvoDel++;
                    }
                }
            }

            for (int k = 0; k < axis_y; k++)
            {
                dataGridView3.Rows[k].Cells[dataGridView3.Columns.Count-1].Value = matrix[rand.Next(0,axis_x),rand.Next(0,axis_x)];
            }
            if (kolvoDel == axis_x)
            {
                label9.Text = "В матрице удалены все столбцы";
                return;
            }
            if (kolvoDel == 0)
            {
                label9.Text = "В матрице нет удаленных столбцов";
                return;
            }
            label9.Text = "В матрице удалено " + kolvoDel + " столбца(ов)";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            button3.Enabled = true;
            label9.Text = "";
        }
    }
}