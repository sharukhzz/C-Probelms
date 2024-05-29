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

namespace TrainingNew
{
    public partial class Shapes : Form
    {
        public Shapes()
        {
            InitializeComponent();
        }
        private int sx, sy, ex, ey,x=0;
        private bool isMove;
        private Graphics graphics;

        private void button1_Click(object sender, EventArgs e)
        {
            x = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = 3;
        }
        List<Point> points=new List<Point>();

        private void Shapes_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            sx = e.X;
            sy = e.Y;
            points.Add(new Point(sx, sy)); 
        }

        private void Shapes_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMove) return;
            ex = e.X;
            ey = e.Y;
            Invalidate();
        }

        private void Shapes_MouseUp(object sender, MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            isMove = false;
           
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (x == 0)
            {
                graphics.DrawRectangle(Pens.Red, sx, sy, ex - sx, ey - sy);
            }
            if(x==1)
            {
                graphics.DrawEllipse(Pens.Blue, sx, sy, ex - sx, ey - sy);
            }
            if(x==2)
            {
                graphics.DrawPolygon(Pens.Black,new Point[] { new Point(sx + ((ex - sx) / 2)), new Point(sx, ey), new Point(ex, ey) });
            }
            if(x==3)
            {
                if(points.Count>1) graphics.DrawPolygon(Pens.Green,  points.ToArray() );
            }
        }
    }
}
