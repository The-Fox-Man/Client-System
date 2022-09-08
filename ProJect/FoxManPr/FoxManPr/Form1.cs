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
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
