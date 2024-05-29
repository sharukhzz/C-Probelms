using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitRectangles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int startx = 0, starty = 0, endx = 0, endy = 0,total=0,x=0,y=0,value=0,no=0,u=0,uu=0;
        private bool isMove,isHorz,isVert, isall,isComb=true;
        private Rectangle rectangle;
        private Pen p = new Pen(Color.Black, 4);
        private Graphics g;
        private ColorDialog color;
        private List<Rectangle> li = new List<Rectangle>();
        private List<Color> lic = new List<Color>();
        private int[] a = new int[50];

        protected override void OnPaint(PaintEventArgs e)
        { 
            g = e.Graphics;
            rectangle = new Rectangle(startx,starty,endx-startx,endy-starty);
            g.DrawRectangle(p, rectangle);
            x = startx;
            y = starty;
            if(isHorz && no==1 && !isall)
            {
                value = (endy - starty )/ total;
                for(int i=0;i<total;i++)
                {
                    rectangle = new Rectangle(new Point(x,y),new Size((endx-startx),(value)));
                    li.Add(rectangle);
                    g.DrawRectangle(Pens.Red, rectangle);
                    y += value;
                }
                isHorz = false;
                x = startx;
                y = starty;
            }
            if(isVert && no==1)
            {
                value = (endx - startx) / total;
                for(int i=0;i<total;i++)
                {
                    rectangle = new Rectangle(new Point(x, y), new Size(value, (endy - starty)));
                    li.Add(rectangle);
                    g.DrawRectangle(Pens.Red, rectangle);
                    x += value;
                }
                isVert = false;
                x = startx;
                y = starty;
            }
            if(no>1 || comboBox1.Text!="" || comboBox1.Text=="" || !isall || isall)
            {
                    if(isVert)
                    {
                        li.Clear();
                        value = (endx - startx) / total;
                        for (int i = 0; i < total; i++)
                        {
                            rectangle = new Rectangle(new Point(x, y), new Size(value, (endy - starty)));
                            li.Add(rectangle);
                            g.DrawRectangle(Pens.Red, rectangle);
                            x += value;
                        }
                        x = startx;
                        y = starty;
                    }
                    if(isHorz)
                    {
                        li.Clear();
                        value = (endy - starty) / total;
                        for (int i = 0; i < total; i++)
                        {
                            rectangle = new Rectangle(new Point(x, y), new Size((endx - startx), (value)));
                            li.Add(rectangle);
                            g.DrawRectangle(Pens.Red, rectangle);
                            y += value;
                        }
                        x = startx;
                        y = starty;
                    }
            }
            if(comboBox1.Text!="")
            {
                int d = Convert.ToInt32(comboBox1.Text);
                rectangle = li[d - 1];
                g.FillRectangle(new SolidBrush(lic[lic.Count - 1]), rectangle);
                a[u] = d;
                u++;
            }
            if(isall)
            {
                uu = 0;
                for(int i=0;i<a.Length;i++)
                {
                    if (uu != lic.Count)
                    {
                        if (a[i] != 0)
                        {
                            int y = a[i] - 1;
                            rectangle = li[y];
                            g.FillRectangle(new SolidBrush(lic[uu]), rectangle);
                            uu++;
                        }
                    }
                }
                isall = false;
            }
        }

        private void All(object sender, EventArgs e)
        {
            isall = true;
            Invalidate();
        }

        private void Fills(object sender, EventArgs e)
        {
           
           Invalidate();
        }

        private void Colour(object sender, EventArgs e)
        {
            color = new ColorDialog();
            if(color.ShowDialog()==DialogResult.OK)
            {
                lic.Add(color.Color);
            }
        }


        private void ComboBox1(object sender, EventArgs e)
        {
            if (isComb)
            {
                for (int i = 1; i <= total; i++)
                {
                    comboBox1.Items.Add(i);
                }
                isComb = false;
            }
        }

        private void Horizontal(object sender, EventArgs e)
        {
            no++;
            isHorz = true;
            isVert = false;
            Invalidate();
        }

        private void Vertical(object sender, EventArgs e)
        {
            no++;
            isVert = true;
            isHorz = false;
            Invalidate();
        }

        private void SplitsTextChanged(object sender, EventArgs e)
        {
            total = int.Parse(textBox1.Text);
            comboBox1.Items.Clear();
            ComboBox1(null,EventArgs.Empty);
        }

        private void Form1MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            startx = e.X;
            starty = e.Y;
        }

        private void Form1MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMove) return;
            endx = e.X;
            endy = e.Y;
            Invalidate();
        }

        private void Form1MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
            endx = e.X;
            endy = e.Y;
        }
    }
}
