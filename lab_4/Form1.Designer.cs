namespace lab_4
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
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьЗапросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add_Dock = new System.Windows.Forms.Button();
            this.Time_Date = new System.Windows.Forms.DateTimePicker();
            this.Add = new System.Windows.Forms.Button();
            this.PriceTov = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.TextBox();
            this.NumTov = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name_prod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Find = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OutputFirst = new System.Windows.Forms.DataGridView();
            this.OutputSecond = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.NumTov)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.OutputFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.OutputSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.действияToolStripMenuItem, this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.добавитьДанныеToolStripMenuItem, this.выполнитьЗапросToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // добавитьДанныеToolStripMenuItem
            // 
            this.добавитьДанныеToolStripMenuItem.Name = "добавитьДанныеToolStripMenuItem";
            this.добавитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.добавитьДанныеToolStripMenuItem.Text = "Добавить данные";
            this.добавитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.добавитьДанныеToolStripMenuItem_Click);
            // 
            // выполнитьЗапросToolStripMenuItem
            // 
            this.выполнитьЗапросToolStripMenuItem.Name = "выполнитьЗапросToolStripMenuItem";
            this.выполнитьЗапросToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.выполнитьЗапросToolStripMenuItem.Text = "Выполнить запрос";
            this.выполнитьЗапросToolStripMenuItem.Click += new System.EventHandler(this.выполнитьЗапросToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Add_Dock);
            this.groupBox1.Controls.Add(this.Time_Date);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Controls.Add(this.PriceTov);
            this.groupBox1.Controls.Add(this.FIO);
            this.groupBox1.Controls.Add(this.NumTov);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Name_prod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 347);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // Add_Dock
            // 
            this.Add_Dock.Location = new System.Drawing.Point(6, 293);
            this.Add_Dock.Name = "Add_Dock";
            this.Add_Dock.Size = new System.Drawing.Size(138, 39);
            this.Add_Dock.TabIndex = 11;
            this.Add_Dock.Text = "Добавить из документа";
            this.Add_Dock.UseVisualStyleBackColor = true;
            this.Add_Dock.Click += new System.EventHandler(this.Add_Dock_Click);
            // 
            // Time_Date
            // 
            this.Time_Date.Location = new System.Drawing.Point(6, 120);
            this.Time_Date.Name = "Time_Date";
            this.Time_Date.Size = new System.Drawing.Size(138, 20);
            this.Time_Date.TabIndex = 7;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(6, 248);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(138, 39);
            this.Add.TabIndex = 10;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // PriceTov
            // 
            this.PriceTov.Location = new System.Drawing.Point(6, 213);
            this.PriceTov.Name = "PriceTov";
            this.PriceTov.Size = new System.Drawing.Size(138, 20);
            this.PriceTov.TabIndex = 9;
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(6, 77);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(138, 20);
            this.FIO.TabIndex = 8;
            // 
            // NumTov
            // 
            this.NumTov.Location = new System.Drawing.Point(6, 170);
            this.NumTov.Name = "NumTov";
            this.NumTov.Size = new System.Drawing.Size(138, 20);
            this.NumTov.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Количество";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата продажи";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Покупатель";
            // 
            // Name_prod
            // 
            this.Name_prod.Location = new System.Drawing.Point(6, 36);
            this.Name_prod.Name = "Name_prod";
            this.Name_prod.Size = new System.Drawing.Size(138, 20);
            this.Name_prod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Товар";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Find);
            this.groupBox2.Location = new System.Drawing.Point(12, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 64);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Запрос";
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(28, 19);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(90, 34);
            this.Find.TabIndex = 0;
            this.Find.Text = "Найти";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(168, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Данные";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(168, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Выборка";
            // 
            // OutputFirst
            // 
            this.OutputFirst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputFirst.Location = new System.Drawing.Point(168, 43);
            this.OutputFirst.Name = "OutputFirst";
            this.OutputFirst.Size = new System.Drawing.Size(620, 182);
            this.OutputFirst.TabIndex = 5;
            // 
            // OutputSecond
            // 
            this.OutputSecond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputSecond.Location = new System.Drawing.Point(168, 250);
            this.OutputSecond.Name = "OutputSecond";
            this.OutputSecond.Size = new System.Drawing.Size(620, 194);
            this.OutputSecond.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputSecond);
            this.Controls.Add(this.OutputFirst);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Работа со структурами";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.NumTov)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.OutputFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.OutputSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button Add_Dock;

        private System.Windows.Forms.DateTimePicker Time_Date;

        private System.Windows.Forms.DataGridView OutputSecond;

        private System.Windows.Forms.DataGridView OutputFirst;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Button Find;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Button Add;

        private System.Windows.Forms.TextBox PriceTov;

        private System.Windows.Forms.NumericUpDown NumTov;
        private System.Windows.Forms.TextBox FIO;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox Name_prod;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.ToolStripMenuItem выполнитьЗапросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьДанныеToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}