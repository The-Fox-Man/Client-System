namespace FoxManPr
{
    partial class TeachersForm
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
            this.pan1 = new System.Windows.Forms.Panel();
            this.pan2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cm = new System.Windows.Forms.ComboBox();
            this.pan2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan1
            // 
            this.pan1.AutoScroll = true;
            this.pan1.Location = new System.Drawing.Point(12, 12);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(785, 280);
            this.pan1.TabIndex = 0;
            // 
            // pan2
            // 
            this.pan2.Controls.Add(this.textBox2);
            this.pan2.Controls.Add(this.label4);
            this.pan2.Controls.Add(this.textBox1);
            this.pan2.Controls.Add(this.label3);
            this.pan2.Controls.Add(this.label2);
            this.pan2.Controls.Add(this.button1);
            this.pan2.Location = new System.Drawing.Point(12, 311);
            this.pan2.Name = "pan2";
            this.pan2.Size = new System.Drawing.Size(785, 377);
            this.pan2.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Фамилия";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добавить учителя";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cm
            // 
            this.cm.FormattingEnabled = true;
            this.cm.Location = new System.Drawing.Point(266, 340);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(277, 21);
            this.cm.TabIndex = 49;
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 700);
            this.Controls.Add(this.cm);
            this.Controls.Add(this.pan2);
            this.Controls.Add(this.pan1);
            this.Name = "TeachersForm";
            this.Text = "TeachersForm";
            this.Load += new System.EventHandler(this.TeachersForm_Load);
            this.pan2.ResumeLayout(false);
            this.pan2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan1;
        private System.Windows.Forms.Panel pan2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cm;
    }
}