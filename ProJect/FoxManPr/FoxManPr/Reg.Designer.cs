namespace FoxManPr
{
    partial class Reg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.TextBox();
            this.two = new System.Windows.Forms.TextBox();
            this.five = new System.Windows.Forms.TextBox();
            this.four = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.threee = new System.Windows.Forms.ComboBox();
            this.six = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Эл. Почта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пароль:";
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(93, 9);
            this.one.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(203, 22);
            this.one.TabIndex = 4;
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(93, 39);
            this.two.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(203, 22);
            this.two.TabIndex = 5;
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(95, 132);
            this.five.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(203, 22);
            this.five.TabIndex = 6;
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(95, 102);
            this.four.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(203, 22);
            this.four.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Тип:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // threee
            // 
            this.threee.FormattingEnabled = true;
            this.threee.Items.AddRange(new object[] {
            "Ученик",
            "Учитель"});
            this.threee.Location = new System.Drawing.Point(94, 67);
            this.threee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.threee.Name = "threee";
            this.threee.Size = new System.Drawing.Size(203, 24);
            this.threee.TabIndex = 9;
            this.threee.SelectedIndexChanged += new System.EventHandler(this.five_SelectedIndexChanged);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(95, 167);
            this.six.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(203, 22);
            this.six.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Класс:";
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 211);
            this.Controls.Add(this.six);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.threee);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reg";
            this.Load += new System.EventHandler(this.Reg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox one;
        private System.Windows.Forms.TextBox two;
        private System.Windows.Forms.TextBox five;
        private System.Windows.Forms.TextBox four;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox threee;
        private System.Windows.Forms.TextBox six;
        private System.Windows.Forms.Label label6;
    }
}