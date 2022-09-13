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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (pan.Size.Height > 100)
            {
                pan.Size = new Size(pan.Size.Width, filtr.Location.Y + filtr.Size.Height);
            }
            else if (pan.Size.Height < 50)
            {
              pan.Size = new Size(pan.Size.Width, 140);
            }*/
            NetCity wha = new NetCity();
            wha.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Teachers t = new Teachers();
            t.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login t = new login();
            t.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reg t = new Reg();
            t.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Base t = new Base();
            t.ShowDialog();
        }
    }
}
