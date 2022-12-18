using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace FoxManPr
{
    public partial class AddHomeTask : Form
    {
        
        public AddHomeTask()
        {
            InitializeComponent();
            label2.Text = NetCityTeachrers.clasTeach;
            Text = "Выставить домашнее задание классу " + NetCityTeachrers.clasTeach;
        }

        private void yup_Click(object sender, EventArgs e)
        {
            List<string> list = NetCity.MySelect("SELECT 1t, 2d, 3d, 4th, 5th, 6th, 7th FROM subjects WHERE clas = '" + NetCityTeachrers.clasTeach + "' AND day = '" + day.Text + "'");
            List<string> list2 = NetCity.MySelect("SELECT name FROM sub WHERE id = '" + login.subidForm + "'");
            List<string> update = NetCity.MySelect("SELECT text, date, col FROM hometask WHERE class = '" + NetCityTeachrers.clasTeach + "' AND subid = '" + login.subidForm + "' AND col = '" + numb.Text + "' AND date = '" + dat.Text + "'");
            if (hmtsk.Text == "" || dat.Text == "" || day.Text == "" || numb.Text == "") { MessageBox.Show("Заполните все поля.", "System"); }
            else
            {
                string[] parts = dat.Text.Split(new char[] { '.' });
                if (list.Count > 0 && update.Count < 1 && list[Convert.ToInt32(numb.Text) - 1] == list2[0])
                {
                    if (parts[0] != "01" && parts[0] != "02" && parts[0] != "03" && parts[0] != "04" && parts[0] != "05" && parts[0] != "06" && parts[0] != "07" && parts[0] != "08"
                        && parts[0] != "09")
                    {
                        if (parts[1] != "01" && parts[1] != "02" && parts[1] != "03" && parts[1] != "04" && parts[1] != "05" && parts[1] != "06" && parts[1] != "07" && parts[1] != "08"
                             && parts[1] != "09")
                        {
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO hometask(text, date, col, class, subid)" + "VALUES('" + hmtsk.Text + "', '" + dat.Text + "', '" + numb.Text + "', '" + NetCityTeachrers.clasTeach + "', '" + login.subidForm + "')", Program.con);
                            DbDataReader read = cmd.ExecuteReader();
                            read.Close();
                            MessageBox.Show("Задание добавлено.", "System");
                            AddHomeTask_Load(sender, e);
                            return;
                        }
                        else { MessageBox.Show("Число должно быть без нулей, например, 5.9.2022, а не 05.09.2022", "System"); }
                    }
                    else { MessageBox.Show("Число должно быть без нулей, например, 5.9.2022, а не 05.09.2022", "System"); }
                }
                else { MessageBox.Show("Извините, вы добавили задание либо не в ту строку(а может не в правильный день недели), либо на это число, на этот день, в эту строку, где уже есть задание.", "System"); }
            }

        }

        private void AddHomeTask_Load(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            List<string> us = NetCity.MySelect("SELECT text, date, col FROM hometask WHERE class = '" + NetCityTeachrers.clasTeach + "' AND subid = '"+ login.subidForm  +"'");
            int y = 10;
            for (int i = 0; i < us.Count; i += 3)
            {
                TextBox lbl = new TextBox();
                lbl.Location = new Point(140, y);
                lbl.Font = new Font("Comic Sans MS", 13);
                lbl.Size = new Size(200, 30);
                lbl.Text = us[i];
                lbl.Enabled = false;
                panel.Controls.Add(lbl);

                Label lbl1 = new Label();
                lbl1.Location = new Point(20, y);
                lbl1.Font = new Font("Comic Sans MS", 13);
                lbl1.Size = new Size(150, 30);
                lbl1.Text = us[i + 1];
                panel.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Location = new Point(350, y);
                lbl2.Font = new Font("Comic Sans MS", 13);
                lbl2.Size = new Size(50, 30);
                lbl2.Text = us[i + 2];
                panel.Controls.Add(lbl2);

                Button btn = new Button();
                btn.Location = new Point(410, y);
                btn.Size = new Size(100, 30);
                btn.TabIndex = 0;
                btn.Text = "Удалить";
                btn.UseVisualStyleBackColor = true;
                btn.Click += new EventHandler(delete);
                panel.Controls.Add(btn);

                Button btn1 = new Button();
                btn1.Location = new Point(520, y);
                btn1.Size = new Size(100, 30);
                btn1.TabIndex = 0;
                btn1.Text = "Изменить";
                btn1.UseVisualStyleBackColor = true;
                btn1.Click += new EventHandler(change);
                panel.Controls.Add(btn1);

                y = y + 40;
            }
        }
        private void delete(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;
            foreach (Control control in panel.Controls)
            {
                foreach (Control control2 in panel.Controls)
                {
                    if (control.Location == new Point(20, y + AutoScrollPosition.Y) && control2.Location == new Point(350, y + AutoScrollPosition.Y))
                    {
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM hometask WHERE date = '" + control.Text + "' AND col= '" + control2.Text + "'AND class='" + NetCityTeachrers.clasTeach + "' AND subid='" + login.subidForm + "'", Program.con);
                        DbDataReader read = cmd.ExecuteReader();
                        read.Close();
                        MessageBox.Show("Задание удалено.", "System");
                        AddHomeTask_Load(sender, e);
                        return;
                    }

                }
            }
        }
        private void change(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control10 in panel.Controls)
            {
                if (control10.Location == new Point(520, y + AutoScrollPosition.Y) && control10.Text == "Изменить")
                {
                    foreach (Control control88 in panel.Controls)
                    {
                        if (control88.Location == new Point(140, y + AutoScrollPosition.Y))
                        {
                            control88.Enabled = true;
                        }
                    }
                    control10.Text = "Сохранить";  
                }
                else if(control10.Location == new Point(520, y + AutoScrollPosition.Y) && control10.Text == "Сохранить")
                {
                    foreach (Control control in panel.Controls)
                    {
                        foreach (Control control2 in panel.Controls)
                        {
                            if (control.Location == new Point(20, y + AutoScrollPosition.Y) && control2.Location == new Point(350, y + AutoScrollPosition.Y))
                            {
                                control10.Text = "Изменить";
                                foreach (Control control88 in panel.Controls)
                                {
                                    if (control88.Location == new Point(140, y + AutoScrollPosition.Y))
                                    {
                                        control88.Enabled = false;
                                        NetCity.MyUpdate("UPDATE hometask SET text ='" + control88.Text + "' WHERE date='" + control.Text + "' AND col='" + control2.Text + "' AND class='" + NetCityTeachrers.clasTeach + "' AND subid='" + login.subidForm + "'");
                                        MessageBox.Show("Задание изменено.", "System");
                                    }
                                }
                            }
                        }                                
                    }
                }
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            UserMarks.currentclas = NetCityTeachrers.clasTeach;
            CheckTimeSheet j = new CheckTimeSheet();
            j.ShowDialog();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dat.Text = dateTimePicker1.Text;
        }
    }
}
