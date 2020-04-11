using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string letterSet = "abcdefghijkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ";
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
            if (passFD.Text == "")
            {
                //Ничего не делаем
            }
            else
                buffer(passFD);
        }
        private void passIntercom_Click(object sender, EventArgs e)
        {

        }
        private void passAmo_Click(object sender, EventArgs e)
        {
            if (passAmo.Text == "")
            {
                //Ничего не делаем
            }
            else
                buffer(passAmo);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string temp = fioTranslite.Text;
            string[] words = temp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string lastName = words[0]; // Ivanov
            string temp2 = words[1].Remove(1, words[1].Length - 1);  // I. - сокращенное имя
            string FullfirstName = words[1];
            string firstName = temp2 + ".";
            shortMail.Text = firstName.ToLower() + lastName.ToLower() ;

            mail.Text = shortMail.Text + "@smartway.today"; //email без домена

            // разбивка строки на слова
            string[] word = fio.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            OnlyFirstName.Text = word[0];
            OnlySecondName.Text = word[1];

            

            // генерирование паролей 
            passMail.Text = RndStr(6, 6);
            passFD.Text = RndStr(6, 6);
            passAmo.Text = RndStr(6, 6);
           // Clipboard.SetText(mail.Text);

            trackerOut.Text = fio.Text;
            trackerOut.AppendText(writer(mail.Text, passMail.Text, "Почта"));
        }
        private void tracker_Click(object sender, EventArgs e)
        {

        }

        // вывод для трекера
        private static string writer(string Email, string password, string nameOfService)
        {
            return "\r\n#|\r\n" +
                "|| **" + nameOfService + "**||\r\n" +
                "|| Логин | %%" + Email + "%%||\r\n" +
                "|| Пароль | %%" + password + "%%||\r\n" +
                "|#\r\nВнутренний номер:\r\nОстальные учетки на почте";
        }
        private void chkAmo_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void chkAmo_Click(object sender, EventArgs e)
        {

        }
        private void trackerOut_Click(object sender, EventArgs e)
        {
            if (trackerOut.Text == "")
            {
                //Ничего не делаем
            }
            else buffer(trackerOut); // Clipboard.SetText(trackerOut.Text);

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
            buffer(fio);
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
            a.SelectionStart = 0;
            a.SelectionLength = a.Text.Length;
            a.Focus();
            Clipboard.SetText(a.Text);
            
        }
    }
}
