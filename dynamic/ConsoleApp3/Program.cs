using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static void Dfs(int[,] a, bool[,] vis, int n, int s, int e, int ans, List<string> li, string res)
        {
            Console.WriteLine(res);
            ans = ans * a[s, e];
            if (s < 0 || e < 0 || s >= n || e >= n || vis[s, e] || ans < 0) return;
            if (s == n - 1 && e == n - 1)
            {
                Console.WriteLine(ans);
                li.Add(res);
                return;
            }
            vis[s, e] = true;
            Dfs(a, vis, n, s + 1, e, ans, li, res + "d");
            Dfs(a, vis, n, s - 1, e, ans, li, res + "u");
            Dfs(a, vis, n, s, e + 1, ans, li, res + "r");
            Dfs(a, vis, n, s, e - 1, ans, li, res + "l");
            vis[s, e] = false;
        }
        public static void CC()
        {
            int[,] a = { {1,-2,1},{1,-2,1},{3,-4,1}};
            bool[,] vis = new bool[a.GetLength(0), a.GetLength(1)];
            List<string> li = new List<string>();
            Dfs(a,vis,a.GetLength(0), 0,0,1,li, "");
            Console.Write(String.Join(" ", li));
        }

        static void Main(string[] args)
        {
            //Class1 obj = new Class1();
            // Class2 obj1 = new Class2();
            // Class3 obj2 = new Class3();
            // Class4 obj3 = new Class4();
            // Class5 obj4 = new Class5();
            //Class6 obj5 = new Class6();
            // Class7 obj6 = new Class7();
            //pattern obj7 = new pattern();
            //int n = int.Parse(Console.ReadLine());
            // obj7.pat(n);
            // FLAMES obj8 = new FLAMES();
            //Class8 obj9 = new Class8();
            //Class9 obj9 = new Class9();
            // M();
            //MN();
            //MM();
            CC();
            Console.ReadLine();
        }
        public static void M()
        {
            int t = int.Parse(Console.ReadLine());
            while(t-->0)
            {
                int n = int.Parse(Console.ReadLine());
                int c = 0,ans=0;
                if(n<4)
                {
                    ans=c;
                    Console.WriteLine(ans);
                }
                else
                {
                    ans = (n / 2) - 1;
                    c = 0;
                    while(ans!=0)
                    {
                        c += ans;
                        ans--;
                    }
                    Console.WriteLine(c);

                }
               
            }
        }
        public static void MN()
        {
            int t = int.Parse(Console.ReadLine());
            while(t-->0)
            {
                int n = int.Parse(Console.ReadLine());
                string s = Console.ReadLine();
                s = s.ToLower();
                string v = "aeiou";
                int c = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = 0; j < v.Length; j++)
                    {
                        if (s[i]==v[j])
                        {
                            c++;
                        }
                    }
                }
                Console.WriteLine("c is : " + c);
                int ans = n-c;
                Console.WriteLine("ans is : " + ans);
                if (ans<4 && ans==n )
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
        public static void MM()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0;i<n;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int m = a[0],c = 0,v=0;
            //Console.WriteLine(m);
            while (c <= n)
            {
                while (m-- > 0)
                {
                    c++;
                }
                Console.WriteLine(c);
                if (c > n)
                {
                    break;
                }
                else
                {
                    m = a[c];
                    v++;
                } 
            }
            Console.WriteLine(v);

        }
    }
}
