using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
        private void Base_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
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
                AmericanIdiot(delete, y, 680, panel1, 100, 30);
                

                y += 70;
            }
        }
        private void delete(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in panel1.Controls)
            {
                if (control.Location == new Point(10, y + AutoScrollPosition.Y))
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM users WHERE id = '" + control.Tag + "'", Program.con);
                    DbDataReader read = cmd.ExecuteReader();
                    read.Close();
                    foreach (Control control1 in panel1.Controls)
                    {
                        if (control1.Location == new Point(230, y + AutoScrollPosition.Y) && control1.Text == "Учитель")
                        {
                            MySqlCommand cm = new MySqlCommand("DELETE FROM teachers WHERE idtag = '" + control.Tag + "'", Program.con);
                            DbDataReader rea = cm.ExecuteReader();
                            rea.Close();
                        }
                    }
                    MessageBox.Show("Пользователь удвлён из списка.", "System");
                    Base_Load(sender, e);
                    return;
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
