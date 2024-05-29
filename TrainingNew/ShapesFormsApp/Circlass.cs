using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesFormsApp
{
    class Circlass : IShape
    {
        public int Startx { get; set; }
        public int Starty { get; set; }
        public int Endx { get; set; }
        public int Endy { get; set; }

        public Circlass(int sx,int sy,int ex,int ey)
        {
            Startx = sx;
            Starty = sy;
            Endx = ex;
            Endy = ey;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(Pens.Black, Startx, Starty, Endx, Endy);
        }
    }
}
