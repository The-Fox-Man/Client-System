using System;
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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            List<string> list = NetCity.MySelect("SELECT name, surn, idsub FROM teachers");
            
            pan1.Controls.Clear();
            int y = 50;
            int x = 50;
            
            for (int i = 0; i < list.Count; i += 3)
            {
                    Label lbl = new Label();
                    lbl.Location = new Point(10, y);
                    lbl.Size = new Size(145, 30);
                    lbl.Text = list[i];
                    lbl.BackColor = Color.Transparent;
                    pan1.Controls.Add(lbl);

                    Label lbl1 = new Label();
                    lbl1.Location = new Point(160, y);
                    lbl1.Size = new Size(145, 30);
                    lbl1.Text = list[i + 1];
                    lbl1.BackColor = Color.Transparent;
                    pan1.Controls.Add(lbl1);

                    List<string> li = NetCity.MySelect("SELECT name FROM sub WHERE id = '" + list[i+2] + "'");
                    for (int o = 0; o < li.Count; o++)
                    {
                        Label lbl2 = new Label();
                        lbl2.Location = new Point(320, y);
                        lbl2.Size = new Size(145, 30);
                        lbl2.Text = li[o];
                        lbl2.BackColor = Color.Transparent;
                        pan1.Controls.Add(lbl2);
                    }

                    y += 47;        
            }
        }

        private void Teachers_Load(object sender, EventArgs e)
        {

        }

        private void pan1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
