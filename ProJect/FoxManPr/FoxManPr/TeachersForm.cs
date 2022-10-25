using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoxManPr
{
    public partial class TeachersForm : Form
    {
        public TeachersForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO teachers(name, surn)"
            + "VALUES('" + textBox1.Text + "', '" + textBox2.Text + "')", Program.con);
            DbDataReader read = cmd.ExecuteReader();
            read.Close();
            MessageBox.Show("YUP");
            TeachersForm_Load(sender, e);
            return;
        }

        private void TeachersForm_Load(object sender, EventArgs e)
        {
            List<string> list = NetCity.MySelect("SELECT name, surn, id FROM teachers");

            pan1.Controls.Clear();
            int y = 50;
            int x = 50;
            for (int i = 0; i < list.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(10, y);
                lbl.Size = new Size(145, 65);
                lbl.Text = list[i];
                lbl.Tag = list[i+2];
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
            private void delete(object sender, EventArgs e)
            {
                Button btn = (Button)sender;
                int y = btn.Location.Y;

                foreach (Control control in pan1.Controls)
                {
                    if (control.Location == new Point(10, y))
                    {
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM teachers WHERE id = '" + control.Tag + "'", Program.con);
                        DbDataReader read = cmd.ExecuteReader();
                        read.Close();
                        MessageBox.Show("YUP");
                        TeachersForm_Load(sender, e);
                        return;
                    }
                }
            }
      
    }
}
