using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class4
    {
        int t = int.Parse(Console.ReadLine());
        public Class4()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
            int[] b = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
            int c = 0;
            for (int i=0;i<n;i++)
            {
                if(a[i]<b[i])
                {
                       if(b[i]<= 2*a[i])
                        {
                        c++;
                        }
                }
                else
                {
                    if(a[i]<=2*b[i])
                    {
                        c++;
                    }
                }
            }
            Console.WriteLine(c);
        }
    }
}
