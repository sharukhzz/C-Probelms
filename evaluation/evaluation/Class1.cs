using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluation
{
    class Class1
    {
        static void Main(String[] args)
        {

            Console.WriteLine("how many function needed to call : ");
            int nnn = int.Parse(Console.ReadLine());
            while (nnn-- > 0)
            {
                Console.WriteLine("\n1.AddRegion\n2.RemoveRegion\n3.GetAllregion\n4.GetRegion\n5.Print");
                int nn = int.Parse(Console.ReadLine());
                if (nn == 1)
                {
                    Console.WriteLine("how many times to enter inputs : ");
                    int n = int.Parse(Console.ReadLine());
                    while (n-- > 0)
                    {
                        Console.WriteLine("names are ");
                        Console.WriteLine("circle" + " " + "rectangle" + " " + "triangle");
                        Console.WriteLine("enter the name : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("enter the noofedge : ");
                        int noofedge = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter the id : ");
                        int id = int.Parse(Console.ReadLine());
                        if (name == "rectangle")
                        {
                            Console.WriteLine("enter the name : ");
                            string Name = Console.ReadLine();
                            Console.WriteLine("enter the length : ");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter the breadth : ");
                            int y = int.Parse(Console.ReadLine());
                            RegionManager.AddRegion(Name, x, y);
                        }
                        if (name == "circle")
                        {
                            Console.WriteLine("enter the name : ");
                            string Name = Console.ReadLine();
                            Console.WriteLine("enter the radius : ");
                            int radius = int.Parse(Console.ReadLine());
                            RegionManager.AddRegion(Name, radius);
                        }
                        if (name == "triangle")
                        {
                            Console.WriteLine("enter the name : ");
                            string Name = Console.ReadLine();
                            Console.WriteLine("enter the length : ");
                            int l = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter the breath : ");
                            int b = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter the height : ");
                            int h = int.Parse(Console.ReadLine());
                            RegionManager.AddRegion(Name, l, b, h);
                        }
                    }
                }
                if (nn == 5)
                {
                    RegionManager.Print();
                }
            }
            Console.ReadLine();
        }
    }
}
