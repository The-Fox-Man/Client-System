using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxManPr
{
    public partial class adminSub : Form
    {
        public adminSub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO subjects(1t, 2d, 3d, 4th, 5th, 6th, 7th)" 
                                                + "VALUES('"+ textBox1 + "', '"+ textBox2 + "', '"+ textBox3 + "', '"+ textBox4 + "', '"+ textBox5 + "', '"+ textBox6 + "', '"+ textBox7 + "')",Program.con);
            cmd.ExecuteReader();
            cmd.Dispose();
            MessageBox.Show("YUP");
        }

        private void adminSub_Load(object sender, EventArgs e)
        {
            List<string> list = NetCity.MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects");
            int y = 100;
            for (int i = 0; i < list.Count; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(10, y);
                lbl.Size = new Size(200, 50);
                lbl.Text = list[i];
                pan1.Controls.Add(lbl);

                Button btn = new Button();
                btn.Location = new Point(100, y);
                btn.Size = new Size(109, 37);
                btn.TabIndex = 0;
                btn.Text = "Удалить";
                btn.UseVisualStyleBackColor = true;
                btn.Click += new EventHandler(this.button1_Click);

                y += 20;
            }
        }
        private void delete(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach(Control control in pan1.Controls)
            {
                if (control.Location == new Point(10, y))
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM subjects WHERE 1t = '" + control.Text + "'", Program.con);
                    cmd.ExecuteReader();
                    cmd.Dispose();
                    MessageBox.Show("YUP");
                }
            }
        }
    }
}
