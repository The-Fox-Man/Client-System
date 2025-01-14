﻿using System;
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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            if(Reg.reg == "reg")
            {
                label1.Text = "1) Если хотите зарегистрироваться как ученик, то зпаолните все поля, не нажимая ничего другого, и регистрируйтесь.";
                label2.Text = "2) Если вы ослушались пункт 1), то нажмите \"Верните, я ученик\".";
                label3.Text = "";
                label4.Text = "1) Если вы учитель, то заполните все поля (кроме класса) и нажмите \"Я учитель\".";
                label5.Text = "2) Далее введите код, сказанный организыцией и выбирете предмет, который будете вести.";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
            }
            if (login.typeForm == "Ученик")
            {
                label1.Text = "1) В сетевом городе вы можете просмотреть оценки и домашнее задание.";
                label2.Text = "2) Вы можете изменить свой в профиль нажав на иконку \"человечка\" на стартовой форме.";
                label3.Text = "3) Вы можете посмотреть всех наших учителей во вкладке \"Учителя\".";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
            }
            else if (login.typeForm == "Учитель")
            {
                label1.Text = "1) Вы можете поставить оценку ученику, зайдя в сетевой город, далее нажав на фамилию ученика";
                label2.Text = "(Помните! Число должно ставится без нулей, иначе программа вам об этом напомнит).";
                label3.Text = "2) Вы можете добавить домашнее задание, зайдя в сетевой город, далее выбрав класс в шапке и нажав кнопку добавления";
                label4.Text = "(Помните! Число должно ставится без нулей, иначе программа вам об этом напомнит).";
                label5.Text = "3) Вы можете изменить свой в профиль нажав на иконку \"человечка\" на стартовой форме.";
                label6.Text = "4) Вы можете посмотреть всех ваших колег во вкладке \"Учителя\".";
                label7.Text = "";
                label8.Text = "";
            }
            else if (login.typeForm == "Администратор")
            {
                if (Convert.ToInt32(login.status) >= 1)
                {
                    label1.Text = "1) Вы можете добавить расписание какому-либо классу, нажав в панели администратора на первую кнопку.";
                    label2.Text = "2) Вы можете изменить свой в профиль нажав на иконку \"человечка\" на стартовой форме.";
                    label3.Text = "3) Вы можете посмотреть всех ваших колег во вкладке \"Учителя\".";
                    label4.Text = "";
                    label5.Text = "";
                    label6.Text = "";
                    label7.Text = "";
                    label8.Text = "";
                }
                if (Convert.ToInt32(login.status) >= 2)
                {
                    label1.Text = "1) Вы можете добавить расписание какому-либо классу, нажав в панели администратора на первую кнопку.";
                    label2.Text = "2) Вы можете добавить предмет или класс, перейдя по второй кнопке в панели администратора.";
                    label3.Text = "3) Вы можете изменить свой в профиль нажав на иконку \"человечка\" на стартовой форме.";
                    label4.Text = "4) Вы можете посмотреть всех ваших колег во вкладке \"Учителя\".";
                    label5.Text = "";
                    label6.Text = "";
                    label7.Text = "";
                    label8.Text = "";
                }
                if (Convert.ToInt32(login.status) >= 3)
                {
                    label1.Text = "1) Вы можете добавить расписание какому-либо классу, нажав в панели администратора на первую кнопку.";
                    label2.Text = "2) Вы можете добавить предмет или класс, перейдя по второй кнопке в панели администратора.";
                    label3.Text = "3) Вы можете добавить учителя, перейдя по третьей кноаке в панели администратора.";
                    label4.Text = "4) Вы можете изменить свой в профиль нажав на иконку \"человечка\" на стартовой форме.";
                    label5.Text = "5) Вы можете посмотреть всех ваших колег во вкладке \"Учителя\".";
                    label6.Text = "";
                    label7.Text = "";
                    label8.Text = "";
                }
                if (Convert.ToInt32(login.status) >= 99)
                {
                    label1.Text = "1) Вы можете добавить расписание какому-либо классу, нажав в панели администратора на первую кнопку.";
                    label2.Text = "2) Вы можете добавить предмет или класс, перейдя по второй кнопке в панели администратора.";
                    label3.Text = "3) Вы можете добавить учителя, перейдя по третьей кноаке в панели администратора.";
                    label4.Text = "4) Вы можете смотреть и удалять ВСЕХ пользователй, перейдя по четвёртой кнопке в панели администратора.";
                    label5.Text = "5) Вы можете добавить администратора, перейдя по пятой кнопке в панели администратора.";
                    label6.Text = "6) Грубо говоря, ВЫ можете всё, но помните! Кража личных данных карается уголовной ответственностью.";
                    label7.Text = "7) Вы можете изменить свой в профиль нажав на иконку \"человечка\" на стартовой форме.";
                    label8.Text = "8) Вы можете посмотреть всех ваших колег во вкладке \"Учителя\".";
                }
            }
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }
    }
}
