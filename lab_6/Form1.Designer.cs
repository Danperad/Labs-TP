namespace lab_6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeCryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Crypt = new System.Windows.Forms.TextBox();
            this.textBox_PreCrypt = new System.Windows.Forms.TextBox();
            this.button_Crypt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_PreDeCrypt = new System.Windows.Forms.TextBox();
            this.button_DeCrypt = new System.Windows.Forms.Button();
            this.textBox_Decrypt = new System.Windows.Forms.TextBox();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.CryptToolStripMenuItem, this.DeCryptToolStripMenuItem, this.CloseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CryptToolStripMenuItem
            // 
            this.CryptToolStripMenuItem.Name = "CryptToolStripMenuItem";
            this.CryptToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.CryptToolStripMenuItem.Text = "Зашифровать";
            this.CryptToolStripMenuItem.Click += new System.EventHandler(this.CryptToolStripMenuItem_Click);
            // 
            // DeCryptToolStripMenuItem
            // 
            this.DeCryptToolStripMenuItem.Name = "DeCryptToolStripMenuItem";
            this.DeCryptToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.DeCryptToolStripMenuItem.Text = "Расшифровать";
            this.DeCryptToolStripMenuItem.Click += new System.EventHandler(this.DeCryptToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.CloseToolStripMenuItem.Text = "Выход";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Crypt);
            this.groupBox1.Controls.Add(this.textBox_PreCrypt);
            this.groupBox1.Controls.Add(this.button_Crypt);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шифрование";
            // 
            // textBox_Crypt
            // 
            this.textBox_Crypt.Location = new System.Drawing.Point(6, 172);
            this.textBox_Crypt.Name = "textBox_Crypt";
            this.textBox_Crypt.ReadOnly = true;
            this.textBox_Crypt.Size = new System.Drawing.Size(371, 20);
            this.textBox_Crypt.TabIndex = 6;
            // 
            // textBox_PreCrypt
            // 
            this.textBox_PreCrypt.Location = new System.Drawing.Point(6, 33);
            this.textBox_PreCrypt.Name = "textBox_PreCrypt";
            this.textBox_PreCrypt.Size = new System.Drawing.Size(371, 20);
            this.textBox_PreCrypt.TabIndex = 5;
            // 
            // button_Crypt
            // 
            this.button_Crypt.Location = new System.Drawing.Point(125, 91);
            this.button_Crypt.Name = "button_Crypt";
            this.button_Crypt.Size = new System.Drawing.Size(130, 52);
            this.button_Crypt.TabIndex = 4;
            this.button_Crypt.Text = "Зашифровать";
            this.button_Crypt.UseVisualStyleBackColor = true;
            this.button_Crypt.Click += new System.EventHandler(this.button_Crypt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_PreDeCrypt);
            this.groupBox2.Controls.Add(this.button_DeCrypt);
            this.groupBox2.Controls.Add(this.textBox_Decrypt);
            this.groupBox2.Location = new System.Drawing.Point(405, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дешифрование";
            // 
            // textBox_PreDeCrypt
            // 
            this.textBox_PreDeCrypt.Location = new System.Drawing.Point(6, 33);
            this.textBox_PreDeCrypt.Name = "textBox_PreDeCrypt";
            this.textBox_PreDeCrypt.Size = new System.Drawing.Size(371, 20);
            this.textBox_PreDeCrypt.TabIndex = 6;
            // 
            // button_DeCrypt
            // 
            this.button_DeCrypt.Location = new System.Drawing.Point(133, 91);
            this.button_DeCrypt.Name = "button_DeCrypt";
            this.button_DeCrypt.Size = new System.Drawing.Size(130, 52);
            this.button_DeCrypt.TabIndex = 5;
            this.button_DeCrypt.Text = "Расшифровать";
            this.button_DeCrypt.UseVisualStyleBackColor = true;
            this.button_DeCrypt.Click += new System.EventHandler(this.button_DeCrypt_Click);
            // 
            // textBox_Decrypt
            // 
            this.textBox_Decrypt.Location = new System.Drawing.Point(6, 172);
            this.textBox_Decrypt.Name = "textBox_Decrypt";
            this.textBox_Decrypt.ReadOnly = true;
            this.textBox_Decrypt.Size = new System.Drawing.Size(371, 20);
            this.textBox_Decrypt.TabIndex = 3;
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(216, 236);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(371, 20);
            this.textBox_key.TabIndex = 3;
            this.textBox_key.Text = "КЛЮЧ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 268);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Криптография (Матрица Вижнера)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox_key;

        private System.Windows.Forms.TextBox textBox_PreCrypt;
        private System.Windows.Forms.TextBox textBox_PreDeCrypt;
        private System.Windows.Forms.TextBox textBox_Crypt;

        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem CryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeCryptToolStripMenuItem;

        private System.Windows.Forms.Button button_DeCrypt;

        private System.Windows.Forms.TextBox textBox_Decrypt;
        private System.Windows.Forms.Button button_Crypt;

        private System.Windows.Forms.ToolStripMenuItem зашифроватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расшифроватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}