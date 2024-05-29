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

namespace Toggle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private Graphics graphics;
        private Rectangle rectangle,circle;
        private bool isInitial, isDraw,isPrev,isResize;
        private int rw=400,rh=150,rww,rhh,rx=50,ry=50,prevx,prevy,cw;

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            rectangle = new Rectangle(rx, ry, rw, rh);
           // graphics.FillRectangle(Brushes.Red, rectangle);
            GraphicsPath graphicsPath = new GraphicsPath();
            int r = 20;
            graphicsPath.AddArc(rectangle.X, rectangle.Y, r * 2, r * 2, 180, 90);
            graphicsPath.AddArc(rectangle.X + rectangle.Width-r*2, rectangle.Y, r * 2, r * 2, 270, 90);
            graphicsPath.AddArc(rectangle.X + rectangle.Width-r*2, rectangle.Y + rectangle.Height-r*2, r * 2, r * 2, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y + rectangle.Height-r*2, r * 2, r * 2, 90, 90);
            graphicsPath.CloseAllFigures();
            graphics.FillPath(Brushes.Red, graphicsPath);
            if (!isInitial)
            {
                cw = (rectangle.Width * 30) / 100;
                circle = new Rectangle(rx, ry, cw, rh);
                graphics.FillEllipse(Brushes.Blue, circle);
                isInitial = true;
            }
            if(isDraw)
            {
                graphics.FillEllipse(Brushes.Blue, circle);
            }
            if(isPrev)
            {
                graphics.FillEllipse(Brushes.Blue, circle);
                isPrev = false;
                isDraw = false;
            }
            isResize = true;
            prevx = Width / rx;
            prevy = Height / ry;
            rww = Width / rw;
            rhh = Height / rh;
        }

        private void Form1MouseClick(object sender, MouseEventArgs e)
        {
            if(circle.Contains(e.Location))
            {
                if (!isDraw)
                {
                    circle.Location = new Point(rectangle.Width - circle.Width + circle.X, circle.Y);
                    BackColor = Color.Black;
                    isDraw = true;
                }
                else if(isDraw)
                {
                    circle.Location = new Point(circle.Width+circle.X- rectangle.Width, circle.Y);
                    BackColor = Color.AliceBlue;
                    isPrev = true;
                }
            }
            else
            {
                isInitial = false;
            }
            Invalidate();
        }
        protected override void OnResize(EventArgs e)
        {
            if (isResize)
            {
                rx = Width / prevx;
                rh = Height / prevy;
                rw = Width / rww;
                rh = Height / rhh;
                isResize = true;
                isInitial = false;
                Invalidate();
            }
        }
    }
}
