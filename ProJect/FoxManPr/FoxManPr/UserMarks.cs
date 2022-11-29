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
        int y = 10;
        List<string> subject = NetCity.MySelect("SELECT name, surn, type, pass, post, clas, id FROM users WHERE surn = '" + NetCityTeachrers.UserData + "'");


        public UserMarks()
        {
            InitializeComponent();  

            label1.Text = "Поставить оценку ученику ";
            label2.Text = subject[0] + " " + subject[1];
            
            Data.Text = "Оценки пользователя " + subject[0] + " " + subject[1] + " " + subject[5];
            Type.Text = subject[2];


            List<string> us = NetCity.MySelect("SELECT mark, date FROM marks WHERE userid = '" + subject[6] + "' AND subid = '" + login.subidForm + "'");

            for (int i = 0; i < us.Count; i+=2)
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
                lbl1.Text = us[i+1];
                panel.Controls.Add(lbl1);

                y = y + 40;
            }
        }

        private void UserMarks_Load(object sender, EventArgs e)
        {

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

            if (marke.Text == "" || dat.Text == "" || day.Text == "" || numb.Text == "") { MessageBox.Show("Fuck you", "System"); }
            else
            {
                if (update.Count > 0)
                {
                    if (update.Count > 0 && numb.Text == update[2] && dat.Text == update[1])
                    {
                        NetCity.MyUpdate("UPDATE marks SET mark='" + marke.Text + "' WHERE date='" + dat.Text + "' AND col='" + numb.Text + "' AND userid='" + subject[6] + "' AND subid='" + login.subidForm + "'");
                        MessageBox.Show("go show");
                    }
                }
                else if (list[Convert.ToInt32(numb.Text) - 1] == list2[0])
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO marks(mark, date, col, userid, subid)" + "VALUES('" + marke.Text + "', '" + dat.Text + "', '" + numb.Text + "', '" + subject[6] + "', '" + login.subidForm + "')", Program.con);
                    DbDataReader read = cmd.ExecuteReader();
                    read.Close();
                    MessageBox.Show("YUP");
                    return;
                }
                else { MessageBox.Show("Fuck you", "System"); }
            }

        }
    }
}
