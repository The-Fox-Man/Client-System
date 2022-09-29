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
    public partial class NetCity : Form
    {
       /* public static string mon1sub;
        public static string mon2sub;
        public static string mon3sub;
        public static string mon4sub;
        public static string mon5sub;
        public static string mon6sub;
        public static string mon7sub;

        public static string tue1sub;
        public static string tue2sub;
        public static string tue3sub;
        public static string tue4sub;
        public static string tue5sub;
        public static string tue6sub;
        public static string tue7sub;

        public static string wen1sub;
        public static string wen2sub;
        public static string wen3sub;
        public static string wen4sub;
        public static string wen5sub;
        public static string wen6sub;
        public static string wen7sub;

        public static string thr1sub;
        public static string thr2sub;
        public static string thr3sub;
        public static string thr4sub;
        public static string thr5sub;
        public static string thr6sub;
        public static string thr7sub;

        public static string fri1sub;
        public static string fri2sub;
        public static string fri3sub;
        public static string fri4sub;
        public static string fri5sub;
        public static string fri6sub;
        public static string fri7sub;

        public static string sat1sub;
        public static string sat2sub;
        public static string sat3sub;
        public static string sat4sub;
        public static string sat5sub;
        public static string sat6sub;
        public static string sat7sub;*/

        public static string days;
        public static string clase;
        public NetCity()
        {
            InitializeComponent();
            user.Text = login.nameForm + login.surnForm;

            string[] lines = File.ReadAllLines("../../txt/subjects.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.None);
                /*   people peopl = new people(parts[0], parts[1], parts[2], parts[3], parts[4],
                                             parts[5], parts[6], parts[7], parts[8], parts[9]);*/
                clase = parts[0];
                days = parts[2];

                if(clase == login.clasForm)
                {
                    if(parts[2] == "пн")
                    {
                        t1str1st1.Text = parts[3];
                        t1str2st1.Text = parts[4];
                        t1str3st1.Text = parts[5];
                        t1str4st1.Text = parts[6];
                        t1str5st1.Text = parts[7];
                        t1str6st1.Text = parts[8];
                        t1str7st1.Text = parts[9];
                    }

                if(parts[2] == "вт")
                    {
                        tuesb1.Text = parts[3];
                        tuesb2.Text = parts[4];
                        tuesb3.Text = parts[5];
                        tuesb4.Text = parts[6];
                        tuesb5.Text = parts[7];
                        tuesb6.Text = parts[8];
                        tuesb7.Text = parts[9];
                    }
                if(parts[2] == "ср")
                    {
                        wensb1.Text = parts[3];
                        wensb2.Text = parts[4];
                        wensb3.Text = parts[5];
                        wensb4.Text = parts[6];
                        wensb5.Text = parts[7];
                        wensb6.Text = parts[8];
                        wensb7.Text = parts[9];
                    }
                if(parts[2] == "чт")
                    {
                        thrsb1.Text = parts[3];
                        thrsb2.Text = parts[4];
                        thrsb3.Text = parts[5];
                        thrsb4.Text = parts[6];
                        thrsb5.Text = parts[7];
                        thrsb6.Text = parts[8];
                        thrsb7.Text = parts[9];
                    }
                if(parts[2] == "пт")
                    {
                        frisb1.Text = parts[3];
                        frisb2.Text = parts[4];
                        frisb3.Text = parts[5];
                        frisb4.Text = parts[6];
                        frisb5.Text = parts[7];
                        frisb6.Text = parts[8];
                        frisb7.Text = parts[9];
                    }
                if(parts[2] == "сб")
                    {
                        satsb1.Text = parts[3];
                        satsb2.Text = parts[4];
                        satsb3.Text = parts[5];
                        satsb4.Text = parts[6];
                        satsb5.Text = parts[7];
                        satsb6.Text = parts[8];
                        satsb7.Text = parts[9];
                    }
                }
               // if(day = )
                /*
                if(login.clas == parts[0] && day.Text == parts[2])
                {
                  //  tbl1.t1str1str2 сделать не листом а переменнными и присваивать значение каждой ячейке
                }*/
            }
        }
        private void NetCity_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void tbl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
