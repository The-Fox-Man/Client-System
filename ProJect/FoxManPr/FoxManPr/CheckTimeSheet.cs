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
    public partial class CheckTimeSheet : Form
    {
        List<string> subject = NetCity.MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" +  UserMarks.currentclas + "' AND day = '" + "пн" + "'");
        List<string> subject2 = NetCity.MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + UserMarks.currentclas + "' AND day = '" + "вт" + "'");
        List<string> subject3 = NetCity.MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + UserMarks.currentclas + "' AND day = '" + "ср" + "'");
        List<string> subject4 = NetCity.MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + UserMarks.currentclas + "' AND day = '" + "чт" + "'");
        List<string> subject5 = NetCity.MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + UserMarks.currentclas + "' AND day = '" + "пт" + "'");
        List<string> subject6 = NetCity.MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + UserMarks.currentclas + "' AND day = '" + "сб" + "'");
        public CheckTimeSheet()
        {
            InitializeComponent();
            for (int i = 0; i < subject.Count; i++)
            {
                makeMeSick(subject, i, tbl1);
            }
            for (int i = 0; i < subject2.Count; i++)
            {
                makeMeSick(subject2, i, tbl2);
            }
            for (int i = 0; i < subject3.Count; i++)
            {
                makeMeSick(subject3, i, tbl3);
            }
            for (int i = 0; i < subject4.Count; i++)
            {
                makeMeSick(subject4, i, tbl4);
            }
            for (int i = 0; i < subject5.Count; i++)
            {
                makeMeSick(subject5, i, tbl5);
            }
            for (int i = 0; i < subject6.Count; i++)
            {
                makeMeSick(subject6, i, tbl6);
            }
        }
        private void makeMeSick(List<string> subject, int i, TableLayoutPanel tbl)
        {

            Label lbl = new Label();
            lbl.Dock = DockStyle.Fill;
            lbl.Location = new Point(3, 0);
            lbl.Size = new Size(32, 32);
            lbl.Text = subject[i];
            tbl.Controls.Add(lbl, 1, i);

            Label lbl1 = new Label();
            lbl1.Dock = DockStyle.Fill;
            lbl1.Location = new Point(3, 0);
            lbl1.Size = new Size(32, 32);
            lbl1.Text = Convert.ToString(i + 1);
            tbl.Controls.Add(lbl1, 0, i);
        }
        private void CheckTimeSheet_Load(object sender, EventArgs e)
        {

        }
    }
}
