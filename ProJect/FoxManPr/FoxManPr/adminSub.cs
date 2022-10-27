using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
            string[] parts = cm.Text.Split(new char[] {','});
            MySqlCommand cmd = new MySqlCommand("INSERT INTO subjects(1t, 2d, 3d, 4th, 5th, 6th, 7th)" 
                                                + "VALUES('"+ textBox1.Text + "', '"+ textBox2.Text + "', " +
                                                "'"+ textBox3.Text + "', '"+ textBox4.Text + "'," +
                                                " '"+ textBox5.Text + "', '"+ textBox6.Text + "', '"+ textBox7.Text + "')", Program.con);
            DbDataReader read = cmd.ExecuteReader();
            read.Close();
            MessageBox.Show("YUP");
            adminSub_Load(sender, e);
            return;
           
        }

        private void adminSub_Load(object sender, EventArgs e)
        {
            List<string> list = NetCity.MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th, id FROM subjects");

            pan1.Controls.Clear();
            int y = 50;
            int x = 50;
            for (int i = 0; i < list.Count; i+=8)
            {
                Label lbl = new Label();
                lbl.Location = new Point(10, y);
                lbl.Size = new Size(145, 65);
                lbl.Text = list[i];
                lbl.Tag = list[i + 7];
                pan1.Controls.Add(lbl);

                Label lbl1 = new Label();
                lbl1.Location = new Point(160, y);
                lbl1.Size = new Size(145, 65);
                lbl1.Text = list[i + 1];
                pan1.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Location = new Point(310, y);
                lbl2.Size = new Size(145, 65);
                lbl2.Text = list[i + 2];
                pan1.Controls.Add(lbl2);

                Label lbl3 = new Label();
                lbl3.Location = new Point(460, y);
                lbl3.Size = new Size(145, 65);
                lbl3.Text = list[i + 3];
                pan1.Controls.Add(lbl3);

                Label lbl4 = new Label();
                lbl4.Location = new Point(610, y);
                lbl4.Size = new Size(145, 65);
                lbl4.Text = list[i + 4];
                pan1.Controls.Add(lbl4);

                Label lbl5 = new Label();
                lbl5.Location = new Point(760, y);
                lbl5.Size = new Size(145, 65);
                lbl5.Text = list[i + 5];
                pan1.Controls.Add(lbl5);

                Label lbl6 = new Label();
                lbl6.Location = new Point(910, y);
                lbl6.Size = new Size(145, 65);
                lbl6.Text = list[i + 6];
                pan1.Controls.Add(lbl6);

                Button btn = new Button();
                btn.Location = new Point(1060, y);
                btn.Size = new Size(109, 30);
                btn.TabIndex = 0;
                btn.Text = "Удалить";
                btn.UseVisualStyleBackColor = true;
                btn.Click += new EventHandler(delete);
                pan1.Controls.Add(btn);

                y += 70;
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
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM subjects WHERE id = '" + control.Tag + "'", Program.con);
                    DbDataReader read = cmd.ExecuteReader();
                    read.Close();
                    MessageBox.Show("YUP");
                    adminSub_Load(sender, e);
                    return;
                }
            }
        }

        private void pan1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
