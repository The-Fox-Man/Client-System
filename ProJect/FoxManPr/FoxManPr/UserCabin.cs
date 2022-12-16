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
    public partial class UserCabin : Form
    {

        public UserCabin()
        {
            InitializeComponent();
            t1.Text = login.nameForm;
            t2.Text = login.surnForm;
            t3.Text = login.postForm;
            t4.Text = login.passForm;
        }

        private void UserCabin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(button1.Text == "Изменить")
            {
                t1.Enabled = true;
                t2.Enabled = true;
                t3.Enabled = true;
                t4.Enabled = true;
                button1.Text = "Сохранить";
            }
            else if(button1.Text == "Сохранить")
            {
                NetCity.MyUpdate("UPDATE users SET name ='" + t1.Text + "', surn ='" + t2.Text + "', post ='" + t3.Text + "', pass ='" + t4.Text + "' WHERE id ='" + login.idForm + "'");
                MessageBox.Show("Ваш профиль изменён.", "System");
                button1.Text = "Изменить";
                t1.Enabled = false;
                t2.Enabled = false;
                t3.Enabled = false;
                t4.Enabled = false;
            }
        }
    }
}
