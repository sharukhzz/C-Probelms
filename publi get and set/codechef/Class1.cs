using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codechef
{
    class Class1
    {
        public static int BB()
        {
            string s = "a";
            Dictionary<char, int> di = new Dictionary<char, int>();
            foreach(var n in s)
            {
                if(di.ContainsKey(n))
                {
                    di[n] = di[n] + 1;
                }
                else
                {
                    di.Add(n, 1);
                }
                
            }
            int c = 0,k=0;
            foreach(var n in di.Keys)
            {
                    if(di[n]%2==0)
                    {
                        c = di[n] + c;
                    }
                else
                {
                    k+=di[n];
                }
            }
            c += (k % 2 == 0) ? k / 2 : k / 2 + 1;
            return c;
        }
        public static void Str()
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            List<int> li = new List<int>();
            //for(int i=0;i<ss.Length;i++)
            //{
            //    Console.WriteLine(ss[i] + " ");
            //}
            int t = 0,k1=0,k2=0,flag=0,flag2=0,flag3=0;
            for(int i=0;i<ss.Length;i++)
            {
                if (ss[i].Equals("//"))
                {
                    flag2 = 1;
                    //    Console.WriteLine("*");
                    t = i;
                    Console.WriteLine();
                    Console.WriteLine("Answer is : ");
                    for (int j = 0; j < t; j++)
                    {
                        int q = 0;
                        for (int u = 0; u < li.Count; u++)
                        {
                            if (li[u] == j)
                            {
                                q++;
                            }
                        }
                        if (q == 0)
                        {

                            Console.Write(ss[j] + " ");
                        }
             
                    }
                }
                else if (ss[i].Equals("/*") && flag2==0)
                {
                    flag = 1;
                    k1 = i;
                    li.Add(k1);
                    for(int j=k1+1;j<ss.Length;j++)
                    {
                        li.Add(j);
                        if(ss[j].Equals("*/"))
                        {
                            flag3 = 1;
                            k2 = j;
                            break;
                        }

                    }
                    if(flag3==0)
                    {
                        for(int d=k1;d<ss.Length;d++)
                        {
                            li.Remove(d);
                        }
                    }
                    //Console.WriteLine("k1 is : " + k1);
                    //Console.WriteLine("k2 is : " + k2);
                    for(int l=0;l<ss.Length;l++)
                    {
                        int m = 0;
                        for (int g = 0; g < li.Count; g++)
                        {
                            if (l==li[g])
                            {
                                m++;
                            }
                        }
                        //Console.Write(l);
                        if(m==0 && flag==1)
                        {
                            //Console.Write(l);
                            Console.Write(ss[l] + " ");
                        }
                    }
                }
                
                
            }
        }
        public static void Pq()
        {
            string s = "XXOX";
            s.ToLower();
            int st = 0, en = 2, c = 1;
            StringBuilder su = new StringBuilder(s);
            while (en <= s.Length)
            {
              
                for (int i = st; i <= en; i++)
                {
                    if (s[i] == 'x')
                    {
                        su.Replace('x', '0');
                    }
                }
                int u = 0;
                for (int j = 0; j < su.Length; j++)
                {
                    if (su[j] == 'x')
                    {
                    }
                    else
                    {
                        u++;
                    }
                }
                if (en < s.Length)
                {
                    st++;
                    en++;
                    c++;
                    Console.Write("*");
                }
                if (u == s.Length)
                {
                    en++;
                }
            }
            Console.WriteLine("c is : " + c);
        }
        public static int MM()
        {
            string s = "pwwkew";
            int m = 0;
            string l = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i+1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        string k = s.Substring(i, j - i );
                        Console.WriteLine("substring : "+k);
                        if (IsMatch(k))
                        {
                            m = (k.Length > m) ? k.Length : m;
                            l = (k.Length > l.Length) ? k : l;
                        }
                        
                    }
                }
            }
            Console.WriteLine(l);
            return m;
           
        }
        public static bool IsMatch(string k)
        {
            Dictionary<char, int> di = new Dictionary<char, int>();
            foreach(var n in k)
            {
                if (di.ContainsKey(n))
                {
                    return false;
                }
                else
	            {
                    di.Add(n, 1);
                }
            }
            return true;
        }
        //public static void HH(int index,int[] nums)
        //{
        //    if(nums==index-1)
        //}
    }
}
