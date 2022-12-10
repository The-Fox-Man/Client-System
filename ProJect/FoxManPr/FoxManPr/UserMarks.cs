using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace FoxManPr
{
    public partial class UserMarks : Form
    {

        List<string> subject = NetCity.MySelect("SELECT name, surn, type, pass, post, clas, id FROM users WHERE id = '" + NetCityTeachrers.UserData + "'");
        public static string currentclas;
        public UserMarks()
        {
            InitializeComponent();
        }

        private void UserMarks_Load(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            label1.Text = "Поставить оценку ученику ";
            label2.Text = subject[0] + " " + subject[1];

            Data.Text = "Оценки пользователя " + subject[0] + " " + subject[1] + " " + subject[5];
            Type.Text = subject[2];


            List<string> us = NetCity.MySelect("SELECT mark, date, col FROM marks WHERE userid = '" + subject[6] + "' AND subid = '" + login.subidForm + "'");
            int y = 10;
            for (int i = 0; i < us.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(140, y);
                lbl.Font = new Font("Comic Sans MS", 13);
                lbl.Size = new Size(50, 30);
                lbl.Text = us[i];
                panel.Controls.Add(lbl);

                Label lbl1 = new Label();
                lbl1.Location = new Point(20, y);
                lbl1.Font = new Font("Comic Sans MS", 13);
                lbl1.Size = new Size(150, 30);
                lbl1.Text = us[i + 1];
                panel.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Location = new Point(200, y);
                lbl2.Font = new Font("Comic Sans MS", 13);
                lbl2.Size = new Size(50, 30);
                lbl2.Text = us[i + 2];
                panel.Controls.Add(lbl2);

                Button btn = new Button();
                btn.Location = new Point(260, y);
                btn.Size = new Size(100, 30);
                btn.TabIndex = 0;
                btn.Text = "Удалить";
                btn.UseVisualStyleBackColor = true;
                btn.Click += new EventHandler(delete);
                panel.Controls.Add(btn);

                Button btn1 = new Button();
                btn1.Location = new Point(370, y);
                btn1.Size = new Size(100, 30);
                btn1.TabIndex = 0;
                btn1.Text = "Изменить";
                btn1.UseVisualStyleBackColor = true;
                btn1.Click += new EventHandler(change);
                panel.Controls.Add(btn1);

                y = y + 40;
            }
        }
        private void delete(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;
            foreach (Control control in panel.Controls)
            {
                foreach (Control control2 in panel.Controls)
                {
                    if (control.Location == new Point(20, y + AutoScrollPosition.Y) && control2.Location == new Point(200, y + AutoScrollPosition.Y))
                    {
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM marks WHERE date = '" + control.Text + "' AND col= '" + control2.Text + "'AND userid='" + subject[6] + "' AND subid='" + login.subidForm + "'", Program.con);
                        DbDataReader read = cmd.ExecuteReader();
                        read.Close();
                        MessageBox.Show("Оценка удалена.", "System");
                        UserMarks_Load(sender, e);
                        return;
                    }

                }
            }
        }
        private void change(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;
            foreach (Control control in panel.Controls)
            {
                foreach (Control control2 in panel.Controls)
                {
                    if (control.Location == new Point(20, y + AutoScrollPosition.Y) && control2.Location == new Point(200, y + AutoScrollPosition.Y))
                    {
                        NetCity.MyUpdate("UPDATE marks SET mark='" + cm.Text + "' WHERE date='" + control.Text + "' AND col='" + control2.Text + "' AND userid='" + subject[6] + "' AND subid='" + login.subidForm + "'");
                        MessageBox.Show("Оценнка изменена.", "System");
                        UserMarks_Load(sender, e);
                    }

                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = NetCity.MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + subject[5] + "' AND day = '" + day.Text + "'");
            List<string> list2 = NetCity.MySelect("SELECT name FROM sub WHERE id = '" + login.subidForm + "'");
            List<string> update = NetCity.MySelect("SELECT mark, date, col FROM marks WHERE userid = '" + subject[6] + "' AND subid = '" + login.subidForm + "' AND col = '" + numb.Text + "' AND date = '" + dat.Text + "'");

            if (marke.Text == "" || dat.Text == "" || day.Text == "" || numb.Text == "") { MessageBox.Show("Заполните все поля.", "System"); }
            else
            {
                /*      if (update.Count > 0)
                      {
                          if (update.Count > 0 && numb.Text == update[2] && dat.Text == update[1])
                          {
                              NetCity.MyUpdate("UPDATE marks SET mark='" + marke.Text + "' WHERE date='" + dat.Text + "' AND col='" + numb.Text + "' AND userid='" + subject[6] + "' AND subid='" + login.subidForm + "'");
                              MessageBox.Show("go show");
                          }
                      }*/
                if (list.Count > 0 && update.Count < 1 && list[Convert.ToInt32(numb.Text) - 1] == list2[0])
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO marks(mark, date, col, userid, subid)" + "VALUES('" + marke.Text + "', '" + dat.Text + "', '" + numb.Text + "', '" + subject[6] + "', '" + login.subidForm + "')", Program.con);
                    DbDataReader read = cmd.ExecuteReader();
                    read.Close();
                    MessageBox.Show("Оценка поставлена.", "System");
                    UserMarks_Load(sender, e);
                    return;
                }
                else { MessageBox.Show("Извините, вы поставили оценку либо не в ту строку(а может не в правильный день недели), либо на это число, на этот день, в эту строку, где уже есть оценка.", "System"); }
            }

        }

        private void check_Click(object sender, EventArgs e)
        {
            currentclas = subject[5];
            CheckTimeSheet j = new CheckTimeSheet();
            j.ShowDialog();
        }
    }
}

