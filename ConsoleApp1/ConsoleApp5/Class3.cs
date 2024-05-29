using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class3
    {
        int t = int.Parse(Console.ReadLine());
        public Class3()
        {
            while (t-- > 0)
            {
                string[] s1 = Console.ReadLine().Split(' ');
                int x1 = int.Parse(s1[0]);
                int x2 = int.Parse(s1[1]);
                string[] s2 = Console.ReadLine().Split(' ');
                int x11 = int.Parse(s2[0]);
                int x22 = int.Parse(s2[1]);
                string[] s3 = Console.ReadLine().Split(' ');
                int x111 = int.Parse(s3[0]);
                int x222 = int.Parse(s3[1]);
                int[] a = new int[3];
                a[0] = x1 + x2;
                a[1] = x11 + x22;
                a[2] = x111 + x222;
                int max = a[0];
                for(int i=0;i<3;i++)
                {
                    if(max<a[i])
                    {
                        max = a[i];
                    }
                }
                Console.WriteLine(max);   
            }
        }
    }
}
