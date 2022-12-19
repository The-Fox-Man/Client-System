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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMarks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Data = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.check = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dat = new System.Windows.Forms.TextBox();
            this.yup = new System.Windows.Forms.Button();
            this.numb = new System.Windows.Forms.ComboBox();
            this.day = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.marke = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.BackgroundImage = global::FoxManPr.Properties.Resources.gradient;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Data);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 54);
            this.panel1.TabIndex = 0;
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.Color.Transparent;
            this.Data.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.Data.ForeColor = System.Drawing.Color.White;
            this.Data.Location = new System.Drawing.Point(5, 2);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(64, 26);
            this.Data.TabIndex = 0;
            this.Data.Text = "label1";
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::FoxManPr.Properties.Resources.Square;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Location = new System.Drawing.Point(0, 91);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(641, 470);
            this.panel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackgroundImage = global::FoxManPr.Properties.Resources.Line;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.check);
            this.panel2.Controls.Add(this.dateTimePicker1);
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
            // check
            // 
            this.check.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.check.Location = new System.Drawing.Point(3, 374);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(168, 38);
            this.check.TabIndex = 19;
            this.check.Text = "Посмотреть расписание";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 342);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 23);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // dat
            // 
            this.dat.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.dat.Location = new System.Drawing.Point(6, 109);
            this.dat.Name = "dat";
            this.dat.Size = new System.Drawing.Size(158, 23);
            this.dat.TabIndex = 13;
            // 
            // yup
            // 
            this.yup.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.yup.Location = new System.Drawing.Point(1, 232);
            this.yup.Name = "yup";
            this.yup.Size = new System.Drawing.Size(170, 40);
            this.yup.TabIndex = 12;
            this.yup.Text = "Выставить";
            this.yup.UseVisualStyleBackColor = true;
            this.yup.Click += new System.EventHandler(this.button1_Click);
            // 
            // numb
            // 
            this.numb.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.numb.FormattingEnabled = true;
            this.numb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.numb.Location = new System.Drawing.Point(6, 202);
            this.numb.Name = "numb";
            this.numb.Size = new System.Drawing.Size(158, 23);
            this.numb.TabIndex = 9;
            // 
            // day
            // 
            this.day.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.day.FormattingEnabled = true;
            this.day.Items.AddRange(new object[] {
            "пн",
            "вт",
            "ср",
            "чт",
            "пт",
            "сб"});
            this.day.Location = new System.Drawing.Point(6, 155);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(158, 23);
            this.day.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label6.Location = new System.Drawing.Point(5, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "День недели";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label5.Location = new System.Drawing.Point(7, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Номер предмета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label3.Location = new System.Drawing.Point(7, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Оценка";
            // 
            // marke
            // 
            this.marke.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.marke.FormattingEnabled = true;
            this.marke.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2"});
            this.marke.Location = new System.Drawing.Point(6, 62);
            this.marke.Name = "marke";
            this.marke.Size = new System.Drawing.Size(158, 23);
            this.marke.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поставить оценку";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(128, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Оценка";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(20, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "Дата";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(201, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 22);
            this.label11.TabIndex = 5;
            this.label11.Text = "Но. пред.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Воспользуйтесть этим\r\n";
            // 
            // UserMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FoxManPr.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 561);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserMarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMarks";
            this.Load += new System.EventHandler(this.UserMarks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Data;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
    }
}