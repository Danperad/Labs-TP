namespace lab_2
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.log = new System.Windows.Forms.TextBox();
            this.firstWord = new System.Windows.Forms.TextBox();
            this.secondWord = new System.Windows.Forms.TextBox();
            this.inOutBox = new System.Windows.Forms.RichTextBox();
            this.reset = new System.Windows.Forms.Button();
            this.findFirstWord = new System.Windows.Forms.Button();
            this.findSecondWord = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(12, 9);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(259, 400);
            this.log.TabIndex = 0;
            // 
            // firstWord
            // 
            this.firstWord.Location = new System.Drawing.Point(277, 43);
            this.firstWord.Name = "firstWord";
            this.firstWord.Size = new System.Drawing.Size(222, 20);
            this.firstWord.TabIndex = 1;
            // 
            // secondWord
            // 
            this.secondWord.Location = new System.Drawing.Point(277, 100);
            this.secondWord.Name = "secondWord";
            this.secondWord.Size = new System.Drawing.Size(222, 20);
            this.secondWord.TabIndex = 2;
            // 
            // inOutBox
            // 
            this.inOutBox.Location = new System.Drawing.Point(505, 12);
            this.inOutBox.Name = "inOutBox";
            this.inOutBox.Size = new System.Drawing.Size(262, 397);
            this.inOutBox.TabIndex = 3;
            this.inOutBox.Text = "";
            this.inOutBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonPIsPress);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(277, 12);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(222, 25);
            this.reset.TabIndex = 4;
            this.reset.Text = "Сброс";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // findFirstWord
            // 
            this.findFirstWord.Location = new System.Drawing.Point(277, 69);
            this.findFirstWord.Name = "findFirstWord";
            this.findFirstWord.Size = new System.Drawing.Size(222, 25);
            this.findFirstWord.TabIndex = 5;
            this.findFirstWord.Text = "Найти первое";
            this.findFirstWord.UseVisualStyleBackColor = true;
            this.findFirstWord.Click += new System.EventHandler(this.button2_Click);
            // 
            // findSecondWord
            // 
            this.findSecondWord.Location = new System.Drawing.Point(277, 126);
            this.findSecondWord.Name = "findSecondWord";
            this.findSecondWord.Size = new System.Drawing.Size(222, 25);
            this.findSecondWord.TabIndex = 6;
            this.findSecondWord.Text = "Найти второе";
            this.findSecondWord.UseVisualStyleBackColor = true;
            this.findSecondWord.Click += new System.EventHandler(this.button3_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(277, 157);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(222, 25);
            this.change.TabIndex = 7;
            this.change.Text = "Поменять";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.change);
            this.Controls.Add(this.findSecondWord);
            this.Controls.Add(this.findFirstWord);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.inOutBox);
            this.Controls.Add(this.secondWord);
            this.Controls.Add(this.firstWord);
            this.Controls.Add(this.log);
            this.Name = "Form1";
            this.Text = "Текстовые файлы, символы и строки";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button change;

        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button findFirstWord;
        private System.Windows.Forms.Button findSecondWord;

        private System.Windows.Forms.RichTextBox inOutBox;
        private System.Windows.Forms.TextBox firstWord;
        private System.Windows.Forms.TextBox secondWord;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox log;

        #endregion
    }
}