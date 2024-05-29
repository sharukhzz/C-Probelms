using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class3
    {
        public static void Fu()
        {
            int[] n = { 1,  0, 1, 1,0, 1 };
            int c = 0,max=0;
            for(int i=0;i<n.Length;i++)
            {
                if(n[i]==1)
                {
                    c++;
                }
                else
                {
                    c = 0;
                }
                if(max<c)
                {
                    max = c;
                   // Console.WriteLine(c);
                }
            }
            Console.WriteLine(max);
        }
        public static void D()
        {
           string[] s1 = { "happy","sad","good "};
           string[] s2 = { "sad","happy","good"};
            int max =1000;
            List<string> s = new List<string>();
            for(int i=0;i<s1.Length;i++)
            {
                for(int j=0;j<s2.Length;j++)
                {
                    if(s1[i]==s2[j] && i+j<=max)
                    {
                        s.Clear();
                        max = i + j;
                        s.Add(s1[i]);
                    }
                    else
                    {
                        max = i + j;
                        s.Add(s1[j]);
                    }
                }
               
            }
            for(int i=0;i<s.Count;i++)
            {
                Console.Write(s[i] + i+" ");
            }
        }
        public static void G()
        {
            int n = 2, k = 2;
            int c = 1;
            List<int> li = new List<int>();
            List<int> res = new List<int>();
            while (c <= n)
            {
                if (c > 1)
                {
                    for (int i = 0; i < li.Count; i++)
                    {
                        if (li[i] == 0)
                        {
                           // li.Remove(0);
                            //li.Add(0);
                            li.Add(1);
                            res.Add(0);
                            res.Add(1);
                        }
                        else
                        {
                            //li.Remove(1);
                            //li.Add(1);
                            li.Add(0);
                            res.Add(1);
                            res.Add(0);
                        }
                        if (c == n)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    li.Add(0);
                    res.Add(0);
                    if (c == n)
                    {
                        break;
                    }
                }
                c++;
            }
            li.Clear();
            for (int i = 0; i < res.Count; i++)
            {
                Console.Write(res[i] + " ");
                li.Add(res[i]);
            }
            res.Clear();
           Console.Write("ans is "+ li.IndexOf(k - 1));
        }
     
    }
    
}
