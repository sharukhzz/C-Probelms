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
    class Roufh : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            GraphicsPath gp = new GraphicsPath();
            gp.StartFigure();
            gp.AddArc(0, 0, 100, 100, 180, 90);
            gp.CloseFigure();
            //  g.FillRectangle(Brushes.Red,this.ClientRectangle); to paint colour in full rectangle
            g.FillPath(Brushes.Red, gp);// to paint the arc
            //g.FillEllipse(Brushes.Yellow, this.ClientRectangle);
        }   
    }
}
