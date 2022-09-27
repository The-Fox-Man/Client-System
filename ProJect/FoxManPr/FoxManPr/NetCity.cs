using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FoxManPr
{
    public partial class NetCity : Form
    {
        public NetCity()
        {
            InitializeComponent();
            user.Text = login.nameForm + login.surnForm;

            string[] lines = File.ReadAllLines("../../txt/subjects.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.None);
                people peopl = new people(parts[0], parts[1], parts[2], parts[3], parts[4],
                                          parts[5], parts[6], parts[7], parts[8], parts[9]);

                if(login.clas == parts[0] && day.Text == parts[2])
                {
                  //  tbl1.t1str1str2 сделать не листом а переменнными и присваивать значение каждой ячейке
                }
            }
        }
        private void NetCity_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void tbl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
