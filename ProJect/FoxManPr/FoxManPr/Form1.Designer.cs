namespace FoxManPr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pan = new System.Windows.Forms.Panel();
            this.filtr = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pan
            // 
            this.pan.Controls.Add(this.button3);
            this.pan.Controls.Add(this.button2);
            this.pan.Controls.Add(this.button1);
            this.pan.Controls.Add(this.label1);
            this.pan.Controls.Add(this.pic);
            this.pan.Controls.Add(this.filtr);
            this.pan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan.Location = new System.Drawing.Point(0, 0);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(942, 1080);
            this.pan.TabIndex = 0;
            this.pan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // filtr
            // 
            this.filtr.Location = new System.Drawing.Point(12, 12);
            this.filtr.Name = "filtr";
            this.filtr.Size = new System.Drawing.Size(120, 23);
            this.filtr.TabIndex = 1;
            this.filtr.Text = "Сетевой город";
            this.filtr.UseVisualStyleBackColor = true;
            this.filtr.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic
            // 
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic.Image = global::FoxManPr.Properties.Resources.gymn13;
            this.pic.Location = new System.Drawing.Point(567, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(363, 242);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(564, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "Гимназия №13";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Справка";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "О нас";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 751);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Выйти из программы";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 1033);
            this.Controls.Add(this.pan);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гимназия №13 - официфльный сайт";
            this.pan.ResumeLayout(false);
            this.pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.Button filtr;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

