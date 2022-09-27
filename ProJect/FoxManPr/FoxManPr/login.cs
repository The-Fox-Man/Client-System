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

namespace FoxManPr
{
    public partial class login : Form
    {
        public static string name = "";
        public static string surn = "";
        public static string type = ""; 
        public static string pass = "";
        public static string post = "";
        public static string clas = "";


        public static string nameForm = "";
        public static string surnForm = "";
        public static string postForm = "";
        public static string typeForm = "";
        public static string clasForm = "";
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reg t = new Reg();
            t.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] li = File.ReadAllLines("../../txt/users.txt");
            foreach (string objects in li)
            {
                string[] word = objects.Split(new string[] { ", " }, StringSplitOptions.None);
                name = word[0];
                surn = word[1];
                type = word[2];
                pass = word[3];
                post = word[4];
                clas = word[5];

                if (t1.Text == name && t2.Text == pass || t1.Text == post && t2.Text == pass)
                {
                    nameForm = name;
                    surnForm = surn;
                    postForm = post;
                    typeForm = type;
                    clasForm = clas;
                    MessageBox.Show("ВЫ успешно вошли!", "Программа");
                }
                else { MessageBox.Show("Неверный адрес почты или пароль. Или поля пустые. Внимательно посмотрите, не содержат ли поля лишних пробелов или символов. Либо ВЫ не зарегестрированы.", "Программа"); }
            }

            Close();
        }
    }
}
