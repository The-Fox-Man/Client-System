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

        List<string> subject = MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + login.clasForm + "' AND day = '" + "пн" + "'");
        List<string> subject2 = MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + login.clasForm + "' AND day = '" + "вт" + "'");
        List<string> subject3 = MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + login.clasForm + "' AND day = '" + "ср" + "'");
        List<string> subject4 = MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + login.clasForm + "' AND day = '" + "чт" + "'");
        List<string> subject5 = MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + login.clasForm + "' AND day = '" + "пт" + "'");
        List<string> subject6 = MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + login.clasForm + "' AND day = '" + "сб" + "'");


        List<string> mark = MySelect("SELECT mark, date, col, subid FROM marks WHERE userid = '" + login.idForm + "'");
        List<string> ht = MySelect("SELECT text, date, col, subid FROM hometask WHERE class = '" + login.clasForm + "'");

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


        Label lbl1;

        int dayS = 29;
        int monS = 08;
        int yeaS = 2022;

        int dayE = 03;
        int monE = 09;
        int yeaE = 2022;

        //  int d = 0;

        //nst string connect = "SslMode=none;Server=localhost;Database=sgosit;port=3306;Uid=root";

        public static List<string> MySelect(string cmd)
        {
            List<string> list = new List<string>();
            MySqlCommand cm = new MySqlCommand(cmd, Program.con);
            DbDataReader reader = cm.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    list.Add(reader.GetValue(i).ToString());
                }
            }
            reader.Close();

            return list;
        }
        public static void MyUpdate(string cmdText)
        {
            MySqlCommand cmd = new MySqlCommand(cmdText, Program.con);
            DbDataReader read = cmd.ExecuteReader();
            read.Close();
        }
        private void makeMeSick(List<string> subject, int i, TableLayoutPanel tbl)
        {

            Label lbl = new Label();
            lbl.Dock = DockStyle.Fill;
            lbl.Location = new Point(3, 0);
            lbl.Size = new Size(32, 32);
            lbl.Text = subject[i];
            tbl.Controls.Add(lbl, 1, i);

            Label lbl1 = new Label();
            lbl1.Dock = DockStyle.Fill;
            lbl1.Location = new Point(3, 0);
            lbl1.Size = new Size(32, 32);
            lbl1.Text = Convert.ToString(i + 1);
            tbl.Controls.Add(lbl1, 0, i);
        }
        private void giveMeAReason(List<string> mark, int i, TableLayoutPanel tbl, Label date)
        {
            if (mark[i + 1] == date.Text)
            {
                lbl1 = new Label();
                lbl1.Dock = DockStyle.Fill;
                lbl1.Font = new Font("Segoe Print", 13);
                lbl1.Location = new Point(3, 0);
                lbl1.Size = new Size(32, 32);
                lbl1.Text = mark[i];
                if (lbl1.Text == "3" || lbl1.Text == "4" || lbl1.Text == "5") { lbl1.ForeColor = Color.Blue; }
                else if (lbl1.Text == "2") { lbl1.ForeColor = Color.Red; }
                tbl.Controls.Add(lbl1, 3, Convert.ToInt32(mark[i + 2]) - 1);
            }
        }
        private void CruelWorld(List<string> ht, int i, TableLayoutPanel tbl, Label date)
        {
            if (ht[i + 1] == date.Text)
            {
                lbl1 = new Label();
                lbl1.Dock = DockStyle.Fill;
                lbl1.Location = new Point(3, 0);
                lbl1.Size = new Size(200, 32);
                lbl1.Text = ht[i];
                tbl.Controls.Add(lbl1, 2, Convert.ToInt32(ht[i + 2]) - 1);
            }
        }
        int mon = 8;
        int year = 2022;

        private void StopIt(int i, int k, Label one)
        {
            mon = monS;
            year = yeaS;
            if (monS == 9 && i > 30) { mon = 10; one.Text = i - 30 + "." + mon + "." + year; }
            else if (monS == 10 && i > 31) { mon = 11; one.Text = i - 31 + "." + mon + "." + year; }
            else if (monS == 11 && i > 30) { mon = 12; one.Text = i - 30 + "." + mon + "." + year; }
            else if (monS == 12 && i > 31) { mon = 1; year = year + 1; one.Text = i - 31 + "." + mon + "." + year; }
            else if (monS == 1 && i > 31) { mon = 2; one.Text = i - 31 + "." + mon + "." + year; }
            else if (monS == 2 && i > 28)
            {
                if(yeaE == 2020 && i == 29 || yeaE == 2024 && i == 29 || yeaE == 2028 && i == 29 || yeaE == 2032 && i == 29 || yeaE == 2036 && i == 29
                    || yeaE == 2040 && i == 29 || yeaE == 2044 && i == 29 || yeaE == 2048 && i == 29 || yeaE == 2052 && i == 29 || yeaE == 2056 && i == 29 || yeaE == 2060 && i == 29)
                { mon = 3; one.Text = 29 + "." + mon + "." + year; }
                else if (yeaE == 2020 || yeaE == 2024 || yeaE == 2028 || yeaE == 2032 || yeaE == 2036 || yeaE == 2040 || yeaE == 2044 || yeaE == 2048 || yeaE == 2052 || yeaE == 2056 || yeaE == 2060)
                { mon = 3; one.Text = i - 29 + "." + mon + "." + year; }
                else
                { mon = 3; one.Text = i - 28 + "." + mon + "." + year; }
            }
            else if (monS == 3 && i > 31) { mon = 4; one.Text = i - 31 + "." + mon + "." + year; }
            else if (monS == 4 && i > 30) { mon = 5; one.Text = i - 30 + "." + mon + "." + year; }
            else if (monS == 5 && i > 31) { mon = 6; one.Text = i - 31 + "." + mon + "." + year; }
            else if (monS == 6 && i > 30) { mon = 7; one.Text = i - 30 + "." + mon + "." + year; }
            else if (monS == 7 && i > 31) { mon = 8; one.Text = i - 31 + "." + mon + "." + year; }
            else if (monS == 8 && i > 31) { mon = 9; one.Text = i - 31 + "." + mon + "." + year; }

            else { one.Text = i + "." + mon + "." + year; }
        }

        public NetCity()
        {
            InitializeComponent();
            user.Text = login.nameForm + " " + login.surnForm;
            number.Controls.Clear();

            //  List<string> subject = MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects");
            //  List<string> date = MySelect("SELECT date, day");
            //  List<string> sub = MySelect("SELECT name FROM sub WHERE id = '"+ mark[2] +"'");
            int ant = dayS + 1;  int ant2 = dayS + 2; int ant3 = dayS + 3; int ant4 = dayS + 4;

            number.Text = dayS + "." + monS + "." + yeaS + " - " + dayE + "." + monE + "." + yeaE;
            date1.Text = dayS  + "." + monS + "." + yeaS;
            StopIt(ant, 1, date2);
            StopIt(ant2, 2, date3);
            StopIt(ant3, 3, date4);
            StopIt(ant4, 4, date5);
            date6.Text = dayE + "." + monE + "." + yeaE;
            for (int i = 0; i < subject.Count; i++)
            {
                makeMeSick(subject, i, tbl1);
            }
            for (int i = 0; i < mark.Count; i+=4)
            {
                giveMeAReason(mark, i, tbl1, date1);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tbl1, date1);
            }
            //----------------------------------------------------
            for (int i = 0; i < subject2.Count; i++)
            {
                makeMeSick(subject2, i, tbl2);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tbl2, date2);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tbl2, date2);
            }
            //---------------------------------------------------
            for (int i = 0; i < subject3.Count; i++)
            {
                makeMeSick(subject3, i, tbl3);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tbl3, date3);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tbl3, date3);
            }
            //---------------------------------------------------
            for (int i = 0; i < subject4.Count; i++)
            {
                makeMeSick(subject4, i, tbl4);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tbl4, date4);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tbl4, date4);
            }
            //--------------------------------------------------
            for (int i = 0; i < subject5.Count; i++)
            {
                makeMeSick(subject5, i, tbl5);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tbl5, date5);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tbl5, date5);
            }
            //-------------------------------------------------
            for (int i = 0; i < subject6.Count; i++)
            {
                makeMeSick(subject6, i, tb6);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tb6, date6);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tb6, date6);
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

        private void tuesb1_Click(object sender, EventArgs e)
        {

        }

        private void tbl2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void next_Click(object sender, EventArgs e)
        {
            tbl1.Controls.Clear();
            tbl2.Controls.Clear();
            tbl3.Controls.Clear();
            tbl4.Controls.Clear();
            tbl5.Controls.Clear();
            tb6.Controls.Clear();

            dayS = dayS + 7;
            dayE = dayE + 7;


            if (monE == 9 && dayE > 30) { dayE = dayE - 30; monE = 10; }
            if (monE == 9 && dayE == 0) { dayE = 1; }
            if (monS == 9 && dayS > 30) { dayS = dayS - 30; monS = 10; }
            if (monS == 9 && dayS == 0) { dayS = 1; }

            if (monE == 10 && dayE > 31) { dayE = dayE - 31; monE = 11; }
            if (monS == 10 && dayS > 31) { dayS = dayS - 31; monS = 11; }

            if (monE == 11 && dayE > 30) { dayE = dayE - 30; monE = 12; }
            if (monS == 11 && dayS > 30) { dayS = dayS - 30; monS = 12; }

            if (monE == 12 && dayE > 31) { dayE = dayE - 31; monE = 1; yeaE = yeaE + 1; }
            if (monS == 12 && dayS > 31) { dayS = dayS - 31; monS = 1; yeaS = yeaS + 1; }

            if (monE == 1 && dayE > 31) { dayE = dayE - 31; monE = 2; }
            if (monS == 1 && dayS > 31) { dayS = dayS - 31; monS = 2; }

            if (monE == 2 && dayE > 28)
            {
                if (yeaE == 2020 || yeaE == 2024 || yeaE == 2028 || yeaE == 2032 || yeaE == 2036 || yeaE == 2040 || yeaE == 2044 || yeaE == 2048 || yeaE == 2052 || yeaE == 2056 || yeaE == 2060)
                { dayE = dayE - 29; monE = 3; }
                else
                { dayE = dayE - 28; monE = 3; }
            }
            if (monE == 2 && dayE == 0)
            {
                if (yeaE == 2020 || yeaE == 2024 || yeaE == 2028 || yeaE == 2032 || yeaE == 2036 || yeaE == 2040 || yeaE == 2044 || yeaE == 2048 || yeaE == 2052 || yeaE == 2056 || yeaE == 2060)
                { dayE = 1; }
                else
                { dayE = 1; }
            }
            if (monS == 2 && dayS > 28)
            { 
                if (yeaE == 2020 || yeaE == 2024 || yeaE == 2028 || yeaE == 2032 || yeaE == 2036 || yeaE == 2040 || yeaE == 2044 || yeaE == 2048 || yeaE == 2052 || yeaE == 2056 || yeaE == 2060)
                { dayS = dayS - 29; monS = 3; }
                else
                { dayS = dayS - 28; monS = 3; }
            }
            if (monS == 2 && dayS == 0)
            {
                if (yeaE == 2020 || yeaE == 2024 || yeaE == 2028 || yeaE == 2032 || yeaE == 2036 || yeaE == 2040 || yeaE == 2044 || yeaE == 2048 || yeaE == 2052 || yeaE == 2056 || yeaE == 2060)
                { dayS = 1; }
                else
                { dayS = 1; }
            }


            if (monE == 3 && dayE > 31) { dayE = dayE - 31; monE = 4; }
            if (monE == 3 && dayE < 1) { dayE = 1; }
            if (monS == 3 && dayS > 31) { dayS = dayS - 31; monS = 4; }
            if (monS == 3 && dayS < 1) { dayS = 1; }


            if (monE == 4 && dayE > 30) { dayE = dayE - 30; monE = 5; }
            if (monS == 4 && dayS > 30) { dayS = dayS - 30; monS = 5; }

            if (monE == 5 && dayE > 31) { dayE = dayE - 31; monE = 6; }
            if (monS == 5 && dayS > 31) { dayS = dayS - 31; monS = 6; }

            if (monE == 6 && dayE > 30) { dayE = dayE - 30; monE = 7; }
            if (monS == 6 && dayS > 30) { dayS = dayS - 30; monS = 7; }

            if (monE == 7 && dayE > 31) { dayE = dayE - 31; monE = 8; }
            if (monS == 7 && dayS > 31) { dayS = dayS - 31; monS = 8; }

            if (monE == 8 && dayE > 31) { dayE = dayE - 31; monE = 9; }
            if (monS == 8 && dayS > 31) { dayS = dayS - 31; monS = 9; }

            int ant = dayS + 1;
            int ant2 = dayS + 2;
            int ant3 = dayS + 3;
            int ant4 = dayS + 4;

            number.Text = dayS + "." + monS + "." + yeaS + " - " + dayE + "." + monE + "." + yeaE;
            date1.Text = dayS + "." + monS + "." + yeaS;
            StopIt(ant, 1, date2);
            StopIt(ant2, 2, date3);
            StopIt(ant3, 3, date4);
            StopIt(ant4, 4, date5);
            date6.Text = dayE + "." + monE + "." + yeaE;
            number.Controls.Clear();
            for (int i = 0; i < subject.Count; i++)
            {
                makeMeSick(subject, i, tbl1);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tbl1, date1);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tbl1, date1);
            }
            //----------------------------------------------------
            for (int i = 0; i < subject2.Count; i++)
            {
                makeMeSick(subject2, i, tbl2);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tbl2, date2);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tbl2, date2);
            }
            //---------------------------------------------------
            for (int i = 0; i < subject3.Count; i++)
            {
                makeMeSick(subject3, i, tbl3);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tbl3, date3);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tbl3, date3);
            }
            //---------------------------------------------------
            for (int i = 0; i < subject4.Count; i++)
            {
                makeMeSick(subject4, i, tbl4);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tbl4, date4);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tbl4, date4);
            }
            //--------------------------------------------------
            for (int i = 0; i < subject5.Count; i++)
            {
                makeMeSick(subject5, i, tbl5);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tbl5, date5);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tbl5, date5);
            }
            //-------------------------------------------------
            for (int i = 0; i < subject6.Count; i++)
            {
                makeMeSick(subject6, i, tb6);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tb6, date6);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tb6, date6);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl1.Controls.Clear();
            tbl2.Controls.Clear();
            tbl3.Controls.Clear();
            tbl4.Controls.Clear();
            tbl5.Controls.Clear();
            tb6.Controls.Clear();

            dayS = dayS - 7;
            dayE = dayE - 7;
            

            if (monE == 10 && dayE < 0) { dayE = dayE + 30; monE = 9; }
            if (monE == 10 && dayE == 0) { dayE = 30; monE = monE - 1; }
            if (monS == 10 && dayS < 0) { dayS = dayS + 30; monS = 9; }
            if (monS == 10 && dayS == 0) { dayS = 30; monS = monS - 1; }

            if (monE == 11 && dayE < 0) { dayE = dayE + 31; monE = 10; }
            if (monE == 11 && dayE == 0) { dayE = 31; monE = monE - 1; }
            if (monS == 11 && dayS < 0) { dayS = dayS + 31; monS = 10; }
            if (monS == 11 && dayS == 0) { dayS = 31; monS = monS - 1; }

            if (monE == 12 && dayE < 0) { dayE = dayE + 30; monE = 11; }
            if (monE == 12 && dayE == 0) { dayE = 30; monE = monE - 1; }
            if (monS == 12 && dayS < 0) { dayS = dayS + 30; monS = 11; }
            if (monS == 12 && dayS == 0) { dayS = 30; monS = monS - 1; }

            if (monE == 1 && dayE < 0) { dayE = dayE + 31; monE = 12; yeaE = yeaE - 1; }
            if (monE == 1 && dayE == 0) { dayE = 31; monE = monE + 11; yeaE = yeaE - 1; }
            if (monS == 1 && dayS < 0) { dayS = dayS + 31; monS = 12; yeaS = yeaS - 1; }
            if (monS == 1 && dayS == 0) { dayS = 31; monS = monS - 1; }

            if (monE == 2 && dayE < 0) { dayE = dayE + 31; monE = 1; }
            if (monE == 2 && dayE == 0) { dayE = 31; monE = monE - 1; }
            if (monS == 2 && dayS < 0) { dayS = dayS + 31; monS = 1; }

            if (monE == 3 && dayE < 0)
            {
                if (yeaE == 2020 || yeaE == 2024 || yeaE == 2028 || yeaE == 2032 || yeaE == 2036 || yeaE == 2040 || yeaE == 2044 || yeaE == 2048 || yeaE == 2052 || yeaE == 2056 || yeaE == 2060)
                { dayE = dayE + 29; monE = 2; }
                else
                { dayE = dayE + 28; monE = 2; }
            }
            if (monE == 3 && dayE == 0)
            {
                if (yeaE == 2020 || yeaE == 2024 || yeaE == 2028 || yeaE == 2032 || yeaE == 2036 || yeaE == 2040 || yeaE == 2044 || yeaE == 2048 || yeaE == 2052 || yeaE == 2056 || yeaE == 2060)
                { dayE = 29; monE = monE - 1; }
                else
                { dayE = 28; monE = monE - 1; } 
            }
            if (monS == 3 && dayS < 0)
            {
                if (yeaE == 2020 || yeaE == 2024 || yeaE == 2028 || yeaE == 2032 || yeaE == 2036 || yeaE == 2040 || yeaE == 2044 || yeaE == 2048 || yeaE == 2052 || yeaE == 2056 || yeaE == 2060)
                { dayS = dayS + 29; monS = 2; }
                else
                { dayS = dayS + 28; monS = 2; }
            }
            if (monS == 2 && dayS == 23)
            {
                 dayS = dayS - 1; 
            }

            if (monE == 4 && dayE < 0) { dayE = dayE + 31; monE = 3; }
            if (monE == 4 && dayE == 0) { dayE = 31; monE = monE - 1; }
            if (monS == 4 && dayS < 0) { dayS = dayS + 31; monS = 3; }
            if (monS == 4 && dayS == 0) { dayS = 31; monS = monS - 1; }

            if (monE == 5 && dayE < 0) { dayE = dayE + 30; monE = 4; }
            if (monE == 5 && dayE == 0) { dayE = 30; monE = monE - 1; }
            if (monS == 5 && dayS < 0) { dayS = dayS + 30; monS = 4; }
            if (monS == 5 && dayS == 0) { dayS = 30; monS = monS - 1; }

            if (monE == 6 && dayE < 0) { dayE = dayE + 31; monE = 5; }
            if (monE == 6 && dayE == 0) { dayE = 31; monE = monE - 1; }
            if (monS == 6 && dayS < 0) { dayS = dayS + 31; monS = 5; }
            if (monS == 6 && dayS == 0) { dayS = 31; monS = monS - 1; }

            if (monE == 7 && dayE < 0) { dayE = dayE + 30; monE = 6; }
            if (monE == 7 && dayE == 0) { dayE = 30; monE = monE - 1; }
            if (monS == 7 && dayS < 0) { dayS = dayS + 30; monS = 6; }
            if (monS == 7 && dayS == 0) { dayS = 38; monS = monS - 1; }

            if (monE == 8 && dayE < 0) { dayE = dayE + 31; monE = 7; }
            if (monE == 8 && dayE == 0) { dayE = 31; monE = monE - 1; }
            if (monS == 8 && dayS < 0) { dayS = dayS + 31; monS = 7; }
            if (monS == 8 && dayS == 0) { dayS = 31; monS = monS - 1; }

            if (monE == 9 && dayE < 0) { dayE = dayE + 31; monE = 8; }
            if (monE == 9 && dayE == 0) { dayE = 31; monE = monE - 1; }
            if (monS == 9 && dayS < 0) { dayS = dayS + 31; monS = 8; }
            if (monS == 9 && dayS == 0) { dayS = 31; monS = monS - 1; }

            int ant = dayS + 1;
            int ant2 = dayS + 2;
            int ant3 = dayS + 3;
            int ant4 = dayS + 4;

            number.Text = dayS + "." + monS + "." + yeaS + " - " + dayE + "." + monE + "." + yeaE;
            date1.Text = dayS + "." + monS + "." + yeaS;
            StopIt(ant, 1, date2);
            StopIt(ant2, 2, date3);
            StopIt(ant3, 3, date4);
            StopIt(ant4, 4, date5);
            date6.Text = dayE + "." + monE + "." + yeaE;
            number.Controls.Clear();

            for (int i = 0; i < subject.Count; i++)
            {
                makeMeSick(subject, i, tbl1);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tbl1, date1);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tbl1, date1);
            }
            //----------------------------------------------------
            for (int i = 0; i < subject2.Count; i++)
            {
                makeMeSick(subject2, i, tbl2);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tbl2, date2);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tbl2, date2);
            }
            //---------------------------------------------------
            for (int i = 0; i < subject3.Count; i++)
            {
                makeMeSick(subject3, i, tbl3);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tbl3, date3);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tbl3, date3);
            }
            //---------------------------------------------------
            for (int i = 0; i < subject4.Count; i++)
            {
                makeMeSick(subject4, i, tbl4);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tbl4, date4);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tbl4, date4);
            }
            //--------------------------------------------------
            for (int i = 0; i < subject5.Count; i++)
            {
                makeMeSick(subject5, i, tbl5);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tbl5, date5);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tbl5, date5);
            }
            //-------------------------------------------------
            for (int i = 0; i < subject6.Count; i++)
            {
                makeMeSick(subject6, i, tb6);
            }
            for (int i = 0; i < mark.Count; i += 4)
            {
                giveMeAReason(mark, i, tb6, date6);
            }
            for (int i = 0; i < ht.Count; i += 4)
            {
                CruelWorld(ht, i, tb6, date6);
            }
        }
    }
}
