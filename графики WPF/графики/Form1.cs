using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace графики
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double a, b, h;
        private double x, y;

        

        private void build_Click(object sender, EventArgs e)
        {
            if (checkBox_cos.Checked == false && checkBox_sin.Checked == false)
            {
                MessageBox.Show("Выбери хотя бы один график", "Внимание!");
                return;
            }

            if (textBox_a.Text == "" && textBox_b.Text == "" || textBox_h.Text == "")
            {
                MessageBox.Show("Параметры по умолчанию", "Внимание!");
                Defaults();
            }
            else
            {
                a = Convert.ToDouble(textBox_a.Text);
                b = Convert.ToDouble(textBox_b.Text);
                h = Convert.ToDouble(textBox_h.Text);

            }
            if (checkBox_cos.Checked)
            {
                x = a;
                this.chart.Series[0].Points.Clear();

                while (x <= b)
                {
                    y = Math.Cos(x);
                    this.chart.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }
            if (checkBox_sin.Checked)
            {
                x = a;
                this.chart.Series[1].Points.Clear();

                while (x <= b)
                {
                    y = Math.Sin(x);
                    this.chart.Series[1].Points.AddXY(x, y);
                    x += h;
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (checkBox_cos.Checked == false && checkBox_sin.Checked == false)
            {
                MessageBox.Show("Выбери хотя бы один график", "Внимание!");
                return;
            }
            if (checkBox_sin.Checked)
            {
                this.chart.Series[1].Points.Clear();
            }
            if (checkBox_cos.Checked)
            {
                this.chart.Series[0].Points.Clear();
            }
        }
     
        private void Defaults()
        {
            a = -10;
            b = 10;
            h = 0.1;
        }
    }
}
