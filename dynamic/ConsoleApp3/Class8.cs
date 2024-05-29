using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class8
    {
        int t = int.Parse(Console.ReadLine());
        public Class8()
        {
            while(t-->0)
            {
                int n = int.Parse(Console.ReadLine());
                int x = 0;
                int c = 0; 
                for(int k=0;k<n;k++)
                {
                    int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                    int[] b = new int[n];
                    b[x] = a[1] - a[0];
                    x++;
                    for(int i=0;i<b.Length;i++)
                    {
                        if(b[i]>5)
                        {
                            c++;
                        }
                    }
                }
                Console.WriteLine(c);
            }
        }
    }
}
