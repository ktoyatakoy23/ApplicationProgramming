using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        float firstnumber, result;
        int count;

        //начало цифрового блока клавиш

        private void zero_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void one_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void two_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void three_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void four_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void five_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void six_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void eight_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void nine_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }


        //конец цифрового блока клавиш

        private void Calculate()
        {
            switch (count)
            {
                case 1:
                    result = firstnumber - float.Parse(textBox1.Text); 
                    textBox1.Text = result.ToString();
                    break;
                case 2:
                    result = firstnumber * float.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    break;
                case 3:
                    result = firstnumber / float.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    break;
                case 4:
                    result = firstnumber + float.Parse(textBox1.Text);
                    textBox1.Text = result.ToString();
                    break;

                default:
                    break;
            }
        }

        //начало клавиш блока операций
        private void comma_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            firstnumber = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = firstnumber.ToString() + "-";
        }

        private void multiply_button_Click(object sender, EventArgs e)
        {
            firstnumber = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = firstnumber.ToString() + "x";
        }

        private void slash_button_Click(object sender, EventArgs e)
        {
            firstnumber = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = firstnumber.ToString() + "/";
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            firstnumber = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = firstnumber.ToString() + "+";
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for(int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void equals_button_Click(object sender, EventArgs e)
        {
            Calculate();
            label1.Text = "";
        }

    }
}
