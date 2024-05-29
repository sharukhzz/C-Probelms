using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class1
    {
        int t = int.Parse(Console.ReadLine());
        public Class1()
        {
            while (t-- > 0)
            {
                int[] dn = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int d = dn[1];
                int n = dn[0];
                int y = 0;
                while (n > 0)
                {
                    int sum = 0;
                    for (int i = 1; i <= d; i++)
                    {
                        sum += i;
                    }
                   d = sum;
                    y = sum;
                    n--;
                }
                Console.WriteLine(y);
            }
        }
    }
}
