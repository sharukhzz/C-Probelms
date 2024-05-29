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

namespace RegionManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            shape.RegionManager += Shape_RegionManager;
            shape.Moves += Shape_Moves;
            shape.Moves1 += Shape_Moves1;
        }

        private void Shape_Moves1(object sender, int e)
        {
            rectangle.Location = new Point(rectangle.X, rectangle.Y+e);
            isMove1 = true;
            Invalidate();
        }

        private void Shape_Moves(object sender, int e)
        {
            rectangle.Location = new Point(rectangle.X + e, rectangle.Y);
            isMove = true;       
            Invalidate();
        }

        public static int h, w;
        public shapes shape = new shapes();
        private List<string> list = new List<string>();
        private bool isAcess;
        private Rectangle rectangle;
        private Graphics g;
        private bool isMove,isMove1,isFirst;

        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            if (isAcess)
            {
                if(isMove)
                {
                    if (list[5] == "Pen")  g.DrawRectangle(Pens.Black, rectangle);
                    else  g.FillRectangle(Brushes.Black, rectangle);
                    isMove = false;
                }
                if(isMove1)
                {
                    if (list[5] == "Pen") g.DrawRectangle(Pens.Black, rectangle);
                    else g.FillRectangle(Brushes.Black, rectangle);
                    isMove1 = false;
                }
                if (list[0] == "Rectangle" && !isFirst)
                {

                    int sx = int.Parse(list[1]);
                    int sy = int.Parse(list[2]);
                    int ex = int.Parse(list[3]);
                    int ey = int.Parse(list[4]);
                    int w = ex - sx;
                    int h = ey - sy;
                     rectangle = new Rectangle(sx,sy, w, h);
                    if (list[5] == "Pen")
                    {
                        g.DrawRectangle(Pens.Black, rectangle);
                    }
                    else
                    {
                        g.FillRectangle(Brushes.Black, rectangle);
                    }
                    isFirst = true;
                }
                
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            shape.Width = panel1.Width;
            shape.Height = panel1.Height;

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if((rectangle.X).Equals(e.Location.X))
            {
                this.Cursor = Cursors.SizeWE;
            }
        }

        private void Shape_RegionManager(string[] s)
        {
            foreach(var n in s)
            {
                list.Add(n);
            }
            isAcess = true;
            Invalidate();
        }

    

        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Add(shape);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            h = panel1.Height;
            w = panel1.Width;
        }
    }
}
