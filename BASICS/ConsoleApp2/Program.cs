using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        private static void Substring()
        {
            int t = int.Parse(Console.ReadLine());
            while(t-->0)
            {
                int n = int.Parse(Console.ReadLine());
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();
                /*   if (s1.Equals(s2))
                   {
                       Console.WriteLine("Yes");
                   }
                   else
                   {
                       int flag = 0;
                       int x = 0, y = 2;
                       while (x < s2.Length)
                       {
                           string s3 = "";
                           string s4 = "";
                           string s5 = "";
                           s3 = s2.Substring(x, y);
                           char[] s6 = s3.ToCharArray();
                           Array.Reverse(s6);
                           s5= s6.ToString();
                           Console.WriteLine(s5);
                           s4 += s2[x];
                           s4 = s3;
                           s4 += s2[y];
                           //Console.WriteLine(s4);
                           if(s4.Equals(s1))
                           {
                               flag = 1;
                               break;
                           }
                           y++;
                           if (y == s2.Length)
                           {
                               x++;
                               y = x+1;
                           }

                       }
                       if(flag==1)
                       {
                           Console.WriteLine("yes");
                       }
                       else
                       {
                           Console.WriteLine("no");
                       }*/
                int K = 1;
                for(int i=0;i<s1.Length;i++)
                {
                    if(s1[i]=='1')
                    {
                        K++;
                    }
                }
                Console.WriteLine("k1 is : " + K);
                for (int i = 0; i < s2.Length; i++)
                {
                    if (s2[i] == '1')
                    {
                        K--;
                    }
                }
                Console.WriteLine("k2 is : " + K);
                if (K==1)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            
        }
        public static void Pal()
        {
            String s1 = Console.ReadLine();
            string s2 = "";
            int flag = 0;
            for(int i=s1.Length-1;i>=0;i--)
            {
                s2 += s1[i];
            }
            if(s1.Equals(s2))
            {
                flag = 1;
            }
            Console.WriteLine(flag);
        }
        public static void Pal12()
        {
            int t = int.Parse(Console.ReadLine());
            while(t-->0)
            {
                int n = int.Parse(Console.ReadLine());
                string s = Console.ReadLine();
                int x = 0, y = 2,flag=0;
                int X1 = 0, X2 = 0;
                while (x<=s.Length-1 ||y<=s.Length+2)
                {
                    string s1 = s.Substring(x, y);
                    Console.WriteLine(s1+" ");
                    string s2="";
                    for (int i = s1.Length - 1; i >= 0; i--)
                    {
                        s2 += s1[i];
                    }
                    if (s1.Equals(s2))
                    {
                        X1 = x;
                        X2 = y;
                        flag = 1;
                        break;
                    }
                   
                }
                Console.WriteLine(flag);
                Console.WriteLine("x is : " + X1);
                Console.WriteLine("x2 is : " + X2);

            }
        }
        public static void PALL()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                string s = Console.ReadLine();
                int max = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    int c = 0;
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (s[i] == s[j])
                        {
                            c++;
                        }
                    }
                    if(c>max)
                    {
                         max=c;
                    }
                }
               // Console.WriteLine(max);
                if (max == 1)
                {
                    Console.WriteLine("-1");
                }
                else
                {
                    Console.WriteLine(s.Length - max);
                }
            }
            
        }
        public static void Sort()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {

                /*char[] a = s.ToCharArray();
                Array.Sort(a);
                string s1 = new string(a);
                Console.WriteLine("s1 is :"+s1 );
                int x = 0, c = 0;
                while (x < s.Length)
                {
                    if (s[x] != s1[x])
                    {
                        c++;
                    }
                    x++;
                }
               Console.WriteLine(c);*/
                int n = int.Parse(Console.ReadLine());
                string s = Console.ReadLine();
                int co = 0;
               for(int i=0;i<s.Length-1;i++)
                {
                    if(s[i] == '1' &&  s[i + 1]== '0')
                    {
                        co++;
                    }
                    
                }
                Console.WriteLine(co);
                //List<int> u = new List<int>();
                //u.Add(1);
                //u.Add(2);
                //u.Sort();
                //string st = "aew";
                //string j = st.ToLower();
            }
        }
        public static void Rough()
        {
            int[] n1 = { 1, 2, 2, 1 };
            int[] n2 = { 2, 2 };
            int[] x = n1.Distinct().ToArray();
            Console.WriteLine(x);
            
        }
        static void Main(string[] args)
        {
            //string[] d = Console.ReadLine().Split('.');
            // DateTime d1 = new DateTime(2003,01,05);
            //DateTime cd = DateTime.Now;

            //int date = int.Parse(d[0]);
            //foreach(string da in d)
            //{
            //    Console.WriteLine(da);
            //}
            //Console.WriteLine(d);
            // Class1 obj = new Class1();
            //Tablet();
            //Substring();
            // Pal();
            // Pal12();
            //PALL();
            //Sort();
            //Rough();
            //RR();
            RT();
            Console.ReadLine();
            
        }
        public static void Tablet()
        {
            int t = int.Parse(Console.ReadLine());
            while(t-->0)
            {
                int[] n = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                int nu = n[0], p = n[1],space=0;
                while(nu-->0)
                {
                    int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                    if (a[2] <= p && space < a[0] * a[1])
                    {
                        space=a[0]*a[1];
                    }
                }
                if (space != 0)
                {
                    Console.WriteLine(space);
                }
                else
                {
                    Console.WriteLine("");
                }
            }
        }
        public static void RR()
        {
            string word = "cuaieuouac";
            string v = "aeiou";
            string w = word.ToLower();
            int m = 5;
            int s = 0, e = m;
            int ans = 0;
            while (e <= w.Length )
            {
                //Console.WriteLine(w.Substring(s,e));

                //Console.Write("zdf ");
                if (e <= w.Length)
                {
                    string h = w.Substring(s, e);
                    int c = 0;
                    for (int j = 0; j < h.Length; j++)
                    {

                        if (v.Contains(h[j]))
                        {
                            c++;
                            if (c == 5)
                            {
                                break;
                            }
                        }
                    }
                    if (c >= 5)
                    {
                        ans++;
                        Console.WriteLine(h);
                    }
                    e++;
                    if (e == w.Length-1)
                    {
                        s += 1;
                        e = m + 1;
                    }
                }
                
            }
            Console.Write("c is : " + ans);
        }
        public static void RT()
        {
            int n = -17;
            int flag = 1;
            for(int i=4;i<n;i++)
            {
                if(n%5!=0)
                {
                    if (n < 0)
                    {
                        flag = 0;
                    }
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
       

    }
}
