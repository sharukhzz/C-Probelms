using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 3000;         
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            isTimer = false;
            if(!isTimer)
            {
                timer1.Stop();
                BackgroundImage = null;
                panel2.Visible = false;
                menuStrip2.Visible = true;
            }
            
        }

        private Timer timer1;
        private bool isTimer;
        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip2.Visible = false;
            timer1.Start();
            isTimer = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void Neww(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private Graphics g;
        private bool isMove,isColor;
        private int sx, sy, ex, ey,x=-1,xOffset = 0;
        private Rectangles rectangles;
        private List<Rectangles> li = new List<Rectangles>();
        private PictureBox picture=new PictureBox();

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            if(isColor)
            {
                g.FillRectangle(new SolidBrush(li[x].color), li[x].rectangle);
                isColor = false;
            }
            for (int i = 0; i < li.Count; i++)
            {
                g.DrawRectangle(Pens.Black, li[i].rectangle);
                g.FillRectangle(new SolidBrush(li[i].color), li[i].rectangle);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(x!=-1)
            {
                li.RemoveAt(x);
                x = -1;
                panel2.Invalidate();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int w = li[x].rectangle.Height;
            int h = li[x].rectangle.Width;
            rectangles = new Rectangles()
            {
                color = li[x].color,
                rectangle = new Rectangle(li[x].rectangle.X, li[x].rectangle.Y, w, h),
            };
            li.RemoveAt(x);
            li.Insert(x, rectangles);
            panel2.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";
                if(open.ShowDialog()==DialogResult.OK)
                {
                    panel3.Visible = true;
                    picture.Image = new Bitmap(open.FileName);
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Location = new Point(xOffset, 0); 
                    panel3.Controls.Add(picture);
                    xOffset += picture.Width + 5;
                }
            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            picture.MouseClick += Picture_MouseClick;
        }

        private void Picture_MouseClick(object sender, MouseEventArgs e)
        {
            picture.MouseMove += Picture_MouseMove;
        }

        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (ColorDialog color = new ColorDialog())
            {
                if(color.ShowDialog()==DialogResult.OK)
                {
                    li[x].color = color.Color;
                    isColor = true;
                    panel2.Invalidate();
                }
            }

        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Size s = new Size(500,500);
            for(int i=0;i<li.Count;i++)
            {
                if (li[i].rectangle.Contains(e.Location))
                {
                    if (li[i].rectangle.Width*li[i].rectangle.Height < s.Width*s.Height)
                    {
                        s = li[i].rectangle.Size; 
                        x = i;                        
                    }
                }
            }
            if (x != -1)
            {
                panel2.Invalidate();
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            rectangles = new Rectangles()
            {
                color = Color.Empty,
                rectangle = new Rectangle(sx, sy, ex - sx, ey - sy),
            };
            li.Add(rectangles);
            panel2.Invalidate();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            sx = e.Location.X;
            sy = e.Location.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove)
            {
                ex = e.Location.X;
                ey = e.Location.Y;
            }
        }
    }
}
