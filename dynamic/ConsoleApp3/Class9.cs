using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class9
    {
        int t = int.Parse(Console.ReadLine());
        public Class9()
        {
            while(t-->0)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int n = a[0], s = a[1], r = a[2], x = a[3];
                if (n < s)
                {
                    n += r; 
                }   
                else
                {
                    s+=r;
                }
                if(n<s)
                {
                    n += x;
                }
                else
                {
                    s += x;
                }
                if(n>=s)
                {
                    Console.WriteLine("N");
                }
                else
                {
                    Console.WriteLine("S");
                }
            }
        }
    }
}
