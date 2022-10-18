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

            List<string> subject = MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects");

            for (int i = 0; i < tbl1.RowCount; i++)
            {
                Label lbl = new Label();
                lbl.Dock = DockStyle.Fill;
                lbl.Location = new Point(3, 0);
                lbl.Size = new Size(32, 32);
                lbl.Text = subject[i];
                tbl1.Controls.Add(lbl, 1, i);
            }

            for (int i = 0; i < tbl2.RowCount; i++)
            {
                Label lbl1 = new Label();
                lbl1.Dock = DockStyle.Fill;
                lbl1.Location = new Point(3, 0);
                lbl1.Size = new Size(32, 32);
                lbl1.Text = subject[i + 7];
                tbl2.Controls.Add(lbl1, 1, i);
            }
/*
            if (subject[0] == login.clasForm)
            {
                if (subject[2] == "пн")
                {
                    for (int i = 0; i < tbl1.RowCount; i++)
                    {
                        sub.Add(subject[3]);
                        sub.Add(subject[4]);
                        sub.Add(subject[5]);
                        sub.Add(subject[6]);
                        sub.Add(subject[7]);
                        sub.Add(subject[8]);
                        sub.Add(subject[9]);
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
                }
                //if (subject[2] == "ср")
                {
                    for (int i = 10; i < tbl2.RowCount; i++)
                    {
                        sub.Add(subject[3]);
                        sub.Add(subject[4]);
                        sub.Add(subject[5]);
                        sub.Add(subject[6]);
                        sub.Add(subject[7]);
                        sub.Add(subject[8]);
                        sub.Add(subject[9]);
                    }
                    for (int i = 0; i < tbl2.RowCount; i++)
                    {
                        Label lbl = new Label();
                        lbl.Dock = DockStyle.Fill;
                        lbl.Location = new Point(3, 0);
                        lbl.Size = new Size(32, 32);
                        lbl.Text = sub[i];
                        tbl2.Controls.Add(lbl, 1, i);
                    }
                }
            }
*/

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
