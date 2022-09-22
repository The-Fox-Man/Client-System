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
        public NetCityTeachrers()
        {
            InitializeComponent();
            user.Text = login.nameForm + login.surnForm;
        }

        private void tbl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NetCityTeachrers_Load(object sender, EventArgs e)
        {

        }
    }
}
