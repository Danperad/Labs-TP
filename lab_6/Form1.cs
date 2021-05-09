using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Crypt_Click(object sender, EventArgs e)
        {
            string s = "";
            string key = "";
            if (textBox_PreCrypt.Text == "" || textBox_key.Text == "")
            {
                MessageBox.Show("Ошибка. Текст для шифрования и ключ не должены быть пустыми", "Шифрование",
                    MessageBoxButtons.OK);
                return;
            }

            key = textBox_key.Text;
            if (!Crypto.Check(key))
            {
                MessageBox.Show("Ошибка. В тексте или ключе встречаются сторонние символы", "Шифрование",
                    MessageBoxButtons.OK);
                return;
            }

            s = Crypto.Crypt(textBox_PreCrypt.Text, key);
            if (s == "")
            {
                MessageBox.Show("Ошибка. В тексте или ключе встречаются сторонние символы", "Шифрование",
                    MessageBoxButtons.OK);
                return;
            }
            textBox_Crypt.Text = s;
        }

        private void button_DeCrypt_Click(object sender, EventArgs e)
        {
            string s = "";
            string key = "";
            if (textBox_PreDeCrypt.Text == "" || textBox_key.Text == "")
            {
                MessageBox.Show("Ошибка. Текст для дешифрования и ключ не должены быть пустыми", "Дешифрование",
                    MessageBoxButtons.OK);
                return;
            }
            key = textBox_key.Text;
            if (!Crypto.Check(key))
            {
                MessageBox.Show("Ошибка. В тексте или ключе встречаются сторонние символы", "Дешифрование",
                    MessageBoxButtons.OK);
                return;
            }

            s = Crypto.DeCrypt(textBox_PreDeCrypt.Text, key);
            if (s == "")
            {
                MessageBox.Show("Ошибка. В тексте или ключе встречаются сторонние символы", "Дешифрование",
                    MessageBoxButtons.OK);
                return;
            }
            textBox_Decrypt.Text = s;
        }

        private void CryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_Crypt_Click(sender, e);
        }

        private void DeCryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_DeCrypt_Click(sender, e);
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}