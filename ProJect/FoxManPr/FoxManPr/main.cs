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
using System.Media;
namespace FoxManPr
{
    public struct people
    {
        public string cl;
        public string numb;
        public string day;
        public string one;
        public string two;
        public string three;
        public string four;
        public string five;
        public string six;
        public string seven;
        public people(string _cl, string _numb, string _day, string _1les, string _2les,
                      string _3les, string _4les, string _5les, string _6les, string _7les)
        {
            cl = _cl;
            numb = _numb;
            day = _day;
            one = _1les;
            two = _2les;
            three = _3les;
            four = _4les;
            five = _5les;
            six = _6les;
            seven = _7les;
        }
    }

    public partial class main : Form
    {
        public static List<people> human = new List<people>();
        public static bool lol = false;
        public main()
        {
            InitializeComponent();
            if (lol)
            {
                admin.Enabled = true;
                admin.Visible = true;
            }
            else { admin.Enabled = false; admin.Visible = false; }
            // string[] lines = File.ReadAllLines("../../txt/subjects.txt");

            /*  foreach (string line in lines)
             {
                string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.None);
                 people peopl = new people(parts[0], parts[1], parts[2]);
                 human.Add(peopl)
             };*/
            //        foreach (people p in human)
            //      {
            //        p.lbl.Location = new Point();
            //  } //я сделал с людями это а надо делать с предметами и распсисанием
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (login.nameForm == "")
            {
                login t = new login();
                t.ShowDialog();
                button5.Text = "Войти";
            }
            else
            {
                login.nameForm = "";
                login.surnForm = "";
                login.postForm = "";
                login.typeForm = "";
                button5.Text = "Выйти";
            }
            if (login.nameForm == "")
            {
                loginlbl.Text = "Вы не вошли.";
                button5.Text = "Войти";
            }
            else { loginlbl.Text = login.nameForm + " " + login.surnForm;   button5.Text = "Выйти";}
            if (login.typeForm == "Администратор")//систему рангов и дз
            {
                admin.Enabled = true;
                admin.Visible = true;
            }
            else { admin.Enabled = false;  admin.Visible = false;}
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reg t = new Reg();
            t.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void filtr_Click(object sender, EventArgs e)
        {

            /*if (pan.Size.Height > 100)
           {
               pan.Size = new Size(pan.Size.Width, filtr.Location.Y + filtr.Size.Height);
           }
           else if (pan.Size.Height < 50)
           {
             pan.Size = new Size(pan.Size.Width, 140);
           }*/
            if (login.typeForm == "Ученик")
            {
                SoundPlayer s = new SoundPlayer("../../Sounds/list.wav");
                s.Play();
                NetCity wha = new NetCity();
                wha.ShowDialog();
                
            }
            else if (login.typeForm == "Учитель")
            {
                SoundPlayer s = new SoundPlayer("../../Sounds/list.wav");
                s.Play();
                NetCityTeachrers wha = new NetCityTeachrers();
                wha.ShowDialog();
            }
            else if(login.typeForm == "")
            {
                SoundPlayer s = new SoundPlayer("../../Sounds/msg.wav");
                s.Play();
                MessageBox.Show("Сначала войдите.", "System");
            }
            else if (login.typeForm == "Администратор")
            {
                SoundPlayer s = new SoundPlayer("../../Sounds/msg.wav");
                s.Play();
                MessageBox.Show("ВЫ администратор, вам сюда не нужно.", "System");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (login.typeForm != "")
            {
                SoundPlayer s = new SoundPlayer("../../Sounds/list.wav");
                s.Play();
                Help a = new Help();
                a.ShowDialog();
            }
            else if (login.typeForm == "")
            {
                SoundPlayer s = new SoundPlayer("../../Sounds/msg.wav");
                s.Play();
                MessageBox.Show("Сначала войдите.", "System");
            }
        }

        private void teachers_Click(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer("../../Sounds/list.wav");
            s.Play();
            Teachers t = new Teachers();
             t.ShowDialog();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void admin_Click(object sender, EventArgs e)
        {
//            if ()
  //          {
                Admin u = new Admin();
                u.ShowDialog();
    //        }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer("../../Sounds/exit.wav");
            s.Play();
            Close(); 
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (login.nameForm == "")
            {
                SoundPlayer s = new SoundPlayer("../../Sounds/msg.wav"); s.Play(); MessageBox.Show("Сначала войдите.", "System"); }
            else { UserCabin n = new UserCabin(); n.ShowDialog(); }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
