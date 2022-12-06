namespace FoxManPr
{
    partial class AddClassesAndSub
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pan1
            // 
            this.pan1.AutoScroll = true;
            this.pan1.Location = new System.Drawing.Point(12, 49);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(428, 499);
            this.pan1.TabIndex = 0;
            // 
            // pan2
            // 
            this.pan2.AutoScroll = true;
            this.pan2.Location = new System.Drawing.Point(446, 49);
            this.pan2.Name = "pan2";
            this.pan2.Size = new System.Drawing.Size(413, 499);
            this.pan2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добаавить предмет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Добавить класс";
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(128, 18);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(182, 20);
            this.t1.TabIndex = 3;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(547, 18);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(180, 20);
            this.t2.TabIndex = 4;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(316, 16);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(124, 23);
            this.bt1.TabIndex = 5;
            this.bt1.Text = "Добавить";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(735, 17);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(124, 23);
            this.bt2.TabIndex = 6;
            this.bt2.Text = "Добавить";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // AddClassesAndSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 560);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pan2);
            this.Controls.Add(this.pan1);
            this.Name = "AddClassesAndSub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClassesAndSub";
            this.Load += new System.EventHandler(this.AddClassesAndSub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pan1;
        private System.Windows.Forms.Panel pan2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
    }
}