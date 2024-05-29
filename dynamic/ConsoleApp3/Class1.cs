using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class1
    {
        public int t = int.Parse(Console.ReadLine());
        public Class1()
        {
            while (t-- > 0)
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 7 == 0 && x % 2 == 0)
                {

                    Console.WriteLine("alice");
                }
                else if (x % 2 != 0 && x % 9 == 0)
                {
                    Console.WriteLine("bob");
                }
                else
                {
                    Console.WriteLine("charlie");
                }
            }
            Console.ReadLine();
        }
    }
}
