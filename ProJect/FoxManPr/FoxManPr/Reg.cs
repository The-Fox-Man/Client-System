﻿using System;
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


namespace FoxManPr
{
    public partial class Reg : Form
    {
        bool boob = false;
        public Reg()
        {
            InitializeComponent();

            List<string> list = NetCity.MySelect("SELECT name, id FROM sub");
            for (int i = 0; i < list.Count; i+=2)
            {
                txt2.Items.Add(list[i]);
                
            }
            for (int i = 0; i < list.Count; i+=1)
            {
                //jojo.Items.Add(list[i]); доделать добавление айди

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
                if (threee.Text == "Учитель" && boob && txt.Text == "9910801" && txt2.Text != "")
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO users(name, surn, type, pass, post, clas) VALUES('" + one.Text + "', '" + two.Text + "', '" + threee.Text + "', '" + four.Text + "', '" + five.Text + "', '" + six.Text + "')", Program.con);
                    DbDataReader read = cmd.ExecuteReader();
                    read.Close();
                    List<string> list = NetCity.MySelect("SELECT name, surn, type, pass, post, clas, id FROM users WHERE post = '" + five.Text + "' AND pass = '" + four.Text + "'");
                    MySqlCommand cm = new MySqlCommand("INSERT INTO teachers(name, surn, idtag, idsub) VALUES('" + one.Text + "', '" + two.Text + "', '" + list[6] + "', '" + txt2.Text + "')", Program.con);
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

        private void bub_Click(object sender, EventArgs e)
        {
            txt.Visible = true;
            l.Visible = true;
            a.Visible = true;
            txt2.Visible = true;
            boob = true;
        }

        private void jojo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
