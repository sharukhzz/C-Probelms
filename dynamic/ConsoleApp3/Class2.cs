using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class2
    {
        public int t = int.Parse(Console.ReadLine());
        public Class2()
        {
            while (t-- > 0)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                int x = a[0];
                int y = a[1];
                if (y > x)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(x / y);
                }
            }
        }
    }
}
