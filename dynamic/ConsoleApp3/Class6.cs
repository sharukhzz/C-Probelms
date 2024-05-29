using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class6
    {
        int t = int.Parse(Console.ReadLine());
        public Class6()
        {
            while (t-- > 0)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                Console.WriteLine(a[0].Equals(a[1]) &&  a[0].Equals(a[2]) ? "0" : "1");
            }
        }
    }
}
