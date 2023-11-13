using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        float firstnumber, result;
        int count;

        private void zero_button(object sender, RoutedEventArgs e)
        {
            resultUi.Text = "0";
        }

        private void two_button(object sender, RoutedEventArgs e)
        {
            resultUi.Text = "2";
        }

        private void clear_button(object sender, RoutedEventArgs e)
        {
            resultUi.Text = "";
            Label1.Content = "";
        }

        private void delete_button(object sender, RoutedEventArgs e)
        {
            int lenght = resultUi.Text.Length - 1;
            string text = resultUi.Text;
            resultUi.Clear();
            for (int i = 0; i < lenght; i++)
            {
                resultUi.Text = resultUi.Text + text[i];
            }
        }

        private void slash_button(object sender, RoutedEventArgs e)
        {
            firstnumber = float.Parse(resultUi.Text);
            resultUi.Clear();
            count = 3;
            Label1.Content = firstnumber.ToString() + "/";
        }

        private void seven_button(object sender, RoutedEventArgs e)
        {
            resultUi.Text = "7";

        }

        private void eight_button(object sender, RoutedEventArgs e)
        {
            resultUi.Text = "8";

        }

        private void nine_button(object sender, RoutedEventArgs e)
        {
            resultUi.Text = "9";

        }

        private void four_button(object sender, RoutedEventArgs e)
        {
            resultUi.Text = "4";

        }

        private void five_button(object sender, RoutedEventArgs e)
        {
            resultUi.Text = "5";

        }

        private void six_button(object sender, RoutedEventArgs e)
        {
            resultUi.Text = "6";

        }

        private void multiply_button(object sender, RoutedEventArgs e)
        {
            firstnumber = float.Parse(resultUi.Text);
            resultUi.Clear();
            count = 2;
            Label1.Content = firstnumber.ToString() + "x";
        }

        private void minus_button(object sender, RoutedEventArgs e)
        {
            firstnumber = float.Parse(resultUi.Text);
            resultUi.Clear();
            count = 1;
            Label1.Content = firstnumber.ToString() + "-";
        }

        private void plus_button(object sender, RoutedEventArgs e)
        {
            firstnumber = float.Parse(resultUi.Text);
            resultUi.Clear();
            count = 4;
            Label1.Content = firstnumber.ToString() + "+";
        }

        private void three_button(object sender, RoutedEventArgs e)
        {
            resultUi.Text = "3";
        }

        private void comma_button(object sender, RoutedEventArgs e)
        {
            resultUi.Text = ",";

        }

        private void equals_button(object sender, RoutedEventArgs e)
        {
           Calculate();
           Label1.Content = "=";

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void one_button(object sender, RoutedEventArgs e)
        {
            resultUi.Text = "1";

        }

        private void Calculate()
        {
            switch (count)
            {
                case 1:
                    result = firstnumber - float.Parse(resultUi.Text);
                    resultUi.Text = result.ToString();
                    break;
                case 2:
                    result = firstnumber * float.Parse(resultUi.Text);
                    resultUi.Text = result.ToString();
                    break;
                case 3:
                    result = firstnumber / float.Parse(resultUi.Text);
                    resultUi.Text = result.ToString();
                    break;
                case 4:
                    result = firstnumber + float.Parse(resultUi.Text);
                    resultUi.Text = result.ToString();
                    break;

                default:
                    break;
            }
        }



    }
}
