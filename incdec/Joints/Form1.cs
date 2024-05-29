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

namespace Joints
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Graphics g;
        public Pen p = new Pen(Color.Red,3);
        public int st = 0, ed = 0,n=0;
        public List<Rectangles> li = new List<Rectangles>();
        public Rectangle r;
        public Rectangles rr,rrr;
        public bool isJoin;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
          
            for (int i=0;i<li.Count;i++)
            {
                rr = li[i];
                r = new Rectangle(rr.Start, rr.End, 2, 2);
                g.DrawEllipse(p, r);
            }
            if (isJoin)
            {
                for(int i=1;i<li.Count;i++)
                {
                    rrr = li[i - 1];
                    rr = li[i];
                    g.DrawLine(Pens.Black, new Point(rrr.Start, rrr.End), new Point(rr.Start, rr.End));
                }
                isJoin = false;
            }
            if (st != 0 && ed != 0)
            {
                rr = new Rectangles();
                r = new Rectangle(st, rr.End=ed, 2, 2);
                rr.Start = st;
                li.Add(rr);
                g.DrawEllipse(p, r);
            }
        }

        private void JointsClick(object sender, EventArgs e)
        {
            isJoin = true;
            Invalidate();
        }

        private void FMouseClick(object sender, MouseEventArgs e)
        {
            st = e.X;
            ed = e.Y;
            n++;
            Invalidate();
        }
    }
}
