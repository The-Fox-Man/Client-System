using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxManPr
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
            List<string> list = NetCity.MySelect("SELECT name, surn, type, pass, post, clas, id FROM users");
            int y = 50;
            for (int i = 0; i < list.Count; i += 7)
            {
                LetsDance(i, y, 10, list, 0, 6, panel1, 100, 50);
                LetsDance(i, y, 120, list, 1, 6, panel1, 100, 50);
                LetsDance(i, y, 230, list, 2, 6, panel1, 100, 50);
                LetsDance(i, y, 340, list, 3, 6, panel1, 100, 50);
                LetsDance(i, y, 450, list, 4, 6, panel1, 100, 50);
                LetsDance(i, y, 560, list, 5, 6, panel1, 100, 50);

                y += 70;
            }

        }
        private void LetsDance(int i, int y, int x, List<string> list, int b, int c, Panel pan, int sX, int sY)
        {
            Label lbl = new Label();
            lbl.Location = new Point(x, y);
            lbl.Size = new Size(sX, sY);
            lbl.Text = list[i + b];
            lbl.Tag = list[i + c];
            pan.Controls.Add(lbl);
        }

        private void AmericanIdiot(EventHandler ev, int y, int x, Panel pan, int sX, int sY)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Size = new Size(sX, sY);
            btn.TabIndex = 0;
            btn.Text = "Удалить";
            btn.UseVisualStyleBackColor = true;
            btn.Click += new EventHandler(ev);
            pan.Controls.Add(btn);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
