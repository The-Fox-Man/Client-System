using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxManPr
{
    public partial class NetCityTeachrers : Form
    {
        int y = 10;
        public static string UserData;
        public NetCityTeachrers()
        {
            InitializeComponent();
            user.Text = login.nameForm + " " + login.surnForm;
            List<string> subject = NetCity.MySelect("SELECT surn FROM users WHERE type = '" + "Ученик" + "'");

            for (int i = 0; i < subject.Count; i++)
            {
                Button lbl = new Button();
                lbl.Location = new Point(50, y);
                lbl.Font = new Font("Comic Sans MS", 13);
                lbl.Size = new Size(100, 30);
                lbl.Text = subject[i];
                lbl.UseVisualStyleBackColor = true;
                lbl.Click += new EventHandler(open);
                panel.Controls.Add(lbl);
                
                y = y + 40;

            }
          
        }
        private void open(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            UserData = btn.Text;


            UserMarks lal = new UserMarks();
            lal.ShowDialog();
        }
        private void tbl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NetCityTeachrers_Load(object sender, EventArgs e)
        {

        }
    }
}
