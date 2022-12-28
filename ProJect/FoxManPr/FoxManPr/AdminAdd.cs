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

namespace FoxManPr
{
    public partial class AdminAdd : Form
    {
        public AdminAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && cmn.Text != "")
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO users(name, surn, type, pass, post, clas) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + label5.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + "" + "')", Program.con);
                DbDataReader read = cmd.ExecuteReader();
                read.Close();

                List<string> list1 = NetCity.MySelect("SELECT name, surn, type, pass, post, clas, id FROM users WHERE post = '" + textBox4.Text + "' AND pass = '" + textBox3.Text + "' AND name = '" + textBox1.Text + "' AND surn = '" + textBox2.Text + "'");
                MySqlCommand cmdn = new MySqlCommand("INSERT INTO admins(name, surname, tagid, status) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + list1[6] + "', '" + cmn.Text + "')", Program.con);
                DbDataReader rea = cmdn.ExecuteReader();
                rea.Close();

                MessageBox.Show("Администратор добавлен в список.", "System");
                AdminAdd_Load(sender, e);
                return;
            }

        }

        private void AdminAdd_Load(object sender, EventArgs e)
        {
            List<string> list = NetCity.MySelect("SELECT name, surname, tagid, status FROM admins");

            pan1.Controls.Clear();
            int y = 50;

            for (int i = 0; i < list.Count; i += 4)
            {
                    Label lbl = new Label();
                    lbl.Location = new Point(10, y);
                    lbl.Size = new Size(145, 30);
                    lbl.Text = list[i];
                    lbl.Tag = list[i + 2];
                    lbl.BackColor = Color.Transparent;
                    pan1.Controls.Add(lbl);

                    Label lbl1 = new Label();
                    lbl1.Location = new Point(160, y);
                    lbl1.Size = new Size(145, 30);
                    lbl1.Text = list[i + 1];
                    lbl1.BackColor = Color.Transparent;
                    pan1.Controls.Add(lbl1);

                    Label lbl2 = new Label();
                    lbl2.Location = new Point(320, y);
                    lbl2.Size = new Size(145, 30);
                    lbl2.Text = list[i + 3];
                    lbl2.BackColor = Color.Transparent;
                    pan1.Controls.Add(lbl2);

                    Button btn = new Button();
                    btn.Location = new Point(470, y);
                    btn.Size = new Size(109, 30);
                    btn.TabIndex = 0;
                    btn.Text = "Удалить";
                    btn.UseVisualStyleBackColor = true;
                    btn.Click += new EventHandler(delete);
                    pan1.Controls.Add(btn);

                    y += 47;
                
            }
        }
        private void delete(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in pan1.Controls)
            {
                if (control.Location == new Point(10, y + AutoScrollPosition.Y))
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM users WHERE id = '" + control.Tag + "'", Program.con);
                    DbDataReader read = cmd.ExecuteReader();
                    read.Close();

                    MySqlCommand cm = new MySqlCommand("DELETE FROM admins WHERE tagid = '" + control.Tag + "'", Program.con);
                    DbDataReader rea = cm.ExecuteReader();
                    rea.Close();
                    MessageBox.Show("Администратор удвлён из списка.", "System");
                    AdminAdd_Load(sender, e);
                    return;
                }
            }
        }

        private void pan1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
