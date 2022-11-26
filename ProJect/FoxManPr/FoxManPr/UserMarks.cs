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
    public partial class UserMarks : Form
    {
        int y = 10;
        public UserMarks()
        {
            InitializeComponent();
            List<string> subject = NetCity.MySelect("SELECT name, surn, type, pass, post, clas, id FROM users WHERE surn = '" + NetCityTeachrers.UserData + "'");

            Data.Text = "Оценки пользователя " + subject[0] + " " + subject[1] + " " + subject[5];
            Type.Text = subject[2];


            List<string> us = NetCity.MySelect("SELECT mark, date FROM marks WHERE userid = '" + subject[6] + "' AND subid = '" + login.subidForm + "'"); // добавь вхере сабайди = subidForm

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
    }
}
