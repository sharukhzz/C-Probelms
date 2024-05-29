using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesFormsApp
{
    public interface IShape
    {
        int Startx { get; set; }
        int Starty { get; set; }
        int Endx { get; set; }
        int Endy { get; set; }

        void Draw(Graphics graphics);
    }
}
