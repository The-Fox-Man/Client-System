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
        public UserMarks()
        {
            InitializeComponent();
            List<string> subject = NetCity.MySelect("SELECT name, surn, type, pass, post, clas, id FROM users WHERE surn = '" + NetCityTeachrers.UserData + "'");

            Data.Text = "Оценки пользователя " + subject[0] + " " + subject[1] + " " + subject[5];
            Type.Text = subject[2];


            List<string> us = NetCity.MySelect("SELECT mark, date FROM marks WHERE userid = '" + subject[6] + "'"); // добавь вхере сабайди = subidForm

        }

        private void UserMarks_Load(object sender, EventArgs e)
        {

        }
    }
}
