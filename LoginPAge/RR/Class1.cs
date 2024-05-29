using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR
{
    class Class1 : Interface1
    {
        public  int x ;
        public  int y ;
        public  int Width { get; set; }
        public  int X { get => x; set => x = value; }
        public  int Y { get => y; set => y = value; }
        public int Height { get; set; }
        public int A { get; set; }

        public bool isTrue() { return true; }
    }
}
