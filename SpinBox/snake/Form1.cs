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

namespace snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            DoubleBuffered = true;
        }

        private int k,x=20,y=20;
        private List<Rectangle> rectangles = new List<Rectangle>();
        private Graphics graphics;
        private bool isBool,isInitial;
        private Timer timer;
        private Rectangle rectangle,rect;
        private bool isColour,isDown;
        private bool isPressed, isPress;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private KeyEventArgs key;
        private float cx, cy;

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isPressed)
            {
                if (key.KeyCode == Keys.Down)
                {
                    isDown = true;
                    isInitial = true;
                    isPress = true;
                }
            }
            for (int i = 0; i < rectangles.Count; i++)
            {
                rect = rectangles[i];
                if(!isInitial) rect.Location = new Point(rect.X + x, rect.Y);
                if (isDown)
                {
                    if(isPress)
                    {
                         cx = rect.X + rect.Width / 2f;
                         cy = rect.Y + rect.Height / 2f;
                    }
                }
                if(i==0)
                {
                    k = i;
                }
            }
            isColour = true;
            if (!isInitial)  x += 20;
            if (isDown) y += 20;
           
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (isBool)
            {
                rectangle = new Rectangle(0, 0, 50, 50);
                rectangles.Add(rectangle);
                graphics.FillRectangle(Brushes.Blue, rectangle);
                graphics.FillEllipse(Brushes.Black, 30, 10, 10, 10);
                graphics.FillEllipse(Brushes.Black, 30, 30, 10, 10);
                isBool = false;
                timer.Start();
            }
            if(isColour)
            {
                if(isDown && isPress)
                {
                    graphics.TranslateTransform(cx, cy);
                    graphics.RotateTransform(180);
                    graphics.TranslateTransform(-cx, -cy);
                    isPress = false;
                }
                graphics.FillRectangle(Brushes.Red, rect);
                if(k==0)
                {
                    graphics.FillEllipse(Brushes.Black, rect.X+30, rect.Y+10, 10, 10);
                    graphics.FillEllipse(Brushes.Black, rect.X + 30, rect.Y +30, 10, 10);
                }
                isColour = false;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.S)
            {

            }
        }

        //private void Form1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    isPressed = true;
        //    key = e;
        //    if (e.KeyCode == Keys.S)
        //    {
        //        isDown = true;
        //    }
        //    if (e.KeyCode == Keys.Space)
        //    {
        //        timer.Stop();
        //        isColour = true;
        //    }
        //}

    }
}
