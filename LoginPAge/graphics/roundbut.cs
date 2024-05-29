using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace graphics
{
    public class roundbut : Button
    {
     //   private bool Checked=false;
        private int X=100;
        private int Y=100;

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            
            GraphicsPath Outer = GetPath(50,50,0);
            GraphicsPath Inner = GetPath(50, 50, 20);

            g.FillPath(Brushes.Red, Outer);
            g.FillPath(Brushes.Purple, Inner);

            

        }

        private GraphicsPath GetPath(int W,int H,int a)
        {
            GraphicsPath Path = new GraphicsPath();
            Path.StartFigure();
            Path.AddArc(a, a, W, H, 180, 90);
            Path.AddArc(Width - W-a, a, W,H, 270, 90);
            Path.AddArc(Width - W-a, Height - H-a, W, H, 0, 90);
            Path.AddArc(a, Height - H-a, W, H, 90, 90);
            Path.CloseFigure();
            return Path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            X = Width / 2;
            Y = Height / 2;
            Invalidate();

        }

    }
}
