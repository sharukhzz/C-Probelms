using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class Program
    {
        static string r = "r",c="c",t="t";
        static int cr = 0,cc=0,ct=0;
        static void Main(string[] args)
        {
            Console.WriteLine("REGION MANAGEMENT SYSTEM");
            while (true)
            {
                Console.WriteLine("\n1.AddRegion\n2.RemoveRegion\n3.GetAllRegion\n4.GetRegion\n5.GetArea\n6.MoveRegion\n7.ReSize\n8.Intersect");
                int nn = int.Parse(Console.ReadLine());
                switch (nn)
                {
                    case 1:
                        Console.WriteLine("\n1.Rectangle\n2.Circle\n3.Triangle");
                        Console.WriteLine("Enter the shape of the region by their number : ");
                        int no = int.Parse(Console.ReadLine());
                        if (no == 1)
                        { 
                            cr++;
                            Console.WriteLine("Enter the x region: ");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the y region: ");
                            int y = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Length : ");
                            int Length = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Breadth : ");
                            int Breadth = int.Parse(Console.ReadLine());
                            r += cr;
                            Rectangle Recobj = new Rectangle
                            {
                                X = x,
                                Y = y,
                                Length = Length,
                                Breadth = Breadth,
                                Id = r,
                                Name = "Rectangle " + cr
                            };
                            RegionManager.AddRegion(r, Recobj);
                            r = "r";
                        }
                        if (no == 2)
                        {
                            cc++;
                            Console.WriteLine("Enter the x region: ");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the y region: ");
                            int y = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Radius region: ");
                            int radius = int.Parse(Console.ReadLine());
                            c += cc;
                            Circle Cirobj = new Circle
                            {
                                X = x,
                                Y = y,
                                Radius = radius,
                                Id = c,
                                Name = "Circle " + cc,
                            };
                            RegionManager.AddRegion(c, Cirobj);
                            c = "c";
                        }
                        if(no==3)
                        {
                            ct++;
                            Console.WriteLine("Enter the x region: ");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the y region: ");
                            int y = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Height region: ");
                            int height = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the breadth region: ");
                            int breadth = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Length region: ");
                            int length = int.Parse(Console.ReadLine());
                            t += ct;
                            Triangle Triobj = new Triangle
                            {
                                X = x,
                                Y = y,
                                Height = height,
                                Breadth = breadth,
                                Id = t,
                                Name = "Triangle " + ct,
                            };
                            RegionManager.AddRegion(t, Triobj);
                            t = "t";
                        }
                        break;
                    case 2:
                        RegionManager.GetAllRegion();
                        Console.Write("Enter the id to Remove Region : ");
                        string remove = Console.ReadLine();
                        RegionManager.RemoveRegion(remove);
                        Console.WriteLine("After remove region : ");
                        RegionManager.GetAllRegion();
                        break;
                    case 3:
                        Dictionary <string,IRegion> di=RegionManager.GetAllRegion();
                        Display(di);
                        break;
                    case 4:
                       
                        Dictionary<string,IRegion> dii=RegionManager.GetRegion();
                        DisplayRegion(dii);
                        break;
                    case 5:
                         Console.WriteLine("Enter the id to get area :");
                         string s = Console.ReadLine();
                         Dictionary<string, IRegion> di2 = RegionManager.GetAllRegion();
                         foreach(var n in di2)
                         {
                            if(s.Equals(n.Key))
                            {
                                Console.WriteLine("area is : "+n.Value.GetArea());
                            }
                         }
                        break;
                    case 6:
                        Console.WriteLine("Enter the id to move region :");
                        string ss = Console.ReadLine();
                        Console.WriteLine("enter the x cordinates : ");
                        int offsetx = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter the y cordinates : ");
                        int offsety = int.Parse(Console.ReadLine());
                        Dictionary<string, IRegion> di3 = RegionManager.GetAllRegion();
                        foreach (var n in di3)
                        {
                            if (ss.Equals(n.Key))
                            {
                                Console.WriteLine("area is : " + n.Value.MoveRegion(offsetx,offsety));
                            }
                        }
                        break;
                    case 7:
                        Dictionary<string, IRegion> di23 = RegionManager.GetAllRegion();
                        Display(di23);
                        Console.WriteLine("Enter the id to move region :");
                        string ss2 = Console.ReadLine();
                        Console.WriteLine("enter the x cordinates : ");
                        int scalex = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter the y cordinates : ");
                        int scaley = int.Parse(Console.ReadLine());
                        Dictionary<string, IRegion> di4 = RegionManager.GetAllRegion();
                        foreach (var n in di4)
                        {
                            if (ss2.Equals(n.Key))
                            {
                                Console.WriteLine("area is : " + n.Value.Resize(scalex, scaley));
                            }
                        }
                        break;
                    case 8:
                        Dictionary <string, IRegion> di22 = RegionManager.GetAllRegion();
                        Display(di22);
                        Console.WriteLine("Enter the id to move region :");
                        string sss1 = Console.ReadLine();
                        Console.WriteLine("Enter the id to move region :");
                        string sss2 = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Enter the valid inputs ");
                        break;
                }
            }
        }
        public static void Display(Dictionary<string,IRegion> regions)
        {
            if(regions.Count==0)
            {
                Console.WriteLine("No shapes");
            }
            foreach (var n in regions)
            {
                if (n.Value is Rectangle Recobj)
                {
                    Console.WriteLine("id : " + Recobj.Id + " " + "name : " + Recobj.Name + " " + "noofedge : " + Recobj.No_Of_Edge + " " + "x : " + Recobj.X + " " + "y : " + Recobj.Y + " " + "Length : " + Recobj.Length + " " + "Breath : " + Recobj.Breadth);
                }
                if (n.Value is Circle Cirobj)
                {
                    Console.WriteLine("id : " + Cirobj.Id + " " + "name : " + Cirobj.Name + " " + "noofedge : " + Cirobj.No_Of_Edge + " " + "x : " + Cirobj.X + " " + "y : " + Cirobj.Y + " " + "radius : " + Cirobj.Radius);
                }
                if (n.Value is Triangle Triobj)
                {
                    Console.WriteLine("id : " + Triobj.Id + " " + "name : " + Triobj.Name + " " + "noofedge : " + Triobj.No_Of_Edge + " " + "x : " + Triobj.X + " " + "y : " + Triobj.Y + " " + "Height : " + Triobj.Height + " " + "Breath : " + Triobj.Breadth);
                }
            }
        }
        public static void DisplayRegion(Dictionary<string, IRegion> regions)
        {
            Console.WriteLine("\n1.Rectangle\n2.Circle\n3.Triangle");
            Console.WriteLine("Enter the shape of the region by their number : ");
            int nu = int.Parse(Console.ReadLine());
            switch (nu)
            {
                case 1:
                    foreach (var n in regions)
                    {
                        if (n.Value is Rectangle Recobj)
                        {
                            Console.WriteLine("id : " + Recobj.Id + " " + "name : " + Recobj.Name + " " + "noofedge : " + Recobj.No_Of_Edge + " " + "x : " + Recobj.X + " " + "y : " + Recobj.Y + " " + "Length : " + Recobj.Length + " " + "Breath : " + Recobj.Breadth);
                        }
                    }
                    break;
                case 2:
                    foreach (var n in regions)
                    {
                        if (n.Value is Circle Cirobj)
                        {
                            Console.WriteLine("id : " + Cirobj.Id + " " + "name : " + Cirobj.Name + " " + "noofedge : " + Cirobj.No_Of_Edge + " " + "x : " + Cirobj.X + " " + "y : " + Cirobj.Y + " " + "radius : " + Cirobj.Radius);
                        }
                    }
                    break;
                case 3:
                    foreach (var n in regions)
                    {
                        if (n.Value is Triangle Triobj)
                        {
                            Console.WriteLine("id : " + Triobj.Id + " " + "name : " + Triobj.Name + " " + "noofedge : " + Triobj.No_Of_Edge + " " + "x : " + Triobj.X + " " + "y : " + Triobj.Y + " " + "Height : " + Triobj.Height + " " + "Breath : " + Triobj.Breadth);
                        }
                    }
                    break;
            }
        }
    }
}
    