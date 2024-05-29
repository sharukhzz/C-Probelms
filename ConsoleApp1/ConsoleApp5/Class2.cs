using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class2
    {
        int t = int.Parse(Console.ReadLine());
        public Class2()
        {
            while (t-- > 0)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int r = a[0];
                int c = a[1];
                if(r==1 && c==1)
                {
                    Console.WriteLine("1");
                }
                else if(r % 2 == 0 && c%2==0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    int sum = Math.Abs(r - c);
                    if(r%2==0)
                    {
                        Console.WriteLine(r * sum);
                    }
                    else
                    {
                        Console.WriteLine(c * sum);
                    }
                }

            }
        }
    }
}
