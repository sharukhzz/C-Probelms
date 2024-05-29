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

namespace RegionMover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        private int ex,ey,sx,sy,rw,rh;
        private bool isDraw,isModify;
        private Graphics g;
        private List<Rectangle> li = new List<Rectangle>();
        private List<Rectangle> li2 = new List<Rectangle>();
        private Rectangle rectangle;

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            rw = Width / button1.Width;
            rh = Height / button1.Height;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            if(isModify)
            {
                foreach(var k in li2)
                {
                    if (li.Contains(k))
                    {
                        li.Remove(k);
                    }
                }
                foreach (var n in li)
                {
                    g.DrawRectangle(Pens.Red, n);
                }
                foreach (var k in li2)
                {
                    li.Add(k);
                    g.DrawRectangle(Pens.Blue, k);
                }
            }
            else if (isDraw && sx!=0 )
            {
                rectangle = new Rectangle(sx, sy, ex - sx, ey - sy);
                if(li.Count==0) li.Add(rectangle);
                else
                {
                    int c = 0;
                    foreach(var k in li)
                    {
                        if(k.Location!=rectangle.Location)
                        {
                            c++;
                        }
                    }
                    if (c == li.Count && rectangle.Width!=0 && rectangle.Height!=0) li.Add(rectangle);
                }
                foreach (var n in li)
                {
                    g.DrawRectangle(Pens.Black, n);
                }
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            li2.Clear();
            Invalidate();

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int k = Int32.MaxValue;
            int flag = 0;
            foreach(var n in li)
            {
                if(n.Contains(e.Location))
                {
                    if(n.Width*n.Height<k)
                    {
                        rectangle = n;
                        k = n.Width * n.Height;
                        flag = 1;
                    }
                }
            }
            if (flag==1)
            {
                li2.Add(rectangle);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys==Keys.Control && li2.Count!=0 && e.Button==MouseButtons.Left) 
            {
                foreach (var k in li2)
                {
                    if (li.Contains(k))
                    {
                        li.Remove(k);
                    }
                }
                for (int i = 0; i < li2.Count; i++)
                {
                    rectangle = li2[i];
                    rectangle.Location = new Point(e.X - rectangle.X, e.Y - rectangle.Y);
                    li2[i]=rectangle;
                }
                isModify = true;
                Invalidate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isDraw = true;
            sx = 0;
            sy = 0;
            ex = 0;
            ey = 0;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            sx = e.X;
            sy = e.Y;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ex = e.X;
            ey = e.Y;
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (rw != 0)
            {
                // button1.Width = (Width * 8) / 100; //button width/form width*100 for 8   x=initialwidth/buttonwidth  button.Width=new =formwidth/x;
                button1.Width = Width / rw;
                button1.Height = Height / rh;
                //button1.Height = (Height * 8) / 100;
                // int newButtonX = (Width * 90) / 100 - button1.Width;  // button x / form width *100 for 9
                //int newButtonX =( Width / rx);
                // int newButtonY = (int)((float)(button1.Location.Y / ClientSize.Height) * Height)+button1.Location.Y;
                //int newButtonX = (int)((float)(button1.Location.X / ClientSize.Width) * Width)+button1.Location.X;
                //button1.Location = new Point(newButtonX, newButtonY);
                //float ratioX = (float)ClientSize.Width / ow;
                //float ratioY = (float)ClientSize.Height / oh;

                //button1.Left = (int)(button1.Left * ratioX);
                //button1.Top = (int)(button1.Top * ratioY);
            }
        }
    }
}
