using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leettt
{
    class Class1
    {
        public static int A()
        {
            ////string s = "s";
            ////s.replace(s[0], s[0]);
            int[] dist = { 4, 2, 8 };
            int[] speed = { 2, 1, 4 };
            var ans =  (int[])dist.Clone();
            int c = 0;
            for (int i = 0; i < dist.Length; i++)
            {
                if (ans[i] == 0 && i<dist.Length-1)
                {
                    //Console.WriteLine(dist[i]);
                    //Console.WriteLine(speed[i]);
                    break;
                }
                else if (dist[i] >= ans[i])
                {
                    for (int j = i; j < dist.Length; j++)
                    {
                        ans[j] = ans[j] - speed[j];
                        if (ans[j] < 0)
                        {
                            ans[j] = 0;
                        }
                        //Console.WriteLine(i);
                        //Console.WriteLine(j);
                        //Console.WriteLine("ans :"+ans[j]);
                        //Console.WriteLine("%%");
                    }
                   Console.WriteLine(String.Join(",", ans));
                    c++;
                }
                
                Console.WriteLine(String.Join(",,", dist));
            }
            return c;
        }
    }
}
