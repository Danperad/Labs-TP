namespace Lab5
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
            this.обработкаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Load_data = new System.Windows.Forms.ToolStripMenuItem();
            this.bypass = new System.Windows.Forms.ToolStripMenuItem();
            this.LNR = new System.Windows.Forms.ToolStripMenuItem();
            this.NLR = new System.Windows.Forms.ToolStripMenuItem();
            this.LRN = new System.Windows.Forms.ToolStripMenuItem();
            this.RNL = new System.Windows.Forms.ToolStripMenuItem();
            this.BFS = new System.Windows.Forms.ToolStripMenuItem();
            this.All_obh = new System.Windows.Forms.ToolStripMenuItem();
            this.Close_App = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTree = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBypass = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.delButton = new System.Windows.Forms.Button();
            this.textBoxDelKey = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.обработкаДанныхToolStripMenuItem, this.Close_App});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обработкаДанныхToolStripMenuItem
            // 
            this.обработкаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.Load_data, this.bypass});
            this.обработкаДанныхToolStripMenuItem.Name = "обработкаДанныхToolStripMenuItem";
            this.обработкаДанныхToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.обработкаДанныхToolStripMenuItem.Text = "Обработка данных";
            // 
            // Load_data
            // 
            this.Load_data.Name = "Load_data";
            this.Load_data.Size = new System.Drawing.Size(172, 22);
            this.Load_data.Text = "Загрузить данные";
            this.Load_data.Click += new System.EventHandler(this.Load_data_Click);
            // 
            // bypass
            // 
            this.bypass.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.LNR, this.NLR, this.LRN, this.RNL, this.BFS, this.All_obh});
            this.bypass.Name = "bypass";
            this.bypass.Size = new System.Drawing.Size(172, 22);
            this.bypass.Text = "Выполнить обход";
            // 
            // LNR
            // 
            this.LNR.Name = "LNR";
            this.LNR.Size = new System.Drawing.Size(231, 22);
            this.LNR.Text = "Симметричный метод - LNR";
            this.LNR.Click += new System.EventHandler(this.LNR_Click);
            // 
            // NLR
            // 
            this.NLR.Name = "NLR";
            this.NLR.Size = new System.Drawing.Size(231, 22);
            this.NLR.Text = "Прямой метод - NLR";
            this.NLR.Click += new System.EventHandler(this.NLR_Click);
            // 
            // LRN
            // 
            this.LRN.Name = "LRN";
            this.LRN.Size = new System.Drawing.Size(231, 22);
            this.LRN.Text = "Обратный метод - LRN";
            this.LRN.Click += new System.EventHandler(this.LRN_Click);
            // 
            // RNL
            // 
            this.RNL.Name = "RNL";
            this.RNL.Size = new System.Drawing.Size(231, 22);
            this.RNL.Text = "Метод справа-налево - RNL";
            this.RNL.Click += new System.EventHandler(this.RNL_Click);
            // 
            // BFS
            // 
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(231, 22);
            this.BFS.Text = "Обход в ширину - BFS";
            this.BFS.Click += new System.EventHandler(this.BFS_Click);
            // 
            // All_obh
            // 
            this.All_obh.Name = "All_obh";
            this.All_obh.Size = new System.Drawing.Size(231, 22);
            this.All_obh.Text = "Все...";
            this.All_obh.Click += new System.EventHandler(this.All_obh_Click);
            // 
            // Close_App
            // 
            this.Close_App.Name = "Close_App";
            this.Close_App.Size = new System.Drawing.Size(54, 20);
            this.Close_App.Text = "Выход";
            this.Close_App.Click += new System.EventHandler(this.Close_App_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTree);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 411);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дерево";
            // 
            // textBoxTree
            // 
            this.textBoxTree.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxTree.Location = new System.Drawing.Point(6, 19);
            this.textBoxTree.Multiline = true;
            this.textBoxTree.Name = "textBoxTree";
            this.textBoxTree.ReadOnly = true;
            this.textBoxTree.Size = new System.Drawing.Size(380, 386);
            this.textBoxTree.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxBypass);
            this.groupBox2.Location = new System.Drawing.Point(410, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 119);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обходы";
            // 
            // textBoxBypass
            // 
            this.textBoxBypass.Location = new System.Drawing.Point(6, 19);
            this.textBoxBypass.Multiline = true;
            this.textBoxBypass.Name = "textBoxBypass";
            this.textBoxBypass.ReadOnly = true;
            this.textBoxBypass.Size = new System.Drawing.Size(366, 88);
            this.textBoxBypass.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSearch);
            this.groupBox3.Controls.Add(this.button_Search);
            this.groupBox3.Controls.Add(this.textBoxKey);
            this.groupBox3.Location = new System.Drawing.Point(410, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 226);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск ключа";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(6, 45);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.ReadOnly = true;
            this.textBoxSearch.Size = new System.Drawing.Size(366, 175);
            this.textBoxSearch.TabIndex = 2;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(265, 19);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(107, 20);
            this.button_Search.TabIndex = 1;
            this.button_Search.Text = "Поиск";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(6, 19);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(241, 20);
            this.textBoxKey.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.delButton);
            this.groupBox4.Controls.Add(this.textBoxDelKey);
            this.groupBox4.Location = new System.Drawing.Point(410, 152);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 54);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Удаление узла";
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(265, 19);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(107, 20);
            this.delButton.TabIndex = 1;
            this.delButton.Text = "Удалить узел";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // textBoxDelKey
            // 
            this.textBoxDelKey.Location = new System.Drawing.Point(6, 19);
            this.textBoxDelKey.Name = "textBoxDelKey";
            this.textBoxDelKey.Size = new System.Drawing.Size(241, 20);
            this.textBoxDelKey.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxDelKey;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.ToolStripMenuItem Close_App;

        private System.Windows.Forms.TextBox textBoxSearch;

        private System.Windows.Forms.TextBox textBoxBypass;

        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxTree;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem All_obh;
        private System.Windows.Forms.ToolStripMenuItem bypass;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Load_data;
        private System.Windows.Forms.ToolStripMenuItem RNL;
        private System.Windows.Forms.ToolStripMenuItem обработкаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LRN;
        private System.Windows.Forms.ToolStripMenuItem BFS;
        private System.Windows.Forms.ToolStripMenuItem NLR;
        private System.Windows.Forms.ToolStripMenuItem LNR;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}