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

namespace graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddLine(new Point(100, 100), new Point(300, 100));
                gp.AddLine(new Point(300, 100), new Point(110, 200));
                gp.AddLine(new Point(110, 200), new Point(200, 50));
                gp.AddLine(new Point(200, 50), new Point(280, 200));
                gp.CloseFigure();
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawPath(Pens.Black, gp);
                 g.FillPath(Brushes.Red, gp);
            }
          //  GraphicsPath gp = new GraphicsPath();
          //  Pen p = new Pen(Color.Black, 3);
          //  Pen pp = new Pen(Color.White, 2);

          //  Rectangle r = new Rectangle(100, 200, 200, 200);
          //  g.FillRectangle(Brushes.LightBlue, r);
          //  g.DrawRectangle(Pens.Black, r);
          //  g.DrawLine(p, new Point(100, 300), new Point(200, 200));
          //  g.DrawLine(p, new Point(200, 200), new Point(300, 300));
          //  g.DrawArc(p, 210, 300,180,200, 270.0F, -90.0F);
          //  g.DrawArc(p,0,300,210,200, 270.0F,90.0F);
          //  g.DrawLine(pp, new Point(220, 220), new Point(220, 350));
          ////  g.FillRectangle (Brushes.AliceBlue, r);
          // // g.DrawPath(Pens.Black, gp);
        }
    }
}
