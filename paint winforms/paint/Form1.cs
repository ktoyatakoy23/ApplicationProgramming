using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetSize();
        }
        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;

            public ArrayPoints(int size)
            {
                if (size <= 0)
                {
                    size = 2;
                }
                points = new Point[size];
            }
            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x, y);
                index++;
            }
            public void NewPoint()
            {
                index = 0;

            }
            public int GetPoint()
            {
                return index;
            }
            public Point[] GetPoints()
            {
                return points;
            } 
        }

        private bool isMouseClick = false;
        private ArrayPoints arrayPoints = new ArrayPoints (2);
        
        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;
        
        Pen pen = new Pen(Color.Black, 3f);
       
        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);
           
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

        }
        private void DrawingField_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseClick = true;
        }

        private void DrawingField_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseClick = false;
            arrayPoints.NewPoint();
        }

        private void DrawingField_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouseClick) 
            {
                return;
            }
            arrayPoints.SetPoint(e.X, e.Y);
            if(arrayPoints.GetPoint() >= 2)
            {
                graphics.DrawLines(pen, arrayPoints.GetPoints());
                DrawingField.Image = map;
                arrayPoints.SetPoint(e.X, e.Y);
            }
        }

        private void WhiteButton_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            graphics.Clear(DrawingField.BackColor);
            DrawingField.Image = map;
        }

        private void ChangeSize_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = ChangeSize.Value;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG(*.JPG) | *.jpg";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            { 
                 DrawingField.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.DrawEllipse(pen, 100,100, 300,200);
        }


        //добавить отрисовывание фигур


    }
}
