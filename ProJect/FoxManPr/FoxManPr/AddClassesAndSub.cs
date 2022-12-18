using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FoxManPr
{
    public partial class AddClassesAndSub : Form
    {
        public AddClassesAndSub()
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
                lbl.BackColor = Color.Transparent;
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

        private void AddClassesAndSub_Load(object sender, EventArgs e)
        {
            List<string> list  = NetCity.MySelect("SELECT class, id FROM classes");
            List<string> list2 = NetCity.MySelect("SELECT name, id FROM sub");

            pan1.Controls.Clear();
            pan2.Controls.Clear();
            int y = 50;
            int y2 = 50;

            for (int i = 0; i < list2.Count; i += 2)
            {
                LetsDance(i, y2, 10, list2, 0, 1, pan1, 200, 30);
                AmericanIdiot(delete2, y2, 230, pan1, 100, 30);
                y2 += 47;
            }
            for (int i = 0; i < list.Count; i += 2)
            {
                LetsDance(i, y, 10, list, 0, 1, pan2, 50, 30);
                AmericanIdiot(delete, y, 70, pan2, 100, 30);
                y += 47;
            }
        }
        private void delete(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in pan2.Controls)
            {
                if (control.Location == new Point(10, y + AutoScrollPosition.Y))
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM classes WHERE id = '" + control.Tag + "'", Program.con);
                    DbDataReader read = cmd.ExecuteReader();
                    read.Close();
                    MessageBox.Show("Класс удаленён", "System");
                    AddClassesAndSub_Load(sender, e);
                    return;
                }
            }
        }
        private void delete2(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in pan1.Controls)
            {
                if (control.Location == new Point(10, y + AutoScrollPosition.Y))
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM sub WHERE id = '" + control.Tag + "'", Program.con);
                    DbDataReader read = cmd.ExecuteReader();
                    read.Close();
                    MessageBox.Show("Предмет удаленён", "System");
                    AddClassesAndSub_Load(sender, e);
                    return;
                }
            }
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            if (t1.Text != "")
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO sub(name)"
                                        + "VALUES('" + t1.Text + "')", Program.con);
                DbDataReader read = cmd.ExecuteReader();
                read.Close();
                MessageBox.Show("Предмет добавлен.", "System");
                AddClassesAndSub_Load(sender, e);
                return;
            }
            else { MessageBox.Show("Заполните поле.", "System"); }
        }
        private void bt2_Click(object sender, EventArgs e)
        {
            if (t2.Text != "")
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO classes(class)"
                                        + "VALUES('" + t2.Text + "')", Program.con);
                DbDataReader read = cmd.ExecuteReader();
                read.Close();
                MessageBox.Show("Класс добавлен.", "System");
                AddClassesAndSub_Load(sender, e);
                return;
            }
            else { MessageBox.Show("Заполните поле.", "System"); }
        }
    }
}
