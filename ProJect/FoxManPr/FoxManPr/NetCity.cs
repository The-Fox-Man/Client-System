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

          //  List<string> subject = MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects");
            List<string>  subject = MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + login.clasForm + "' AND day = '" + "пн" + "'");
            List<string> subject2 = MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + login.clasForm + "' AND day = '" + "вт" + "'");
            List<string> subject3 = MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + login.clasForm + "' AND day = '" + "ср" + "'");
            List<string> subject4 = MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + login.clasForm + "' AND day = '" + "чт" + "'");
            List<string> subject5 = MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + login.clasForm + "' AND day = '" + "пт" + "'");
            List<string> subject6 = MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + login.clasForm + "' AND day = '" + "сб" + "'");

            for (int i = 0; i < subject.Count; i++)
            {
                Label lbl = new Label();
                lbl.Dock = DockStyle.Fill;
                lbl.Location = new Point(3, 0);
                lbl.Size = new Size(32, 32);
                lbl.Text = subject[i];
                tbl1.Controls.Add(lbl, 1, i);
            }
            for (int i = 0; i < subject2.Count; i++)
            {
                Label lbl = new Label();
                lbl.Dock = DockStyle.Fill;
                lbl.Location = new Point(3, 0);
                lbl.Size = new Size(32, 32);
                lbl.Text = subject2[i];
                tbl2.Controls.Add(lbl, 1, i);
            }
            for (int i = 0; i < subject3.Count; i++)
            {
                Label lbl = new Label();
                lbl.Dock = DockStyle.Fill;
                lbl.Location = new Point(3, 0);
                lbl.Size = new Size(32, 32);
                lbl.Text = subject3[i];
                tbl3.Controls.Add(lbl, 1, i);
            }
            for (int i = 0; i < subject4.Count; i++)
            {
                Label lbl = new Label();
                lbl.Dock = DockStyle.Fill;
                lbl.Location = new Point(3, 0);
                lbl.Size = new Size(32, 32);
                lbl.Text = subject4[i];
                tbl4.Controls.Add(lbl, 1, i);
            }
            for (int i = 0; i < subject5.Count; i++)
            {
                Label lbl = new Label();
                lbl.Dock = DockStyle.Fill;
                lbl.Location = new Point(3, 0);
                lbl.Size = new Size(32, 32);
                lbl.Text = subject5[i];
                tbl5.Controls.Add(lbl, 1, i);
            }
            for (int i = 0; i < subject6.Count; i++)
            {
                Label lbl = new Label();
                lbl.Dock = DockStyle.Fill;
                lbl.Location = new Point(3, 0);
                lbl.Size = new Size(32, 32);
                lbl.Text = subject6[i];
                tb6.Controls.Add(lbl, 1, i);
            }
            /*   for (int i = 7; i < subject.Count; i++)
               {
                   Label lbl1 = new Label();
                   lbl1.Dock = DockStyle.Fill;
                   lbl1.Location = new Point(3, 0);
                   lbl1.Size = new Size(32, 32);
                   lbl1.Text = subject[i];
                   tbl2.Controls.Add(lbl1, 1, i - 7);
               }
              for (int i = 14; i < subject.Count; i++)
               {
                   Label lbl1 = new Label();
                   lbl1.Dock = DockStyle.Fill;
                   lbl1.Location = new Point(3, 0);
                   lbl1.Size = new Size(32, 32);
                   lbl1.Text = subject[i];
                   tbl2.Controls.Add(lbl1, 1, i - 14);
               }
               for (int i = 21; i < subject.Count; i++)
               {
                   Label lbl1 = new Label();
                   lbl1.Dock = DockStyle.Fill;
                   lbl1.Location = new Point(3, 0);
                   lbl1.Size = new Size(32, 32);
                   lbl1.Text = subject[i];
                   tbl2.Controls.Add(lbl1, 1, i - 21);
               }
               for (int i = 28; i < subject.Count; i++)
               {
                   Label lbl1 = new Label();
                   lbl1.Dock = DockStyle.Fill;
                   lbl1.Location = new Point(3, 0);
                   lbl1.Size = new Size(32, 32);
                   lbl1.Text = subject[i];
                   tbl2.Controls.Add(lbl1, 1, i - 28);
               }
               for (int i = 35; i < subject.Count; i++)
               {
                   Label lbl1 = new Label();
                   lbl1.Dock = DockStyle.Fill;
                   lbl1.Location = new Point(3, 0);
                   lbl1.Size = new Size(32, 32);
                   lbl1.Text = subject[i];
                   tbl2.Controls.Add(lbl1, 1, i - 35);
               }*/

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
    }
}
