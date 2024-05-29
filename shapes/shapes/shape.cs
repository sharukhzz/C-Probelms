using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
        public static class RegionManager
        {
            private readonly static Dictionary<string, IRegion> region = new Dictionary<string, IRegion>();
            public static void AddRegion(string r, Rectangle Recobj)
            {
                region.Add(r, Recobj); 
            }
            public static void AddRegion(string c,Circle Cirobj)
            {
                region.Add(c, Cirobj);
            }
            public static void AddRegion(string t,Triangle Triobj)
            {
                region.Add(t, Triobj);
            }
            public static void RemoveRegion(string remove)
            {
                region.Remove(remove);
            }  
            public static Dictionary <string,IRegion> GetAllRegion()
            {
                return region;   
            } 
            public static Dictionary<string, IRegion> GetRegion()
            {
                return region;
            }
        }
        public interface IRegion
        {
            string Id { get; set; }
            string Name { get; set; }
            int No_Of_Edge { get;  }
            double GetArea();
            bool Intersect();
            bool MoveRegion(int offsetx, int offsety);
            bool Resize(int scalex, int scaley); 
        }
        public class Rectangle : IRegion
        {
            public string  Id { get; set; }
            public string Name { get; set; }
            public int No_Of_Edge { get; set; } = 4;
            public int X { get; set; }
            public int Y { get; set; }
            public int Length { get; set; }
            public int Breadth { get; set; } 
            public double GetArea()
            {
                return Length * Breadth;
            }
            public bool MoveRegion(int offsetx, int offsety)
            {
                if (offsetx - X > 0)
                {
                    X += offsetx;
                    Y += offsety;
                    return true;
                }
                return false;
            }
            public bool Resize(int scalex, int scaley)
            {
                Length += scalex;
                Breadth += scaley;
                X += scalex;
                Y += scaley;
                return true;
            }
            public bool Intersect()
            {
                return true;
            }
        }
        public class Circle : IRegion
        {
            public string  Id { get; set; }
            public string Name { get; set; }
            public int No_Of_Edge => 0;
            public int X { get; set; }
            public int Y { get; set; }
            public int Radius { get; set; }
            public double GetArea()
            {
                return 3.14 * Radius * Radius;
            }

            public bool MoveRegion(int offsetx, int offsety)
            {
                    if (offsetx - X > 0)
                    {
                        X += offsetx;
                        Y += offsety;
                        return true;
                    }
                    return false;
            }
            public bool Resize(int scalex, int scaley)
            {
                Radius += scalex;
                X += scalex;    
                Y += scaley;
                return true;
            }
            public bool Intersect()
            {
                throw new NotImplementedException();
            }
        }
        public class Triangle : IRegion
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public int No_Of_Edge => 3;
            public int X { get; set; }
            public int Y { get; set; }
            public int Height { get; set; }
            public int Breadth { get; set; }
            double IRegion.GetArea()
            {
                return 1/2*Height * Breadth ;
            }
            bool IRegion.MoveRegion(int offsetx, int offsety)
            { 
                   if (offsetx - X > 0)
                   {
                        X += offsetx;
                        Y += offsety;
                        return true;
                   }
                   return false;
            }
            bool IRegion.Resize(int scalex, int scaley)
            {
                Height += scalex;          
                Breadth += scaley;
                X = scalex+X;
                Y = scaley+Y;
                return true;
            }
            bool IRegion.Intersect()
            {
                throw new NotImplementedException();
            }
        }
}
