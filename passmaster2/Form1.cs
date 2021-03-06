﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> words = new Dictionary<string, string>();

        public void OpenInBrowser(string a) // запуск ссылок в браузере
        {



            Process.Start("chrome.exe", "https://connect.yandex.ru/portal/admin");
            Process.Start("chrome.exe", "https://b2btravel.slack.com/admin");
            Process.Start("chrome.exe", "https://app.intercom.com/a/apps/l3shlkm4/settings/teammates");
            Process.Start("chrome.exe", "https://panel.onlinepbx.ru/ats/incoming");
            Process.Start("chrome.exe", "https://zoom.us/account/user#/");



        }
        public Form1()
        {
            InitializeComponent();
            words.Add("а", "a");
            words.Add("б", "b");
            words.Add("в", "v");
            words.Add("г", "g");
            words.Add("д", "d");
            words.Add("е", "e");
            words.Add("ё", "yo");
            words.Add("ж", "zh");
            words.Add("з", "z");
            words.Add("и", "i");
            words.Add("й", "y");
            words.Add("к", "k");
            words.Add("л", "l");
            words.Add("м", "m");
            words.Add("н", "n");
            words.Add("о", "o");
            words.Add("п", "p");
            words.Add("р", "r");
            words.Add("с", "s");
            words.Add("т", "t");
            words.Add("у", "u");
            words.Add("ф", "f");
            words.Add("х", "h");
            words.Add("ц", "c");
            words.Add("ч", "ch");
            words.Add("ш", "sh");
            words.Add("щ", "sch");
            words.Add("ъ", null);
            words.Add("ы", "i");
            words.Add("ь", null);
            words.Add("э", "e");
            words.Add("ю", "yu");
            words.Add("я", "ya");
            words.Add("А", "A");
            words.Add("Б", "B");
            words.Add("В", "V");
            words.Add("Г", "G");
            words.Add("Д", "D");
            words.Add("Е", "E");
            words.Add("Ё", "Yo");
            words.Add("Ж", "Zh");
            words.Add("З", "Z");
            words.Add("И", "I");
            words.Add("Й", "Y");
            words.Add("К", "K");
            words.Add("Л", "L");
            words.Add("М", "M");
            words.Add("Н", "N");
            words.Add("О", "O");
            words.Add("П", "P");
            words.Add("Р", "R");
            words.Add("С", "S");
            words.Add("Т", "T");
            words.Add("У", "U");
            words.Add("Ф", "F");
            words.Add("Х", "H");
            words.Add("Ц", "C");
            words.Add("Ч", "Ch");
            words.Add("Ш", "Sh");
            words.Add("Щ", "Sch");
            words.Add("Ъ", "J");
            words.Add("Ы", "I");
            words.Add("Ь", "J");
            words.Add("Э", "E");
            words.Add("Ю", "Yu");
            words.Add("Я", "Ya");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // замена слов из словаря при изменении текстового поля
        {
            string source = fio.Text;
            foreach (KeyValuePair<string, string> pair in words)
            {
                source = source.Replace(pair.Key, pair.Value);
            }
            fioTranslite.Text = source;




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void mail_Click(object sender, EventArgs e)
        {
            buffer(mail);
        }
        private static Random rnd = new Random();
        private static string RndStr(int letters, int numbers)
        {
            StringBuilder sb = new StringBuilder(letters + numbers);
            string letterSet = "abcdefghkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ";
            string numberSet = "0123456789!?$*+=";
            for (int i = 0; i < letters; i++)
                sb.Append(letterSet[rnd.Next(letterSet.Length)]);
            for (int i = 0; i < numbers; i++)
                sb.Append(numberSet[rnd.Next(numberSet.Length)]);
            return sb.ToString();
        }
        private void mail_TextChanged(object sender, EventArgs e)
        {

        }
        private void passMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void passMail_Click(object sender, EventArgs e)
        {
            // Clipboard.SetText(passMail.Text);
            buffer(passMail);
        }
        private void passFD_TextChanged(object sender, EventArgs e)
        {

        }
        private void passFD_Click(object sender, EventArgs e)
        {
            buffer(passGitea);
        }
        private void passIntercom_Click(object sender, EventArgs e)
        {

        }
        private void passAmo_Click(object sender, EventArgs e)
        {
            buffer(passJenkins);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string temp = fioTranslite.Text;
            string[] words = temp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string lastName = words[0]; // Ivanov
            string temp2 = words[1].Remove(1, words[1].Length - 1);  // I. - сокращенное имя
                                                                     // string FullfirstName = words[1];
            string firstName = temp2 + ".";

            shortMail.Text = firstName.ToLower() + lastName.ToLower();
            tbxGiteaLogin.Text = shortMail.Text;
            tbxJenkinsLogin.Text = lastName.ToLower();
            mail.Text = shortMail.Text + "@smartway.today"; //email без домена

            // разбивка строки на слова
            string[] word = fio.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            OnlyFirstName.Text = word[0];
            OnlySecondName.Text = word[1];
            //


            // генерирование паролей 
            passMail.Text = RndStr(6, 6);
            passGitea.Text = RndStr(6, 6);
            passJenkins.Text = RndStr(6, 6);
            // Clipboard.SetText(mail.Text);

            trackerOut.Text = fio.Text;
            trackerOut.AppendText(writer(mail.Text, passMail.Text, "Почта"));
            trackerOut.AppendText("Остальные учетки на почте");
            trackerOut.AppendText("\r\nДобавочный номер ");
            trackerOut.AppendText("\r\n((https://wiki.yandex.ru/homepage/Office/Nastrojjki-programm/Phoner-Lite/ Настройка PhonerLite))");
            trackerOut.AppendText("\r\n((https://wiki.yandex.ru/homepage/office/nastrojjki-programm/singinslack/ Как войти в Slack))");


            //ссылки на админки для создания учеток
            string yandexLnkSales = "https://connect.yandex.ru/portal/admin/departments/9";
            string yandexLnkHotels = "https://connect.yandex.ru/portal/admin/departments/21";
            string yandexLnkSupport = "https://connect.yandex.ru/portal/admin/departments/27";
            string yandexLnkContracting = "https://connect.yandex.ru/portal/admin/departments/32";
            string yandexLnkSopr = "https://connect.yandex.ru/portal/admin/departments/22";
            string yandexLnkDev = "https://connect.yandex.ru/portal/admin/departments/4";





            string slackLnk = "https://b2btravel.slack.com/admin";
            string intercomLnk = "https://app.intercom.com/a/apps/l3shlkm4/settings/teammates";
            string onpbx = "https://panel.onlinepbx.ru/ats/incoming";
            string zoomLnk = "https://zoom.us/account/user#/";
            string sbis = "https://online.sbis.ru/page/staff-list";
            string mailchimp = "https://login.mailchimp.com/?referrer=%2Faccount%2Fusers%2F";
            string yandexWebVisor = "https://metrika.yandex.ru/settings?id=38934205&tab=grants";
            string gitea = "https://gitea.gospodaprogrammisty.ru/admin/users";
            string jenkins = "https://jenkins.gospodaprogrammisty.ru/securityRealm/addUser";
            string vpn = "https://wiki.yandex.ru/homepage/development/vpn/";
            string BO = "https://bo.smartway.today/login";
            string LK = "https://smartway.today/registration";



            string[] linksForSales = { yandexLnkSales, slackLnk, onpbx, zoomLnk, sbis };
            string[] linkForHotels = { yandexLnkHotels, slackLnk, onpbx, zoomLnk, intercomLnk, LK, BO };
            string[] linkForSupport = { yandexLnkSupport, slackLnk, onpbx, zoomLnk, mailchimp, yandexWebVisor, LK, BO };
            string[] linkForContracting = { yandexLnkContracting, slackLnk, onpbx, zoomLnk, LK, BO };
            string[] linkForSopr = { yandexLnkSopr, slackLnk, onpbx, zoomLnk, intercomLnk, LK, BO };
            string[] linkForDev = { yandexLnkDev, slackLnk, zoomLnk, LK, BO, vpn, jenkins, gitea };

            switch (cmbEmployeeType.SelectedItem)
            {
                case "Гостиницы":
                    foreach (string a in linkForHotels)
                    {
                        Process.Start("chrome.exe", a);
                    }
                    break;
                case "Продажи":

                    foreach (string a in linksForSales)
                    {
                        Process.Start("chrome.exe", a);
                    }
                    break;
                case "Контрактинг":
                    foreach (string a in linkForContracting)
                    {
                        Process.Start("chrome.exe", a);
                    }
                    break;
                case "Поддержка":
                    foreach (string a in linkForSupport)
                    {
                        Process.Start("chrome.exe", a);
                    }
                    break;
                case "Сопровождение":
                    foreach (string a in linkForSopr)
                    {
                        Process.Start("chrome.exe", a);
                    }
                    break;
                case "Разработка":
                    trackerOut.AppendText(writer(shortMail.Text, passGitea.Text, "Gitea"));
                    trackerOut.AppendText(writer(tbxJenkinsLogin.Text, passJenkins.Text, "Jenkins"));
                    label2.Visible = tbxGiteaLogin.Visible = passGitea.Visible = true; // делает строки логина/пароля  для дженкинса и гитеа видимыми при выборе чекбокса
                    label4.Visible = tbxJenkinsLogin.Visible = passJenkins.Visible = true;
                    foreach (string a in linkForDev)
                    {
                        Process.Start("chrome.exe", a);
                    }
                    break;

            }





        }


        // вывод для трекера
        private static string writer(string Email, string password, string nameOfService)
        {
            return "\r\n#|\r\n" +
                "|| **" + nameOfService + "**||\r\n" +
                "|| Логин | %%" + Email + "%%||\r\n" +
                "|| Пароль | %%" + password + "%%||\r\n" + "|#";
            // "|#\r\nВнутренний номер:\r\nОстальные учетки на почте";
        }
        private void chkAmo_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void chkAmo_Click(object sender, EventArgs e)
        {

        }
        private void trackerOut_Click(object sender, EventArgs e)
        {
            buffer(trackerOut);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {



        }

        private void trackerOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkFD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fio_Click(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OnlyFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnlySecondName_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnlyFirstName_Click(object sender, EventArgs e)
        {
            buffer(OnlyFirstName);
        }
        private void OnlySecondName_Click(object sender, EventArgs e)
        {
            buffer(OnlySecondName);
        }
        private void shortMail_Click(object sender, EventArgs e)
        {
            buffer(shortMail);
        }
        private void buffer(TextBox a)  // функция для выделения и копирования текста. В аргумент подставляю textbox
        {
            if (a.Text == "")
            {
                //Ничего не делаем
            }
            else
            {
                a.SelectionStart = 0;
                a.SelectionLength = a.Text.Length;
                a.Focus();
                Clipboard.SetText(a.Text);
            }
        }

        private void chkbDev_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbDev.Checked)
            {
                




            }
        }

        private void fio_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void fio_DoubleClick(object sender, EventArgs e)
        {
            buffer(fio);

        }


        private void tbxGiteaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxJenkinsLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxGiteaLogin_MouseClick(object sender, MouseEventArgs e)
        {
            buffer(tbxGiteaLogin);
        }

        private void tbxJenkinsLogin_MouseClick(object sender, MouseEventArgs e)
        {
            buffer(tbxJenkinsLogin);
        }

        private void cmbEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
