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

namespace LiLogo
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
        }

      

        private Graphics graphics;
        private SolidBrush brushes = new SolidBrush(Color.Blue);
        private Pen Pen = new Pen(Color.Red, 2);
        private List<Point[]> li = new List<Point[]>();
        private int i=0;
        private bool isBool,isTimer,isFirst;
        private Timer timer;
        private float newWidth = 330, newHeight = 280,newrx=70,newyx=100;

        private void Timer_Tick(object sender, EventArgs e)
        {
            isTimer = true;
            Invalidate();
        }

        private void Timer(object sender, EventArgs e)
        {
            timer.Start();
        }
        private RectangleF rectangle;
        private float rw, rh,rx,ry,prevwidth,prevheight;

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            rectangle = new RectangleF(newrx,newyx,newWidth,newHeight);
            rx = Width / newrx;
            ry = Height / newyx;
            rw = Width /newWidth;
            rh = Height / newHeight;
            prevwidth = Width;
            prevheight = Height;
            graphics.FillRectangle(Brushes.White, rectangle);
            if (!isBool && !isTimer)
            {
                Point[] p = new Point[] { new Point(250, 130), new Point(210, 160), new Point(265, 210), new Point(265, 145) };
                graphics.FillPolygon(brushes, p);
                li.Add(p);
                Point[] p2 = new Point[] { new Point(209, 160), new Point(150, 200), new Point( 265,215) };
                graphics.FillPolygon(brushes, p2);
                li.Add(p2);
                Point[] p3 = new Point[] { new Point(267, 146), new Point(270,210),new Point(300,185)};
               graphics.FillPolygon(brushes, p3);
                li.Add(p3);
                Point[] p4 = new Point[] { new Point(300,187), new Point(275, 215), new Point(330, 220) };
                graphics.FillPolygon(brushes, p4);
                li.Add(p4);
                Point[] p5 = new Point[] { new Point(275,220), new Point(310,270),new Point(350,245),new Point(350,245),new Point(333,223)};
                graphics.FillPolygon(brushes, p5);
                li.Add(p5);
                Point[] p6 = new Point[] { new Point(270, 225), new Point(270, 330), new Point(308, 272) };
               graphics.FillPolygon(brushes, p6);
                li.Add(p6);
                Point[] p7 = new Point[] { new Point(265,225), new Point(170, 300), new Point(240, 380) ,new Point(265,335)};
                graphics.FillPolygon(brushes, p7);
                li.Add(p7);
                Point[] p8 = new Point[] { new Point(148,203),new Point(100,245), new Point(168, 300), new Point(260, 218) };
                graphics.FillPolygon(brushes, p8);
                li.Add(p8);
                isBool = true;
            }
            if(isTimer)
            {
              
                if (i >= li.Count)
                {
                    isBool = false;
                    isTimer = false;
                    timer.Stop();
                   // Invalidate();
                }
                if (i < li.Count)
                {
                    for (int j = 0; j <i;j++)
                    {
                        Point[] pointss = li[j] as Point[];
                        graphics.FillPolygon(brushes, pointss);
                    }
                    Point[] points = li[i] as Point[];
                    graphics.FillPolygon(brushes, points);
                    i++;
                }
            }
            isFirst = true;
        }

        protected override void OnResize(EventArgs e)
        {
            if (isFirst)
            {
                newrx = Width / rx;
                newyx = Height / ry;
                newWidth = Width / rw;
                newHeight = Height / rh;
                Invalidate();
                isFirst = false;
                for (int i = 0; i < li.Count; i++)
                {
                    Point[] point = li[i] as Point[];
                    for (int j = 0; j< point.Length; j++)
                    {
                        point[j] = new Point((int)(Width / (prevwidth / point[j].X)), (int)(Height / (prevheight / point[j].Y)));
                    }

                }
            }
        }
    }
}
