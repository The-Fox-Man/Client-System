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
    public struct people
    {
        public string name;
        public string surname;
        public string type;
        public Label lbl;

        public people(string _name, string _surname, string _type)
        {
            name = _name;
            surname = _surname;
            type = _type;
            lbl = new Label();
        }
    }

    public partial class main : Form
    {
        public static List<people> human = new List<people>();
        public main()
        {
            InitializeComponent();

            string[] lines = File.ReadAllLines("../../txt/users.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.None);
                people peopl = new people(parts[0], parts[1], parts[2]);
                human.Add(peopl);
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
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
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reg t = new Reg();
            t.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Base t = new Base();
            t.ShowDialog();
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
                NetCity wha = new NetCity();
                wha.ShowDialog();
                
            }
            else if (login.typeForm == "Учитель")
            {
                NetCityTeachrers wha = new NetCityTeachrers();
                wha.ShowDialog();
            }
            else if(login.typeForm == "")
            {
                MessageBox.Show("Сначала войдите.", "Программа");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void teachers_Click(object sender, EventArgs e)
        {
             Teachers t = new Teachers();
             t.ShowDialog();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
