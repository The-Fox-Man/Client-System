using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace FoxManPr
{
    public partial class NetCityTeachrers : Form
    {

        public static string clasTeach; 
        public static string UserData;
        public NetCityTeachrers()
        {
            InitializeComponent();
            List<string> list = NetCity.MySelect("SELECT class, id FROM classes");

            for (int i = 0; i < list.Count; i += 2)
            {
                cm.Items.Add(list[i]);
                cmb.Items.Add(list[i]);
            }

            user.Text = login.nameForm + " " + login.surnForm;

          
        }
        private void open(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer("../../Sounds/list.wav");
            s.Play();
            Button btn = (Button)sender;
            UserData = Convert.ToString(btn.Tag);


            UserMarks lal = new UserMarks();
            lal.ShowDialog();
        }
        private void tbl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NetCityTeachrers_Load(object sender, EventArgs e)
        {
            int y = 10;
            List<string> subject = NetCity.MySelect("SELECT surn, id, clas FROM users WHERE type = '" + "Ученик" + "'");
            panel.Controls.Clear();
            for (int i = 0; i < subject.Count; i += 3)
            {
                Button lbl = new Button();
                lbl.Location = new Point(50, y);
                lbl.Font = new Font("Comic Sans MS", 13);
                lbl.Size = new Size(200, 50);
                lbl.Text = subject[i];
                lbl.Tag = subject[i + 1];
                lbl.UseVisualStyleBackColor = true;
                lbl.Click += new EventHandler(open);
                panel.Controls.Add(lbl);

                Label lbl1 = new Label();
                lbl1.Location = new Point(270, y + 10);
                lbl1.Font = new Font("Comic Sans MS", 11);
                lbl1.Size = new Size(100, 50);
                lbl1.Text = subject[i + 2];
                panel.Controls.Add(lbl1);
                y = y + 60;

            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (cm.Text != "")
            {
                SoundPlayer s = new SoundPlayer("../../Sounds/list.wav");
                s.Play();
                clasTeach = cm.Text;
                AddHomeTask g = new AddHomeTask();
                g.ShowDialog();
            }
            else { MessageBox.Show("Выбирете класс.", "System"); }
        }

        private void Filtr_Click(object sender, EventArgs e)
        {
            if (cmb.Text == "")
            {
                NetCityTeachrers_Load(sender, e);
            }
            else
            {
                panel.Controls.Clear();
                int y = 10;
                List<string> subject = NetCity.MySelect("SELECT surn, id, clas FROM users WHERE type = '" + "Ученик" + "' AND clas = '" + cmb.Text + "'");
                for (int i = 0; i < subject.Count; i += 3)
                {
                    Button lbl = new Button();
                    lbl.Location = new Point(50, y);
                    lbl.Font = new Font("Comic Sans MS", 13);
                    lbl.Size = new Size(200, 50);
                    lbl.Text = subject[i];
                    lbl.Tag = subject[i + 1];
                    lbl.UseVisualStyleBackColor = true;
                    lbl.Click += new EventHandler(open);
                    panel.Controls.Add(lbl);

                    Label lbl1 = new Label();
                    lbl1.Location = new Point(270, y + 10);
                    lbl1.Font = new Font("Comic Sans MS", 11);
                    lbl1.Size = new Size(100, 50);
                    lbl1.Text = subject[i + 2];
                    panel.Controls.Add(lbl1);
                    y = y + 60;
                }
            }
            
        }

        private void SetNull_Click(object sender, EventArgs e)
        {
            cmb.Text = "";
            NetCityTeachrers_Load(sender, e);
        }
    }
}
