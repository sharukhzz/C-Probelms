using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class3
    {
        int t = int.Parse(Console.ReadLine());
        public Class3()
        {
            while (t-- > 0)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                Console.WriteLine(Math.Abs(a[0] * a[1] - a[0] * a[2]));
            }
        }
    }
}




