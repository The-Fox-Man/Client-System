namespace FoxManPr
{
    partial class UserMarks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Type = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.marke = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.ComboBox();
            this.numb = new System.Windows.Forms.ComboBox();
            this.yup = new System.Windows.Forms.Button();
            this.dat = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.Type);
            this.panel1.Controls.Add(this.Data);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 54);
            this.panel1.TabIndex = 0;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(13, 26);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(35, 13);
            this.Type.TabIndex = 1;
            this.Type.Text = "label1";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(13, 13);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(35, 13);
            this.Data.TabIndex = 0;
            this.Data.Text = "label1";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(0, 60);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(641, 501);
            this.panel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.dat);
            this.panel2.Controls.Add(this.yup);
            this.panel2.Controls.Add(this.numb);
            this.panel2.Controls.Add(this.day);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.marke);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(647, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(176, 501);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поставить оценку";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя Фамилия";
            // 
            // marke
            // 
            this.marke.FormattingEnabled = true;
            this.marke.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2"});
            this.marke.Location = new System.Drawing.Point(6, 74);
            this.marke.Name = "marke";
            this.marke.Size = new System.Drawing.Size(158, 21);
            this.marke.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Оценка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Число";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Номер предмета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "День недели";
            // 
            // day
            // 
            this.day.FormattingEnabled = true;
            this.day.Items.AddRange(new object[] {
            "пн",
            "вт",
            "ср",
            "чт",
            "пт",
            "сб"});
            this.day.Location = new System.Drawing.Point(6, 177);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(158, 21);
            this.day.TabIndex = 8;
            // 
            // numb
            // 
            this.numb.FormattingEnabled = true;
            this.numb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.numb.Location = new System.Drawing.Point(6, 228);
            this.numb.Name = "numb";
            this.numb.Size = new System.Drawing.Size(158, 21);
            this.numb.TabIndex = 9;
            // 
            // yup
            // 
            this.yup.Location = new System.Drawing.Point(3, 269);
            this.yup.Name = "yup";
            this.yup.Size = new System.Drawing.Size(170, 23);
            this.yup.TabIndex = 12;
            this.yup.Text = "Выставить";
            this.yup.UseVisualStyleBackColor = true;
            this.yup.Click += new System.EventHandler(this.button1_Click);
            // 
            // dat
            // 
            this.dat.Location = new System.Drawing.Point(6, 123);
            this.dat.Name = "dat";
            this.dat.Size = new System.Drawing.Size(158, 20);
            this.dat.TabIndex = 13;
            // 
            // UserMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Name = "UserMarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMarks";
            this.Load += new System.EventHandler(this.UserMarks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox numb;
        private System.Windows.Forms.ComboBox day;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox marke;
        private System.Windows.Forms.Button yup;
        private System.Windows.Forms.TextBox dat;
    }
}