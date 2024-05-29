using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Class1
    {
        int t = int.Parse(Console.ReadLine());
        public Class1()
        {
            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int co = 0,max=0;
                for(int i=0;i<n;i++)
                {
                    co = 0;
                    for(int j=0;j<n;j++)
                    {
                        if(a[i]==a[j])
                        {
                            co++;
                        }
                    }
                    if(max<co)
                    {
                        max = co;
                    }
                }
                Console.WriteLine(Math.Abs(n - max));
            }
        }
    }
}
