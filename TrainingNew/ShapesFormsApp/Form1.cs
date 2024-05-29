using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapesFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Graphics graphics;
        private bool isMove,isBool;
        private int sx, sy, ex, ey,shape;

        private void button1_Click(object sender, EventArgs e)
        {
            shape = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shape = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shape = 3;
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            sx = e.X;
            sy = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMove) return;
            ex = e.X;
            ey = e.Y;
            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            isMove = false;
            isBool = true;
            Invalidate();
        }
        public static List<IShape> list = new List<IShape>();

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;
            if(shape==3)
            {
                foreach (var item in list)
                {
                    item.Draw(graphics);
                }
            }
            if (isBool)
            {
                if (shape == 1)
                {
                    graphics.DrawRectangle(Pens.Red, sx, sy, ex - sx, ey - sy);
                    IShape rect = new Rectangleclass(sx,sy,ex-sx,ey-sy);
                    list.Add(rect);
                }
                if (shape == 2)
                {
                    graphics.DrawEllipse(Pens.Black, sx, sy, ex - sx, ey - sy);
                    IShape circ = new Circlass(sx, sy, ex - sx, ey - sy);
                    list.Add(circ);
                }
            }
            else
            {
                if (shape == 1)
                {
                    graphics.DrawRectangle(Pens.Red, sx, sy, ex - sx, ey - sy);
                }
                if (shape == 2)
                {
                    graphics.DrawEllipse(Pens.Black, sx, sy, ex - sx, ey - sy);
                }
            }
            isBool = false;
        }
    }
}
