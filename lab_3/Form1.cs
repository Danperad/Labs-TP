using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rec_ToolStripMenuItem.Enabled = true;
            cycle_ToolStripMenuItem.Enabled = false;
            chart1.Series[0].BorderWidth = 3;
            chart1.Series[0].Color = Color.Red;
            chart1.Series[1].BorderWidth = 3;
            chart1.Series[1].Color = Color.Blue;
            chart1.Series[0].LegendText = "Сравнения";
            chart1.Series[1].LegendText = "Обмены";
            chart2.Series[0].BorderWidth = 3;
            chart2.Series[0].Color = Color.Red;
            chart2.Series[1].BorderWidth = 3;
            chart2.Series[1].Color = Color.Blue;
            chart2.Series[0].LegendText = "Сравнения";
            chart2.Series[1].LegendText = "Обмены";
            chart3.Series[0].BorderWidth = 3;
            chart3.Series[0].Color = Color.Red;
            chart3.Series[1].BorderWidth = 3;
            chart3.Series[1].Color = Color.Blue;
            chart3.Series[0].LegendText = "Сравнения";
            chart3.Series[1].LegendText = "Обмены";
            chart4.Series[0].BorderWidth = 3;
            chart4.Series[0].Color = Color.Red;
            chart4.Series[1].BorderWidth = 3;
            chart4.Series[1].Color = Color.Blue;
            chart4.Series[0].LegendText = "Сравнения";
            chart4.Series[1].LegendText = "Обмены";
            chart5.Series[0].BorderWidth = 3;
            chart5.Series[0].Color = Color.Red;
            chart5.Series[1].BorderWidth = 3;
            chart5.Series[1].Color = Color.Blue;
            chart5.Series[0].LegendText = "Сравнения ПузЦ";
            chart5.Series[1].LegendText = "Обмены ПузЦ";
            chart5.Series[2].BorderWidth = 3;
            chart5.Series[2].Color = Color.Crimson;
            chart5.Series[3].BorderWidth = 3;
            chart5.Series[3].Color = Color.Indigo;
            chart5.Series[2].LegendText = "Сравнения ВыбР";
            chart5.Series[3].LegendText = "Обмены ВыбР";
            chart6.Series[0].BorderWidth = 3;
            chart6.Series[0].Color = Color.Red;
            chart6.Series[1].BorderWidth = 3;
            chart6.Series[1].Color = Color.Blue;
            chart6.Series[0].LegendText = "Сравнения Шелла";
            chart6.Series[1].LegendText = "Обмены Шелла";
            chart6.Series[2].BorderWidth = 3;
            chart6.Series[2].Color = Color.Crimson;
            chart6.Series[3].BorderWidth = 3;
            chart6.Series[3].Color = Color.Indigo;
            chart6.Series[2].LegendText = "Сравнения Вставки";
            chart6.Series[3].LegendText = "Обмены Вставки";
        }

        public void output_textBox(int[] out_a, int n) //вывод массива в textBox
        {
            for (int i = 0; i < n; i++)
            {
                logBox.Text += out_a[i] + " ";
            }

            logBox.Text += Environment.NewLine;
        }

        public void output_dataGridView(int count, int sr, int obm, int vid_sort)
        {
            dataGridView1.Rows[count].Cells[vid_sort].Value = sr;
            dataGridView2.Rows[count].Cells[vid_sort].Value = obm;
        }
        public void recOutput_dataGridView(int count, int sr, int obm, int vid_sort)
        {
            dataGridView3.Rows[count].Cells[vid_sort].Value = sr;
            dataGridView4.Rows[count].Cells[vid_sort].Value = obm;
        }

        private bool isRevers = false;

        private void start_button_Click(object sender, EventArgs e)
        {
            start_button.Enabled = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderText = "Сравнения/ Размер";
            dataGridView1.Columns[1].HeaderText = "Выбор";
            dataGridView1.Columns[2].HeaderText = "Вставки";
            dataGridView1.Columns[3].HeaderText = "Пузырек";
            dataGridView1.Columns[4].HeaderText = "Шелла";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnCount = 5;
            dataGridView2.Columns[0].HeaderText = "Обмены/ Размер";
            dataGridView2.Columns[1].HeaderText = "Выбор";
            dataGridView2.Columns[2].HeaderText = "Вставки";
            dataGridView2.Columns[3].HeaderText = "Пузырек";
            dataGridView2.Columns[4].HeaderText = "Шелла";
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.ColumnCount = 5;
            dataGridView3.Columns[0].HeaderText = "Сравнения/ Размер";
            dataGridView3.Columns[1].HeaderText = "ПузЦ";
            dataGridView3.Columns[2].HeaderText = "ВыбР";
            dataGridView3.Columns[3].HeaderText = "Шелла";
            dataGridView3.Columns[4].HeaderText = "Вставки";
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.ColumnCount = 5;
            dataGridView4.Columns[0].HeaderText = "Обмены/ Размер";
            dataGridView4.Columns[1].HeaderText = "ПузЦ";
            dataGridView4.Columns[2].HeaderText = "ВыбР";
            dataGridView4.Columns[3].HeaderText = "Шелла";
            dataGridView4.Columns[4].HeaderText = "Вставки";
            if (numericUpDown4.Value < numericUpDown5.Value)
            {
                label8.Text = "Макс значение не м.б. меньше мин значения!";
                clear_button_Click(sender, e);
                return;
            }

            int count = 0, n, sr = 0, obm = 0;
            ArraySort sort_select = new ArraySort();
            ArraySort sort_insert = new ArraySort();
            ArraySort sort_bubble = new ArraySort();
            ArraySort sort_shell = new ArraySort();
            ArraySort sort_selectRec = new ArraySort();
            ArraySort sort_bubbleCycle = new ArraySort();
            
            for (n = Convert.ToInt32(numericUpDown1.Value);
                n <=
                Convert.ToInt32(numericUpDown2.Value);
                n += Convert.ToInt32(numericUpDown3.Value))
            {
                int[] base_a = new int[n];
                Random rand = new Random();
                for (int j = 0; j < n; j++)
                {
                    base_a[j] = rand.Next(Convert.ToInt32(numericUpDown5.Value),
                        Convert.ToInt32(numericUpDown4.Value));
                }

                logBox.Text += "Исходный массив " + Environment.NewLine;
                output_textBox(base_a, n);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[count].Cells[0].Value = n;
                dataGridView2.Rows.Add();
                dataGridView2.Rows[count].Cells[0].Value = n;
                dataGridView3.Rows.Add();
                dataGridView3.Rows[count].Cells[0].Value = n;
                dataGridView4.Rows.Add();
                dataGridView4.Rows[count].Cells[0].Value = n;


                sort_select.a = (int[]) base_a.Clone();
                sr = 0;
                obm = 0;
                if (isRevers) sort_select.SelectRecSort(sort_select.a,ref n,ref sr, ref obm);
                else sort_select.SelectSort(sort_select.a, ref sr, ref obm);
                logBox.Text += "Сортировка выбором " + Environment.NewLine;
                output_textBox(sort_select.a, n);
                output_dataGridView(count, sr, obm, 1);
                chart1.Series[0].Points.AddXY(n, sr);
                chart1.Series[1].Points.AddXY(n, obm);


                sort_insert.a = (int[]) base_a.Clone();
                sr = 0;
                obm = 0;
                sort_insert.InsertSort(sort_insert.a, ref sr, ref obm);
                logBox.Text += "Сортировка вставками " + Environment.NewLine;
                output_textBox(sort_insert.a, n);
                output_dataGridView(count, sr, obm, 2);
                recOutput_dataGridView(count, sr, obm, 4);
                chart2.Series[0].Points.AddXY(n, sr);
                chart2.Series[1].Points.AddXY(n, obm);
                chart6.Series[2].Points.AddXY(n, sr);
                chart6.Series[3].Points.AddXY(n, obm);

                sort_bubble.a = (int[]) base_a.Clone();
                sr = 0;
                obm = 0;
                if (isRevers) sort_bubble.BubbleRecSort(sort_bubble.a, ref sr, ref obm);
                else sort_bubble.BubbleSort(sort_bubble.a, ref sr, ref obm);
                logBox.Text += "Сортировка пузырьком " + Environment.NewLine;
                output_textBox(sort_bubble.a, n);
                output_dataGridView(count, sr, obm, 3);
                chart3.Series[0].Points.AddXY(n, sr);
                chart3.Series[1].Points.AddXY(n, obm);

                sort_shell.a = (int[]) base_a.Clone();
                sr = 0;
                obm = 0;
                sort_shell.ShellSort(sort_shell.a, ref sr, ref obm);
                logBox.Text += "Сортировка Шеллом " + Environment.NewLine;
                output_textBox(sort_shell.a, n);
                output_dataGridView(count, sr, obm, 4);
                recOutput_dataGridView(count, sr, obm, 3);
                chart4.Series[0].Points.AddXY(n, sr);
                chart4.Series[1].Points.AddXY(n, obm);
                chart6.Series[0].Points.AddXY(n, sr);
                chart6.Series[1].Points.AddXY(n, obm);

                sort_bubbleCycle.a = (int[]) base_a.Clone();
                sr = 0;
                obm = 0;
                sort_bubbleCycle.BubbleSort(sort_bubbleCycle.a, ref sr, ref obm);
                logBox.Text += "Сортировка Пузырьком цилами " + Environment.NewLine;
                output_textBox(sort_bubbleCycle.a, n);
                recOutput_dataGridView(count, sr, obm, 1);
                chart5.Series[0].Points.AddXY(n, sr);
                chart5.Series[1].Points.AddXY(n, obm);
                
                sort_selectRec.a = (int[]) base_a.Clone();
                sr = 0;
                obm = 0;
                sort_selectRec.SelectRecSort(sort_selectRec.a, ref n,ref sr, ref obm);
                logBox.Text += "Сортировка Выбором рекурсией " + Environment.NewLine;
                output_textBox(sort_selectRec.a, n);
                recOutput_dataGridView(count, sr, obm, 2);
                chart5.Series[2].Points.AddXY(n, sr);
                chart5.Series[3].Points.AddXY(n, obm);
                
                count++;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            dataGridView4.Rows.Clear();
            dataGridView4.Columns.Clear();
            logBox.Text = "";
            start_button.Enabled = true;
            cycle_ToolStripMenuItem.Enabled = true;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            chart3.Series[0].Points.Clear();
            chart3.Series[1].Points.Clear();
            chart4.Series[0].Points.Clear();
            chart4.Series[1].Points.Clear();
            chart5.Series[0].Points.Clear();
            chart5.Series[1].Points.Clear();
            chart5.Series[2].Points.Clear();
            chart5.Series[3].Points.Clear();
            chart6.Series[0].Points.Clear();
            chart6.Series[1].Points.Clear();
            chart6.Series[2].Points.Clear();
            chart6.Series[3].Points.Clear();
        }

        private void saveAll_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveСhartInsert_ToolStripMenuItem_Click(sender, e);
            saveChartChoise_ToolStripMenuItem_Click(sender, e);
            saveChartBubble_ToolStripMenuItem_Click(sender, e);
            saveChartShell_ToolStripMenuItem_Click(sender, e);
            saveChartBubbleAndSelect_ToolStripMenuItem_Click(sender, e);
            saveChartBubbleAndSelect_ToolStripMenuItem_Click(sender, e);
        }

        private void saveСhartInsert_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr1 = new SaveFileDialog())
            {
                saveGr1.Title = "Сохранить график как ...";
                saveGr1.Filter = "*.jpg|*.jpg";
                saveGr1.AddExtension = true;
                saveGr1.FileName = "Insert";
                if (saveGr1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    chart2.SaveImage(saveGr1.FileName,
                        System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }

        private void saveChartChoise_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr = new SaveFileDialog())
            {
                saveGr.Title = "Сохранить график как ...";
                saveGr.Filter = "*.jpg|*.jpg";
                saveGr.AddExtension = true;
                saveGr.FileName = "Select";
                if (saveGr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    chart1.SaveImage(saveGr.FileName,
                        System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }

        private void saveChartBubble_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr2 = new SaveFileDialog())
            {
                saveGr2.Title = "Сохранить график как ...";
                saveGr2.Filter = "*.jpg|*.jpg";
                saveGr2.AddExtension = true;
                saveGr2.FileName = "Bubble";
                if (saveGr2.ShowDialog() ==
                    System.Windows.Forms.DialogResult.OK)
                {
                    chart3.SaveImage(saveGr2.FileName,
                        System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }

        private void saveChartShell_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr3 = new SaveFileDialog())
            {
                saveGr3.Title = "Сохранить график как ...";
                saveGr3.Filter = "*.jpg|*.jpg";
                saveGr3.AddExtension = true;
                saveGr3.FileName = "Shell";
                if (saveGr3.ShowDialog() ==
                    System.Windows.Forms.DialogResult.OK)
                {
                    chart4.SaveImage(saveGr3.FileName,
                        System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }
        private void saveChartBubbleAndSelect_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr4 = new SaveFileDialog())
            {
                saveGr4.Title = "Сохранить график как ...";
                saveGr4.Filter = "*.jpg|*.jpg";
                saveGr4.AddExtension = true;
                saveGr4.FileName = "Bubble_and_Select";
                if (saveGr4.ShowDialog() ==
                    System.Windows.Forms.DialogResult.OK)
                {
                    chart5.SaveImage(saveGr4.FileName,
                        System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }

        private void saveChartShellAndInsert_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveGr5 = new SaveFileDialog())
            {
                saveGr5.Title = "Сохранить график как ...";
                saveGr5.Filter = "*.jpg|*.jpg";
                saveGr5.AddExtension = true;
                saveGr5.FileName = "Shell_and_Insert";
                if (saveGr5.ShowDialog() ==
                    System.Windows.Forms.DialogResult.OK)
                {
                    chart6.SaveImage(saveGr5.FileName,
                        System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                }
            }
        }

        private void cycle_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear_button_Click(sender, e);
            isRevers = false;
            start_button_Click(sender, e);
            cycle_ToolStripMenuItem.Enabled = false;
            rec_ToolStripMenuItem.Enabled = true;
        }

        private void рекурсивнымиФункциямиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            isRevers = true;
            clear_button_Click(sender, e);
            start_button_Click(sender, e);
            cycle_ToolStripMenuItem.Enabled = true;
            rec_ToolStripMenuItem.Enabled = false;
        }

        private void aboutMenu(object sender, EventArgs e)
        {
            Form2 help = new Form2();
            help.ShowDialog();
        }

        private void closeFormMenu(object sender, EventArgs e)
        {
            Close();
        }
    }
}