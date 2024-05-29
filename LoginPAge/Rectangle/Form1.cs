using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace Rectangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isVert;
        private Pen p = new Pen(Color.Black,3);
        private GraphicsPath path = new GraphicsPath();
        private Rectangle r;
        private int split = 0;
        private int k = 0;
        private Graphics g;
        private int number = 0;
        private ColorDialog cd;
        private Color cbutton;
        private bool isall;
        private int w = 0, h = 0;
        private List<Rectangle> li = new List<Rectangle>();
        private List<Color> lic = new List<Color>();
        private List<int> index = new List<int>();

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            w = ex - sx;
            h = ey - sy;
            r = new Rectangle(sx, sy, w, h);
            g.DrawRectangle(p, r);
            if (!isVert )
            {
                if (split > 0)
                {
                    k = h / (split);
                    int y1 = sy;
                    for (int i = 0; i < split-1; i++)
                    {
                        y1 += k;
                        r = new Rectangle(sx, y1, w, k);
                        g.DrawLine(p, new Point(sx, y1), new Point(ex, y1));
                    }
                }
            }
            else if (isVert )
            {
                if (split > 0)
                {
                    k = w / split;
                    int y1 = sx;
                    for (int i = 0; i < split-1; i++)
                    {
                        y1 += k;
                        g.DrawLine(p, new Point(y1, sy), new Point(y1, ey));
                    }
                }
            }
            if (!isVert && number > 0)
            {
                k = h / (split);
                int x = sy;
                for (int i = 0; i < number; i++)
                {
                    x += k;
                }
                x -= k;
               r = new Rectangle(new Point(sx, x), new Size(width: ex - sx, height: k));
                g.FillRectangle(new SolidBrush(cd.Color), r);
                li.Add(r);
            }
            else if (isVert && number > 0 )
            {
                k = w / (split);
                int x = sx;
                for (int i = 0; i < number; i++)
                {
                    x += k;
                }
                x -= k;
                Rectangle r = new Rectangle(new Point(x, sy), new Size(k, ey-sy));
                g.FillRectangle(new SolidBrush(cd.Color), r);
                li.Add(r);
            }
            if(isall && !isVert)
            {
               for(int i=0;i<lic.Count;i++)
                {
                    g.DrawRectangle(p, li[i]);
                    g.FillRectangle(new SolidBrush(lic[i]), li[i]);
                }
            }
            if(isall && isVert)
            {
                for (int i = 0; i < lic.Count; i++)
                {
                    g.DrawRectangle(p, li[i]);
                    g.FillRectangle(new SolidBrush(lic[i]), li[i]);
                }
            }
        }


        private void FillClick(object sender, EventArgs e)
        {
            number = Convert.ToInt16(comboBox1.Text);
            index.Add(number);
            Invalidate();
        }

        private void SplitsTextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                split = Convert.ToInt32(textBox1.Text);
                Invalidate();
            }
            comboBox1.Items.Clear();
            for (int i = 1; i <= split; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void RadioButton1CheckedChanged(object sender, EventArgs e)
        {
            isVert = false;
            li.Clear();
            Invalidate();
        }

        private void RadioButton2CheckedChanged(object sender, EventArgs e)
        {
            isVert = true;
            li.Clear();
            Invalidate();
        }

        private void ColorClick(object sender, EventArgs e)
        {
            cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                cbutton = cd.Color;
            }
            lic.Add(cbutton);
        }

        private void ResetClick(object sender, EventArgs e)
        {
            number = 0;
            k = 0;
            li.Clear();
            for(int i=0;i<lic.Count;i++)
            {
                lic[i]=Color.Empty;
            }
            isall = false;
            Invalidate();
        }

        private void AllClick(object sender, EventArgs e)
        {
            isall = true;
            Invalidate();
        }
        private bool ismouse;
        private int sx = 0, sy = 0,ex=0,ey=0;


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ismouse = true;
            sx = e.Location.X;
            sy = e.Location.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!ismouse) return;
            ex = e.Location.X;
            ey = e.Location.Y;
            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ismouse = false;
            if(ex-sx<100 )
            {
                ex += 100;
            }
            if(ey-sy<100)
            {
                ey += 100;
            }
        }
    }
}
