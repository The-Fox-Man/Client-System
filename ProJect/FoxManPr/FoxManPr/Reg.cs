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
using System.Data.Common;
using System.Media;

namespace FoxManPr
{
    public partial class Reg : Form
    {
        bool boob = false;
        public static string reg = "";
        public Reg()
        {
            InitializeComponent();
            List<string> list  = NetCity.MySelect("SELECT name, id FROM sub");
            List<string> list2 = NetCity.MySelect("SELECT class, id FROM  classes");

            /*  for (int i = 1; i < list.Count; i+=2)
              {
                  txt2.Items.Add(list[i]);   
              }*/
            for (int i = 0; i < list.Count; i += 2)
            {
                txt2.Items.Add(list[i]);
            }
            for (int i = 0; i < list2.Count; i += 2)
            {
                six.Items.Add(list2[i]);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(one.Text == "" || two.Text == "" || five.Text == "" || four.Text == "" || threee.Text == "" || six.Text == "" && threee.Text != "Учитель")
            {
                MessageBox.Show("Поля не заполнены. Пожалуйста, завполните их все.", "System");
            }
            else
            {
                if (threee.Text == "Ученик")
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users(name, surn, type, pass, post, clas) VALUES('" + one.Text + "', '" + two.Text + "', '" + threee.Text + "', '" + four.Text + "', '" + five.Text + "', '" + six.Text + "')", Program.con);
                    DbDataReader read = cmd.ExecuteReader();
                    read.Close();
                    MessageBox.Show("ВЫ успешно зарегистрировались как ученик.", "System");   
                    Close();
                }
                if (threee.Text == "Учитель" && boob && txt.Text == "9910801" && txt2.Text != "")
                {

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users(name, surn, type, pass, post, clas) VALUES('" + one.Text + "', '" + two.Text + "', '" + threee.Text + "', '" + four.Text + "', '" + five.Text + "', '" + "" + "')", Program.con);
                    DbDataReader read = cmd.ExecuteReader();
                    read.Close();
                    List<string> list = NetCity.MySelect("SELECT name, surn, type, pass, post, clas, id FROM users WHERE post = '" + five.Text + "' AND pass = '" + four.Text + "'");

                    List<string> list2 = NetCity.MySelect("SELECT id FROM sub WHERE name = '" + txt2.Text + "'");
                    MySqlCommand cm = new MySqlCommand("INSERT INTO teachers(name, surn, idtag, idsub) VALUES('" + one.Text + "', '" + two.Text + "', '" + list[6] + "', '" + list2[0] + "') ", Program.con);
                    DbDataReader rea = cm.ExecuteReader();
                    rea.Close();
                    
                    
                    MessageBox.Show("ВЫ учпешно зарегистрировались как учитель", "System");
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

        private void bub_Click(object sender, EventArgs e)
        {
            txt.Visible = true;
            l.Visible = true;
            a.Visible = true;
            txt2.Visible = true;
            boob = true;
            six.Enabled = false;
        }

        private void jojo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt.Visible = false;
            l.Visible = false;
            a.Visible = false;
            txt2.Visible = false;
            boob = false;
            six.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer("../../Sounds/list.wav");
            s.Play();
            reg = "reg";
            Help d = new Help();
            d.ShowDialog();
        }
    }
}
