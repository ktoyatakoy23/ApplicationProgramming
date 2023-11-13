using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace LetterSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isChecked;

        List<string> priceList = new List<string>();
        List<string> сharacters = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            Check.Checked += FromBorder_Checked;
            Check.Unchecked += FromBorder_Unchecked;
        }
       
        static bool IsValidEmail(string email2)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email2);
        }

        private void send_button_Click(object sender, RoutedEventArgs e)
        {
            string email2 = email.Text; 

            if (IsValidEmail(email2))
            {
                string To = email2;
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Credentials = new NetworkCredential("npl1u1pc@mail.ru", "dWxZks4tnrEGDq3XWqQh");
                smtpClient.EnableSsl = true;
                string From = "npl1u1pc@mail.ru";
                MailMessage message = new MailMessage(From, To);
                message.Subject = "Посылка";
                message.Body = "ФИО: " + YourName.Text + "\n"
                    + "Ваш адрес: " + YourAddress.Text + "\n"
                    + "Адрес получателя" + NotYourAddress.Text + "\n"
                    + "Тип письма: " + LetterType.Text + "\n"
                    + "Ваш текст: " + "\n" + LetterText.Text;
                smtpClient.Host = "smtp.mail.ru";
                smtpClient.Port = 2525;
                smtpClient.Send(message);
            }
            else
            {
                MessageBox.Show("адрес почты введен неверно");
            }
           
        }
        private void FromBorder_Checked(object sender, RoutedEventArgs e)
        {
            isChecked = true;
        }
        private void FromBorder_Unchecked(object sender, RoutedEventArgs e)
        {
        }

        private void price_button_Click(object sender, RoutedEventArgs e)
        {

            if(isChecked)
            {
                сharacters.Add(LetterText.Text);
                string text = сharacters.Last();

                int characterCount = text.Length;

                int price = characterCount * 2;

                priceList.Add(price.ToString());
                LetterPrice.Content = priceList.Last() + " Руб";
            }
            else
            {
                сharacters.Add(LetterText.Text);
                string text = сharacters.Last();

                int characterCount = text.Length;

                int price = characterCount ;

                priceList.Add(price.ToString());
                LetterPrice.Content = priceList.Last() + " Руб";
            }
           
        }

        private void LetterText_TextChanged(object sender, TextChangedEventArgs e)
        {
            сharacters.Add(LetterText.Text);
        }

        private void LetterText_TextInput(object sender, TextCompositionEventArgs e)
        {
            сharacters.Add(LetterText.Text);
        }
    }
}
