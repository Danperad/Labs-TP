using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private Tree osinka;

        public Form1()
        {
            InitializeComponent();
            textBoxTree.ScrollBars = ScrollBars.Vertical;
            textBoxSearch.ScrollBars = ScrollBars.Vertical;
        }

        private void Close_App_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Load_data_Click(object sender, EventArgs e)
        {
            textBoxBypass.Clear();
            textBoxSearch.Clear();
            textBoxTree.Clear();
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    osinka = new Tree();
                    using (var file = new System.IO.StreamReader(openFileDialog1.FileName))
                    {
                        while (file.Peek() >= 0)
                        {
                            string currentElement = file.ReadLine();
                            if (currentElement != null) osinka.Add(int.Parse(currentElement));
                            ;
                        }
                    }

                    string results = "";
                    osinka.Output(ref results);
                    textBoxTree.Text = results;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка", "Графы", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void LNR_Click(object sender, EventArgs e)
        {
            try
            {
                string bypass = "";
                osinka.Bypass(Tree.BypassOptions.LNR, ref bypass);
                textBoxBypass.Text += @"Симметричный метод LNR: " + bypass;
            }
            catch
            {
                MessageBox.Show("Ошибка", "Графы", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void NLR_Click(object sender, EventArgs e)
        {
            try
            {
                string bypass = "";
                osinka.Bypass(Tree.BypassOptions.NLR, ref bypass);
                textBoxBypass.Text += @"Прямой метод NLR: " + bypass;
            }
            catch
            {
                MessageBox.Show("Ошибка", "Графы", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void LRN_Click(object sender, EventArgs e)
        {
            try
            {
                string bypass = "";
                osinka.Bypass(Tree.BypassOptions.LRN, ref bypass);
                textBoxBypass.Text += @"Обратный метод LRN: " + bypass;
            }
            catch
            {
                MessageBox.Show("Ошибка", "Графы", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void RNL_Click(object sender, EventArgs e)
        {
            try
            {
                string bypass = "";
                osinka.Bypass(Tree.BypassOptions.RNL, ref bypass);
                textBoxBypass.Text += @"Метод справа-налево RNL: " + bypass;
            }
            catch
            {
                MessageBox.Show("Ошибка", "Графы", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void BFS_Click(object sender, EventArgs e)
        {
            try
            {
                string bypass = "";
                osinka.Bypass(Tree.BypassOptions.BFS, ref bypass);
                textBoxBypass.Text += @"Обход в ширину BFS: " + bypass;
            }
            catch
            {
                MessageBox.Show("Ошибка", "Графы", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void All_obh_Click(object sender, EventArgs e)
        {
            textBoxBypass.Clear();
            LNR_Click(sender, e);
            NLR_Click(sender, e);
            LRN_Click(sender, e);
            RNL_Click(sender, e);
            BFS_Click(sender, e);
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string results = "";
                int key = Convert.ToInt32(textBoxKey.Text);
                int depth = 0;
                osinka.KeySearch(ref results, key, ref depth);
                if (results != "")
                    textBoxSearch.Text += @"Найден элемент " + results + @"уровень " + depth + Environment.NewLine;
                else textBoxSearch.Text += @"Элемент " + key + @" не найден " + Environment.NewLine;
            }
            catch
            {
                MessageBox.Show("Ошибка", "Графы", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            string results = "";
            osinka.DellNode(Convert.ToInt32(textBoxDelKey.Text));
            osinka.Output(ref results);
            textBoxTree.Text = results;
        }
    }
}