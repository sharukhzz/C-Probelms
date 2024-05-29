using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Snake.Properties;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer1 = new Timer();
            timer1.Interval = 10000;
            timer.Tick += Timer_Tick1;
        }
        Random random = new Random();
        private void Timer_Tick1(object sender, EventArgs e)
        {
            int flag = 0;
            PictureBox pictureBox = new PictureBox
            {
               Location = new Point(random.Next(0, this.Width), random.Next(0, Height)),
                Image = Properties.Resources.ff,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(50,50),
            };
            for(int i=0;i<fruits.Count;i++)
            {
                if(pictureBox.Bounds.IntersectsWith(fruits[i].Bounds))
                {
                    flag = 1;
                }
            }
            if (flag == 0)
            {
                fruits.Add(pictureBox);
                Controls.Add(pictureBox);
            }
        }
        private List<PictureBox> fruits = new List<PictureBox>();
        private List<Rectangle> rectangles = new List<Rectangle>();
        private int x = 20,y=0;
        private Graphics graphics;
        private bool isPaint;
        private Rectangle rectangle;
        private Timer timer,timer1;
        private bool isDraw;
        private bool isDown;
        private bool isDpress;
        private bool isUp;
        private bool isUpress;
        private bool isLeft;
        private bool isLpress;
        private bool isRight;
        private bool isAdd;

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if(isPaint)
            {
                rectangle = new Rectangle(0, 0, 50, 50);
                graphics.FillRectangle(Brushes.Red, rectangle);
                rectangles.Add(rectangle);
                graphics.FillEllipse(Brushes.Black, rectangle.Width - 20, rectangle.Height - 40, 10, 10);
                graphics.FillEllipse(Brushes.Black, rectangle.Width - 20, rectangle.Height - 20, 10, 10);
                timer.Start();
                timer1.Start();
                isPaint = false;
            }
            if(isDraw)
            {
                graphics.FillRectangle(Brushes.Red, rectangle);
                graphics.FillEllipse(Brushes.Black, rectangle.X+30, rectangle.Y + 10, 10, 10);
                graphics.FillEllipse(Brushes.Black, rectangle.X+30, rectangle.Y + 30, 10, 10);
                isDraw = false;
            }
            if (isDown && isDpress)
            {
                float cx = rectangle.X + rectangle.Width / 2f;
                float cy = rectangle.Y + rectangle.Height / 2;
                graphics.TranslateTransform(cx, cy);
                graphics.RotateTransform(180);
                graphics.TranslateTransform(-cx, -cy);
                graphics.FillRectangle(Brushes.Red, rectangle);
                isDpress = false;
            }
            if (isLeft && isLpress)
            {
                float cx = rectangle.X + rectangle.Width / 2f;
                float cy = rectangle.Y + rectangle.Height / 2;
                graphics.TranslateTransform(cx, cy);
                graphics.RotateTransform(90);
                graphics.TranslateTransform(-cx, -cy);
                graphics.FillRectangle(Brushes.Red, rectangle);
                isLpress = false;
            }
            if (isDown || isUp || isLeft || isRight)
            {
                graphics.FillRectangle(Brushes.Red, rectangle);
                rectangle = rectangles[0];
                if(isRight)
                {
                    graphics.FillEllipse(Brushes.Black, rectangle.X + 30, rectangle.Y + 10, 10, 10);
                    graphics.FillEllipse(Brushes.Black, rectangle.X + 30, rectangle.Y + 30, 10, 10);
                }
                if(isLeft)
                {
                    graphics.FillEllipse(Brushes.Black, rectangle.X +10 ,rectangle.Y + 10, 10, 10);
                    graphics.FillEllipse(Brushes.Black, rectangle.X + 10, rectangle.Y + 30, 10, 10);
                }
                if(isUp)
                {
                    graphics.FillEllipse(Brushes.Black, rectangle.X + 10, rectangle.Y + 10, 10, 10);
                    graphics.FillEllipse(Brushes.Black, rectangle.X + 30, rectangle.Y + 10, 10, 10);
                }
                if(isDown)
                {
                    graphics.FillEllipse(Brushes.Black, rectangle.X + 10, rectangle.Y + 30, 10, 10);
                    graphics.FillEllipse(Brushes.Black, rectangle.X + 30, rectangle.Y + 30, 10, 10);
                }
            }
            if(isAdd)
            {
                rectangle = rectangles[0];
                foreach(var rr in rectangles)
                {
                    graphics.FillRectangle(Brushes.Red, rr);
                }
                if (isLeft)
                {
                    Rectangle r = new Rectangle(rectangle.X + rectangle.Width, rectangle.Y, rectangle.Width, rectangle.Height);
                    graphics.FillRectangle(Brushes.Red, r);
                    rectangles.Add(r);
                }
                
         
                isAdd = false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for(int i=0;i<rectangles.Count;i++)
            {
                rectangle = rectangles[i];
                if (isDown)
                {
                    rectangle.Location = new Point(rectangle.X , rectangle.Y + y);
                    y += 10;
                }
                else if(isUp)
                {
                    rectangle.Location = new Point(rectangle.X, rectangle.Y - y);
                    y -= 10;
                }
                else if(isLeft)
                {
                    rectangle.Location = new Point(rectangle.X - x,rectangle.Y);
                    x -= 10;
                }
                else if(isRight)
                {
                    rectangle.Location = new Point(rectangle.X + x, rectangle.Y);
                    x += 10;
                }
                else if(!isDraw)
                {
                    rectangle.Location = new Point(rectangle.X + x, rectangle.Y);
                    x += 10;
                    isDraw = true;
                }
                rectangles[i] = rectangle;
            }
            foreach (var n in fruits)
            {

                if (rectangle.IntersectsWith(n.Bounds))
                {
                    isAdd = true;
                    Invalidate();
                }
            }
            Invalidate();
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Down)
            {
                isDown = true;
                isDpress = true;
                isUp = false;
                isLeft = false;
                isRight = false;
            }
            if(e.KeyCode==Keys.Up)
            {
                isUp = true;
                isDown = false;
                isRight = false;
                isLeft = false;
            }
            if(e.KeyCode==Keys.Left)
            {
                isLeft = true;
                isLpress = true;
                isDown = false;
                isUp = false;
                isRight = false;
            }
            if(e.KeyCode==Keys.Right)
            {
                isRight = true;
                isDown = false;
                isLeft = false;
                isUp = false;
            }
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = false;
            isPaint = true;
            Invalidate();
        }
    }
}
