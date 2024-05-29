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
    class Car : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(100, 100,100,100, 180, 90);
            g.FillPath(Brushes.Red,gp);

        }
    }
}
