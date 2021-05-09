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

namespace lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            change.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ContextMenu contextMenu1;
            contextMenu1 = new System.Windows.Forms.ContextMenu();
            System.Windows.Forms.MenuItem menuItem1;
            menuItem1 = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem menuItem2;
            menuItem2 = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem menuItem3;
            menuItem3 = new System.Windows.Forms.MenuItem();
            contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                menuItem1, menuItem2, menuItem3
            });
            menuItem1.Index = 0;
            menuItem1.Text = "Открыть";
            menuItem2.Index = 1;
            menuItem2.Text = "Сохранить";
            menuItem3.Index = 2;
            menuItem3.Text = "Сохранить как";
            inOutBox.ContextMenu = contextMenu1;
            menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
        }

        string MyFName = "";

        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            openFileDialog1.Filter = "Текстовые файлы (*.rtf; *.txt; *.dat) | *.rtf; *.txt; *.dat";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MyFName = openFileDialog1.FileName;
                inOutBox.LoadFile(MyFName);
            }
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            if (MyFName != "")
            {
                inOutBox.SaveFile(MyFName);
            }
            else
            {
                saveFileDialog1.Filter = "Текстовые файлы (*.rtf; *.txt; *.dat) | *.rtf; *.txt; *.dat";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    MyFName = saveFileDialog1.FileName;
                    inOutBox.SaveFile(MyFName);
                }
            }
        }

        private void menuItem3_Click(object sender, System.EventArgs e)
        {
            saveFileDialog1.Filter = "Текстовые файлы (*.rtf; *.txt; *.dat) | *.rtf; *.txt; *.dat";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MyFName = saveFileDialog1.FileName;
                inOutBox.SaveFile(MyFName);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            log.Clear();
            firstWord.Clear();
            secondWord.Clear();
            inOutBox.Clear();
            findFirstWord.Enabled = true;
            findSecondWord.Enabled = true;
            change.Enabled = true;
        }

        int result1, result2;

        private void button2_Click(object sender, EventArgs e)
        {
            int LenText;
            log.Text += "Поиск первого слова" + Environment.NewLine;
            String FWord = firstWord.Text.ToString();
            LenText = inOutBox.Text.Length;
            result1 = FindWord(FWord, LenText);
            if (result1 != -1)
            {
                log.Text += "Позиция первого слова: " + (result1 + 1) + Environment.NewLine + Environment.NewLine;
                inOutBox.SelectionStart = result1;
                inOutBox.SelectionLength = FWord.Length;
                inOutBox.SelectionBackColor = Color.Red;
                findFirstWord.Enabled = false;
                if (findSecondWord.Enabled == false)
                {
                    change.Enabled = true;
                }
            }
            else
            {
                log.Text += "Слово не найдено " + Environment.NewLine + Environment.NewLine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int LenText;

            log.Text += "Поиск второго слова" + Environment.NewLine;
            String FWord = secondWord.Text.ToString();
            LenText = inOutBox.Text.Length;
            result2 = FindWord(FWord, LenText);
            if (result2 != -1)
            {
                log.Text += "Позиция второго слова: " + (result2 + 1) + Environment.NewLine + Environment.NewLine;
                inOutBox.SelectionStart = result2;
                inOutBox.SelectionLength = FWord.Length;
                inOutBox.SelectionBackColor = Color.Green;
                findSecondWord.Enabled = false;
                if (findFirstWord.Enabled == false)
                {
                    change.Enabled = true;
                }
            }
            else
            {
                log.Text += "Слово не найдено " + Environment.NewLine + Environment.NewLine;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (result1 < result2)
            {
                inOutBox.Select(result2, secondWord.Text.Length);
                inOutBox.SelectedText = firstWord.Text.ToString();
                inOutBox.Select(result1, firstWord.Text.Length);
                inOutBox.SelectedText = secondWord.Text.ToString();
                log.Text += "Произошла замена слов";
                change.Enabled = false;
            }
            else
            {
                inOutBox.Select(result1, firstWord.Text.Length);
                inOutBox.SelectedText = secondWord.Text.ToString();
                inOutBox.Select(result2, secondWord.Text.Length);
                inOutBox.SelectedText = firstWord.Text.ToString();
                log.Text += "Произошла замена слов";
                change.Enabled = false;
            }
        }

        int FindWord(String FWord, int n)
        {
            int LenWord;
            String ComparText;
            LenWord = FWord.Length;
            for (int i = 0; i <= n - LenWord; i++)
            {
                ComparText = inOutBox.Text.Substring(i, LenWord);
                if (ComparText == FWord)
                {
                    return i;
                }
            }

            return -1;
        }

        int xxxx;

        int MaxLenght(string Text)
        {
            int LenText = Text.Length;
            int max = 0;
            int numLitt = 0;
            int numSpace = 0;
            for (int i = 0; i < LenText; i++)
            {
                string charr = inOutBox.Text.Substring(i, 1);
                if (!int.TryParse(charr, out xxxx) && numLitt == 0) continue;
                if (int.TryParse(charr, out xxxx))
                {
                    numLitt++;
                    numLitt += numSpace;
                    numSpace = 0;
                }

                if (charr == " " && numLitt > 0)
                {
                    numSpace++;
                }

                if (numLitt > max && !int.TryParse(charr, out xxxx) && charr != " ")
                {
                    max = numLitt;
                    numLitt = 0;
                    numSpace = 0;
                }
                else if (numLitt <= max && !int.TryParse(charr, out xxxx) && charr != " ")
                {
                    numLitt = 0;
                    numSpace = 0;
                }
            }

            if (numLitt > max) max = numLitt;
            return max;
        }

        int max;
        int numLett = -1;

        private void ButtonPIsPress(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyValue == 80)
            {
                max = MaxLenght(inOutBox.Text);
                if (max < 1)
                {
                    log.Text += "Цифры не найдены";
                    return;
                }

                if (numLett != -1)
                {
                    inOutBox.SelectionStart = 0;
                    inOutBox.SelectionLength = inOutBox.Text.Length;
                    inOutBox.SelectionBackColor = Color.White;
                }
                while (true)
                {
                    numLett++;
                    if (numLett == inOutBox.Text.Length - max+1) numLett = 0;
                    
                    string strr = inOutBox.Text.Substring(numLett, max);
                    if (int.TryParse(strr.Substring(0, 1), out xxxx) &&
                        int.TryParse(strr.Substring(max-1, 1), out xxxx))
                    {
                        if (ulong.TryParse(strr.Replace(" ", ""), out ulong yyyy))
                        {
                            inOutBox.SelectionStart = numLett;
                            inOutBox.SelectionLength = max;
                            inOutBox.SelectionBackColor = Color.Blue;
                            return;
                        }
                    }
                }
            }
        }
    }
}