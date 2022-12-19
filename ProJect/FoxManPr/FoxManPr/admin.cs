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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void admin_Load(object sender, EventArgs e)
        {
       
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(login.status) >= 1)
            {
                adminSub m = new adminSub();
                m.ShowDialog();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(login.status) >= 3)
            {
                TeachersForm u = new TeachersForm();
                u.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(login.status) >= 2)
            {
                AddClassesAndSub h = new AddClassesAndSub();
                h.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(login.status) >= 99)
            {
                Base t = new Base();
                t.ShowDialog();
            }
        }

        private void secret_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(login.status) >= 99)
            {
                AdminAdd t = new AdminAdd();
                t.ShowDialog();
            }
        }
    }
}
