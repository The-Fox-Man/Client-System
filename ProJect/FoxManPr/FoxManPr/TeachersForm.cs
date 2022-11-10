using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoxManPr
{
    public partial class TeachersForm : Form
    {
        public TeachersForm()
        {
            InitializeComponent();

          /*  List<string> list = NetCity.MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th, id FROM subjects");
            cm.Items.Clear();
            for (int i = 0; i < list.Count; i+=7)
            {
                cm.Items.Add(list[i] + "," + list[i + 1] + "," + list[i+2] + ","
                             + list[i + 3] + "," + list[i + 4] + list[i + 5] + ","
                             + list[i + 6] + "," + list[i + 7]);

            }*/

        }
        string yep = "Учитель";
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = NetCity.MySelect("SELECT name, surn, type, pass, post, clas, id FROM users");
            string[] parts = cm.Text.Split(new char[] { ',' });
            MySqlCommand cmd = new MySqlCommand("INSERT INTO users(name, surn, type, pass, post, clas) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + label5.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + "" + "')", Program.con);
            DbDataReader read = cmd.ExecuteReader();
            read.Close();
            List<string> list1 = NetCity.MySelect("SELECT name, surn, type, pass, post, clas, id FROM users WHERE post = '" + textBox4.Text + "' AND pass = '" + textBox3.Text + "'");
            MySqlCommand cmdn = new MySqlCommand("INSERT INTO teachers(name, surn, idtag) VALUES('" + textBox1.Text + "', '" + textBox2.Text  + "', '" + list1[6] + "')", Program.con);
            DbDataReader rea = cmdn.ExecuteReader();
            rea.Close();
            
            MessageBox.Show("YUP");
            TeachersForm_Load(sender, e);
            return;
        }

        private void TeachersForm_Load(object sender, EventArgs e)
        {
            List<string> list = NetCity.MySelect("SELECT name, surn, type, pass, post, clas, id FROM users");

            pan1.Controls.Clear();
            int y = 50;
            int x = 50;
            
            for (int i = 0; i < list.Count; i += 7)
            {
                if (list[i + 2] == "Учитель")
                {
                    Label lbl = new Label();
                    lbl.Location = new Point(10, y);
                    lbl.Size = new Size(145, 65);
                    lbl.Text = list[i];
                    lbl.Tag = list[i + 6];
                    pan1.Controls.Add(lbl);

                    Label lbl1 = new Label();
                    lbl1.Location = new Point(160, y);
                    lbl1.Size = new Size(145, 65);
                    lbl1.Text = list[i + 1];
                    pan1.Controls.Add(lbl1);

                    Button btn = new Button();
                    btn.Location = new Point(310, y);
                    btn.Size = new Size(109, 30);
                    btn.TabIndex = 0;
                    btn.Text = "Удалить";
                    btn.UseVisualStyleBackColor = true;
                    btn.Click += new EventHandler(delete);
                    pan1.Controls.Add(btn);

                    y += 70;
                }
            }
        }
            private void delete(object sender, EventArgs e)
            {
                Button btn = (Button)sender;
                int y = btn.Location.Y;

                foreach (Control control in pan1.Controls)
                {
                    if (control.Location == new Point(10, y))
                    {
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM users WHERE id = '" + control.Tag + "'", Program.con);
                        DbDataReader read = cmd.ExecuteReader();
                        read.Close();

                        MySqlCommand cm = new MySqlCommand("DELETE FROM teachers WHERE idtag = '" + control.Tag + "'", Program.con);
                        DbDataReader rea = cm.ExecuteReader();
                        rea.Close();
                        MessageBox.Show("YUP");
                        TeachersForm_Load(sender, e);
                        return;
                    }
                }
            }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
