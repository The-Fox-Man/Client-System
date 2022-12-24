using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxManPr
{
    public partial class adminSub : Form
    {

        public adminSub()
        {
            InitializeComponent();
            List<string> list = NetCity.MySelect("SELECT name, id FROM sub");
            List<string> list2 = NetCity.MySelect("SELECT class, id FROM classes");
            for (int i = 0; i < list.Count; i += 2)
            {
                t1.Items.Add(list[i]);
                t2.Items.Add(list[i]);
                t3.Items.Add(list[i]);
                t4.Items.Add(list[i]);
                t5.Items.Add(list[i]);
                t6.Items.Add(list[i]);
                t7.Items.Add(list[i]);
            }
            for (int i = 0; i < list2.Count; i += 2)
            {
                t9.Items.Add(list2[i]);
                cm1.Items.Add(list2[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string[] parts = cm.Text.Split(new char[] {','});
            if (t8.Text != "" && t9.Text != "")
            {
                List<string> list = NetCity.MySelect("SELECT day, clas FROM subjects WHERE clas = '" + t9.Text + "'AND day = '" + t8.Text + "'");
                if (list.Count == 0)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO subjects(1t, 2d, 3d, 4th, 5th, 6th, 7th, day, clas)"
                                    + "VALUES('" + t1.Text + "', '" + t2.Text + "', " +
                                    "'" + t3.Text + "', '" + t4.Text + "'," +
                                    " '" + t5.Text + "', '" + t6.Text + "', '"
                                    + t7.Text + "', '" + t8.Text + "', '" + t9.Text + "')", Program.con);
                    DbDataReader read = cmd.ExecuteReader();
                    read.Close();
                    MessageBox.Show("Расписание на один день добавлено.", "System");
                    adminSub_Load(sender, e);
                    return;
                }
                else { MessageBox.Show("У вас уже есть этот день.", "System"); }
            }
            else { MessageBox.Show("Зпаолните все поля.", "System"); }

        }

        private void adminSub_Load(object sender, EventArgs e)
        {
                List<string> list = NetCity.MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th, day, clas, id FROM subjects");

                pan1.Controls.Clear();
                int y = 50;
                int x = 50;
                for (int i = 0; i < list.Count; i += 10)
                {
                     a(list, i, y);
                     y += 70;
                }
        }
        private void delete(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach(Control control in pan1.Controls)
            {
                if (control.Location == new Point(10, y + AutoScrollPosition.Y))
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM subjects WHERE id = '" + control.Tag + "'", Program.con);
                    DbDataReader read = cmd.ExecuteReader();
                    read.Close();
                    MessageBox.Show("Расписание на один день удалено.", "System");
                    butt_Click(sender, e);
                    return;
                }
            }
        }

        private void pan1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butt_Click(object sender, EventArgs e)
        {
            if (cm1.Text == "" && cm2.Text == "")
            {
                List<string> list = NetCity.MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th, day, clas, id FROM subjects");
                pan1.Controls.Clear();
                int y = 50;
                for (int i = 0; i < list.Count; i += 10)
                {
                    a(list, i, y);
                    y += 70;
                }
            }
            if (cm1.Text != "")
            {
                List<string> list = NetCity.MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th, day, clas, id FROM subjects WHERE clas = '" + cm1.Text + "'");

                pan1.Controls.Clear();
                int y = 50;
                for (int i = 0; i < list.Count; i += 10)
                {
                    a(list, i, y);
                    y += 70;
                }
            }
            if (cm2.Text != "")
            {
                List<string> list = NetCity.MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th, day, clas, id FROM subjects WHERE day = '" + cm2.Text + "'");
                pan1.Controls.Clear();
                int y = 50;
                for (int i = 0; i < list.Count; i += 10)
                {
                    a(list, i, y);
                    y += 70;
                }
            }
            if (cm2.Text != "" && cm1.Text != "")
            {
                List<string> list = NetCity.MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th, day, clas, id FROM subjects WHERE day = '" + cm2.Text + "' AND clas = '" + cm1.Text + "'");
                pan1.Controls.Clear();
                int y = 50;
                for (int i = 0; i < list.Count; i += 10)
                {
                    a(list, i, y);
                    y += 70;
                }
            }

        }
        private void a(List<string> list, int i, int y)
        {
            Label lbl = new Label();
            lbl.Location = new Point(10, y);
            lbl.Size = new Size(145, 65);
            lbl.Text = list[i];
            lbl.Tag = list[i + 9];
            lbl.BackColor = Color.Transparent;
            pan1.Controls.Add(lbl);

            Label lbl1 = new Label();
            lbl1.Location = new Point(160, y);
            lbl1.Size = new Size(145, 65);
            lbl1.Text = list[i + 1];
            lbl1.BackColor = Color.Transparent;
            pan1.Controls.Add(lbl1);


            Label lbl2 = new Label();
            lbl2.Location = new Point(310, y);
            lbl2.Size = new Size(145, 65);
            lbl2.Text = list[i + 2];
            lbl2.BackColor = Color.Transparent;
            pan1.Controls.Add(lbl2);

            Label lbl3 = new Label();
            lbl3.Location = new Point(460, y);
            lbl3.Size = new Size(145, 65);
            lbl3.Text = list[i + 3];
            lbl3.BackColor = Color.Transparent;
            pan1.Controls.Add(lbl3);

            Label lbl4 = new Label();
            lbl4.Location = new Point(610, y);
            lbl4.Size = new Size(145, 65);
            lbl4.Text = list[i + 4];
            lbl4.BackColor = Color.Transparent;
            pan1.Controls.Add(lbl4);

            Label lbl5 = new Label();
            lbl5.Location = new Point(760, y);
            lbl5.Size = new Size(145, 65);
            lbl5.Text = list[i + 5];
            lbl5.BackColor = Color.Transparent;
            pan1.Controls.Add(lbl5);

            Label lbl6 = new Label();
            lbl6.Location = new Point(910, y);
            lbl6.Size = new Size(145, 65);
            lbl6.Text = list[i + 6];
            lbl6.BackColor = Color.Transparent;
            pan1.Controls.Add(lbl6);

            Label lbl7 = new Label();
            lbl7.Location = new Point(1060, y);
            lbl7.Size = new Size(50, 65);
            lbl7.Text = list[i + 7];
            lbl7.BackColor = Color.Transparent;
            pan1.Controls.Add(lbl7);

            Label lbl8 = new Label();
            lbl8.Location = new Point(1120, y);
            lbl8.Size = new Size(50, 65);
            lbl8.Text = list[i + 8];
            lbl8.BackColor = Color.Transparent;
            pan1.Controls.Add(lbl8);

            Button btn = new Button();
            btn.Location = new Point(1250, y);
            btn.Size = new Size(109, 30);
            btn.TabIndex = 0;
            btn.Text = "Удалить";
            btn.UseVisualStyleBackColor = true;
            btn.Click += new EventHandler(delete);
            pan1.Controls.Add(btn);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSubWeek g = new AddSubWeek();
            g.ShowDialog();
        }
    }
}
