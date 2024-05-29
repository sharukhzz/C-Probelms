using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codechef
{
    class Class7
    {
        public static void V()
        {
            string s = "aaaabbbbcccc";
            //string h =new string( s.Distinct().ToArray());
            //Console.WriteLine(h);
            //List<int> li = new List<int>();
            //int[] a = new int[s.Length];
            Dictionary<char, int> di = new Dictionary<char, int>();
            foreach(var n in s)
            {
                if(di.ContainsKey(n))
                {
                    di[n] = di[n] + 1;
                }
                else
                {
                    di.Add(n,1);
                }
            }
            Console.WriteLine(String.Join(" ", di));
            var di2 = di.OrderBy(x => x.Key).ToList();
            Console.WriteLine(String.Join(" ", di2));
            string k = "";
            foreach(var n in di2)
            {
                k+=n.Key;
            }
            Console.WriteLine(k);
            int flag = 0;
            string ans = "";
            while(ans.Length<s.Length)
            {
                if(flag==0)
                {
                    for(int i=0;i<k.Length;i++)
                    {
                        ans += k[i];
                    }
                    flag = 1;
                }
                else
                {
                    for(int i=k.Length-1;i>=0;i--)
                    {
                        ans += k[i];
                    }
                    flag = 0;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
