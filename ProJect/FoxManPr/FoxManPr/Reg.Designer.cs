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
            this.three = new System.Windows.Forms.TextBox();
            this.four = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Эл. Почта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пароль:";
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(94, 9);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(203, 22);
            this.one.TabIndex = 4;
            this.one.Text = "Введите имя";
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(94, 40);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(203, 22);
            this.two.TabIndex = 5;
            this.two.Text = "Ведите фамилию";
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(94, 75);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(203, 22);
            this.three.TabIndex = 6;
            this.three.Text = "Введите эл. Почту";
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(94, 108);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(203, 22);
            this.four.TabIndex = 7;
            this.four.Text = "Введите пароль ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 192);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox three;
        private System.Windows.Forms.TextBox four;
        private System.Windows.Forms.Button button1;
    }
}