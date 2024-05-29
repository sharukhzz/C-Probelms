using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer.Start();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            DoubleBuffered = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private Timer timer=new Timer();
        private Graphics graphics;

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            int radius = Math.Min(pictureBox1.Width, pictureBox1.Height) / 2;
            graphics.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
            graphics.FillEllipse(Brushes.White, -radius,-radius,radius*2,radius*2);
            graphics.DrawEllipse(Pens.Black, -radius, -radius, radius * 2, radius * 2);
            for (int i=0;i<12;i++)
            {
                double angle = Math.PI * i / 6;
                int x1 = (int)(radius * Math.Sin(angle) * 0.9);
                int y1 = (int)(-radius * Math.Cos(angle) * 0.9);
                int x2 = (int)(radius * Math.Sin(angle) * 0.8);
                int y2 = (int)(-radius * Math.Cos(angle) * 0.8);
                graphics.DrawLine(Pens.Black, x1, y1, x2, y2);
            }
            DateTime now = DateTime.Now;
            int hour = now.Hour;
            int minute = now.Minute;
            int second = now.Second;

            double hourAngle = (hour * 30 + minute * 0.5) * Math.PI / 180;
            int hourLength = (int)(radius * 0.5);
            int hourX = (int)(hourLength * Math.Sin(hourAngle));
            int hourY = (int)(-hourLength * Math.Cos(hourAngle));
            graphics.DrawLine(Pens.Black, 0, 0, hourX, hourY);

            double minuteAngle = minute * 6 * Math.PI / 180;
            int minuteLength = (int)(radius * 0.7);
            int minutex = (int)(minuteLength * Math.Sin(minuteAngle));
            int minutey = (int)(-minuteLength * Math.Cos(minuteAngle));
            graphics.DrawLine(Pens.Black, 0, 0, minutex, minutey);

            double secondAngle = second * 6 * Math.PI / 180;
            int secondLength = (int)(radius * 0.8);
            int secondx = (int)(secondLength * Math.Sin(secondAngle));
            int secondy = (int)(-secondLength * Math.Cos(secondAngle));
            graphics.DrawLine(Pens.Red, 0, 0, secondx, secondy);
        }
    }
}
