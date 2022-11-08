using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;

namespace FoxManPr
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(one.Text == "" || two.Text == "" || five.Text == "" || four.Text == "" || threee.Text == "" || six.Text == "")
            {
                MessageBox.Show("Fuck you");
            }
            else
            {
                if (threee.Text == "Ученик")
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users(name, surn, type, pass, post, clas) VALUES('" + one.Text + "', '" + two.Text + "', '" + threee.Text + "', '" + four.Text + "', '" + five.Text + "', '" + six.Text + "')", Program.con);
                    DbDataReader read = cmd.ExecuteReader();
                    read.Close();
                    MessageBox.Show("Yeeeз");   
                    Close();
                }
                if (threee.Text == "Учитель")
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users(name, surn, type, pass, post, clas) VALUES('" + one.Text + "', '" + two.Text + "', '" + threee.Text + "', '" + four.Text + "', '" + five.Text + "', '" + six.Text + "')", Program.con);
                    DbDataReader read = cmd.ExecuteReader();
                    read.Close();
                    MySqlCommand cm = new MySqlCommand("INSERT INTO teachers(name, surn) VALUES('" + one.Text + "', '" + two.Text + "')", Program.con);
                    DbDataReader rea = cm.ExecuteReader();
                    rea.Close();
                    MessageBox.Show("Yeee");
                    Close();

                }

            }
        }
        private void five_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
