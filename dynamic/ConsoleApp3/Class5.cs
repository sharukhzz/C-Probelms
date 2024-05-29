using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class5
    {
        int t = int.Parse(Console.ReadLine());
        public Class5()
        {
            while (t-- > 0)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                Console.WriteLine((a[0] + a[1]) % 2 == 0 ? "yes" : "no");
            }
        }
    }
}
