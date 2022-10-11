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

        public static List<string> MySelect(string cmd)
        {
            List<string> list = new List<string>();
            MySqlCommand cm = new MySqlCommand(cmd, Program.con);
         //    com = new MySqlCommand("SELECT clas, date, day, 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects", con);
            DbDataReader reader = cm.ExecuteReader();
            while(reader.Read())
            {
                for(int i = 0; i<reader.FieldCount;i++)
                {
                    list.Add(reader.GetValue(i).ToString());
                }
            }
            reader.Close();

            return list;
        }
        public NetCity()
        {
            InitializeComponent();
            user.Text = login.nameForm + login.surnForm;

            List<string> subject = MySelect("SELECT clas, date, day, 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects");//jhujyuj

            List<string> sub = new List<string>();

            for(int i = 0; i < tbl1.RowCount; i++)
            {
                sub.Add("Ро" + i);// do the mysql cnnect
            }
            for (int i = 0; i < tbl1.RowCount; i++)
            {
                Label lbl = new Label();
                lbl.Dock = DockStyle.Fill;
                lbl.Location = new Point(3, 0);
                lbl.Size = new Size(32, 32);
                lbl.Text = sub[i];
                tbl1.Controls.Add(lbl, 1, i);
            }
            //if(mon){lbl[0].Text = subject[0]} !!!!!!
                
                 
              /*  while (reader.Read())
                {
                /*for(int i=0; i<reader.FieldCount;i++)
                {
                    sub.Add(reader.GetValue(i).ToString());
                }
                    sub.Add(reader.GetValue(0).ToString());
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
                
              
         
               //   clase = parts[0];
                 // days = parts[2];

                if(clase == login.clasForm)
                {
                    if(days == "пн")
                    {
                        t1str1st1.Text = reader.GetValue(0).ToString();
                        t1str2st1.Text = reader.GetValue(1).ToString();
                        t1str3st1.Text = reader.GetValue(2).ToString();
                        t1str4st1.Text = reader.GetValue(3).ToString();
                        t1str5st1.Text = reader.GetValue(4).ToString();
                        t1str6st1.Text = reader.GetValue(5).ToString();
                        t1str7st1.Text = reader.GetValue(6).ToString();
                    }

                if(days == "вт")
                    {
                        tuesb1.Text = reader.GetValue(0).ToString();
                        tuesb2.Text = reader.GetValue(1).ToString();
                        tuesb3.Text = reader.GetValue(2).ToString();
                        tuesb4.Text = reader.GetValue(3).ToString();
                        tuesb5.Text = reader.GetValue(4).ToString();
                        tuesb6.Text = reader.GetValue(5).ToString();
                        tuesb7.Text = reader.GetValue(6).ToString();
                    }
                if(days == "ср")
                    {
                        wensb1.Text = reader.GetValue(0).ToString();
                        wensb2.Text = reader.GetValue(1).ToString();
                        wensb3.Text = reader.GetValue(2).ToString();
                        wensb4.Text = reader.GetValue(3).ToString();
                        wensb5.Text = reader.GetValue(4).ToString();
                        wensb6.Text = reader.GetValue(5).ToString();
                        wensb7.Text = reader.GetValue(6).ToString();
                    }
                if(days == "чт")
                    {
                        thrsb1.Text = reader.GetValue(0).ToString();
                        thrsb2.Text = reader.GetValue(1).ToString();
                        thrsb3.Text = reader.GetValue(2).ToString();
                        thrsb4.Text = reader.GetValue(3).ToString();
                        thrsb5.Text = reader.GetValue(4).ToString();
                        thrsb6.Text = reader.GetValue(5).ToString();
                        thrsb7.Text = reader.GetValue(6).ToString();
                    }
                if(days == "пт")
                    {
                        frisb1.Text = reader.GetValue(0).ToString();
                        frisb2.Text = reader.GetValue(1).ToString();
                        frisb3.Text = reader.GetValue(2).ToString();
                        frisb4.Text = reader.GetValue(3).ToString();
                        frisb5.Text = reader.GetValue(4).ToString();
                        frisb6.Text = reader.GetValue(5).ToString();
                        frisb7.Text = reader.GetValue(6).ToString();
                    }
                if(days == "сб")
                    {
                        satsb1.Text = reader.GetValue(0).ToString();
                        satsb2.Text = reader.GetValue(1).ToString();
                        satsb3.Text = reader.GetValue(2).ToString();
                        satsb4.Text = reader.GetValue(3).ToString();
                        satsb5.Text = reader.GetValue(4).ToString();
                        satsb6.Text = reader.GetValue(5).ToString();
                        satsb7.Text = reader.GetValue(6).ToString();
                    }
                }
            }
            reader.Close();
            con.Close();*/
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
