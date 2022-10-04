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
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace FoxManPr
{
    public partial class NetCity : Form
    {
        /*public static string mon1sub;
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
        public static string clase;
        public static string date;
        public static string days;
        public static string fst;
        public static string scd;
        public static string thd;
        public static string frt;
        public static string fif;
        public static string six;
        public static string svn;




        const string connect = "SslMode=none;Server=localhost;Database=sgosit;port=3306;Uid=root";
        public NetCity()
        {
            InitializeComponent();
            user.Text = login.nameForm + login.surnForm;

            /* string[] lines = File.ReadAllLines("../../txt/subjects.txt");

             foreach (string line in lines)
             {
                 string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.None);
                 /*   people peopl = new people(parts[0], parts[1], parts[2], parts[3], parts[4],
                                                  parts[5], parts[6], parts[7], parts[8], parts[9]);*/
                MySqlConnection con = new MySqlConnection(connect);
                con.Open();
                MySqlCommand com = new MySqlCommand("SELECT clas, date, day, 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects", con);
                DbDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    clase = reader.GetValue(0).ToString();
                    date = reader.GetValue(1).ToString();
                    days = reader.GetValue(2).ToString();
                    fst = reader.GetValue(3).ToString();
                    scd = reader.GetValue(4).ToString();
                    thd = reader.GetValue(5).ToString();
                    frt = reader.GetValue(6).ToString();
                    fif = reader.GetValue(7).ToString();
                    six = reader.GetValue(8).ToString();
                    svn = reader.GetValue(9).ToString();
                }
                reader.Close();
                con.Close();
               //   clase = parts[0];
                 // days = parts[2];

                if(clase == login.clasForm)
                {
                    if(days == "пн")
                    {
                        t1str1st1.Text = fst;
                        t1str2st1.Text = scd;
                        t1str3st1.Text = thd;
                        t1str4st1.Text = frt;
                        t1str5st1.Text = fif;
                        t1str6st1.Text = six;
                        t1str7st1.Text = svn;
                    }

                if(days == "вт")
                    {
                        tuesb1.Text = fst;
                        tuesb2.Text = scd;
                        tuesb3.Text = thd;
                        tuesb4.Text = frt;
                        tuesb5.Text = fif;
                        tuesb6.Text = six;
                        tuesb7.Text = svn;
                    }
                if(days == "ср")
                    {
                        wensb1.Text = fst;
                        wensb2.Text = scd;
                        wensb3.Text = thd;
                        wensb4.Text = frt;
                        wensb5.Text = fif;
                        wensb6.Text = six;
                        wensb7.Text = svn;
                    }
                if(days == "чт")
                    {
                        thrsb1.Text = fst;
                        thrsb2.Text = scd;
                        thrsb3.Text = thd;
                        thrsb4.Text = frt;
                        thrsb5.Text = fif;
                        thrsb6.Text = six;
                        thrsb7.Text = svn;
                    }
                if(days == "пт")
                    {
                        frisb1.Text = fst;
                        frisb2.Text = scd;
                        frisb3.Text = thd;
                        frisb4.Text = frt;
                        frisb5.Text = fif;
                        frisb6.Text = six;
                        frisb7.Text = svn;
                    }
                if(days == "сб")
                    {
                        satsb1.Text = fst;
                        satsb2.Text = scd;
                        satsb3.Text = thd;
                        satsb4.Text = frt;
                        satsb5.Text = fif;
                        satsb6.Text = six;
                        satsb7.Text = svn;
                    }
                }
               // if(day = )
                /*
                if(login.clas == parts[0] && day.Text == parts[2])
                {
                  //  tbl1.t1str1str2 сделать не листом а переменнными и присваивать значение каждой ячейке
                }*/
            //}
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
