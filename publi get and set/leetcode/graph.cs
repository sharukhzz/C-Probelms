using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    class graph
    {
        private static int n = int.Parse(Console.ReadLine());
        private static int[,] aa = new int[n-1, 2];
        private static int[,] ab = new int[n-1, 2];
        private static int[] arr = new int[n];
        static void Main(string[] args)
        {
            int i = 0, j = 0;
            int o = n;
            while (o-- > 1)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
                aa[i, j] = a[0];
                j++;
                aa[i, j] = a[1];
                i++;
                j = 0;
            }
            int k = int.Parse(Console.ReadLine());
            while (k-- > 0)
            {
               string[] su = Console.ReadLine().Split(' ');
               int x = int.Parse(su[1]);
               int y = int.Parse(su[2]);
               if (su[0] == "add")
               {
                   ADD(x, y);
               }
               else if (su[0] == "max")
                {
                    MAX(x, y);
                }
           }
            Console.ReadLine();
        }
        public static void ADD(int x,int y)
        {
            for(int i=0;i<n-1;i++)
            {
                for(int j=0;j<2;j++)
                {
                    if(aa[i,j]==x)
                    {
                        ab[i, j] = y;    
                    }
                    if (x == aa[i, j] && j == 0)
                    {
                        ab[i,j+1] = ab[i, j+1]+y;
                    }
                    
                }
            }
            Print();
            Print1();
        }
        public static void MAX(int x,int y)
        {
            int p = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (aa[i, j] == x || aa[i,j]==y)
                    {
                        arr[p] = ab[i, j];
                        p++;
                        if(x==aa[i,j] && j==0)
                        {
                            arr[p] = ab[i, j + 1];
                            p++;
                        }
                        else if(y==aa[i,j] && j==0)
                        {
                            arr[p] = ab[i, j + 1];
                            p++;
                        }
                        else if (x == aa[i, j] && j == 1)
                        {
                            arr[p] = ab[i, j - 1];
                            p++;
                        }
                        else if (y == aa[i, j] && j == 1)
                        {
                            arr[p] = ab[i, j - 1];
                            p++;
                        }
                    }
                    
                }
            }
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]!=0)
                {
                    if(max<arr[i])
                    {
                        max = arr[i];
                    }
                }
            }
            Console.WriteLine(max);
        }
        public static void Print1()
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void Print()
        {
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(ab[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void CountBits()
        {
            // List<int> li = new List<int>();
            // int[] a = new int[n+1];
            // for(int i=0;i<=n;i++)
            // {
            //     a[i] = a[i / 2] + i % 2;

            // }
            //int[] b=li.ToArray();
            //for(int j=0;j<a.Length;j++)
            // {
            //     Console.WriteLine(a[j]);
            // }
            // int c = n.ToString().Count(s => s == '1');
            // Console.WriteLine(c);
            //int n = int.Parse(Console.ReadLine());
            //int[,] aa = new int[n, 2];
            //int i = 0, j = 0;
            //while (n-- > 0)
            //{
            //    int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            //    aa[i, j] = a[0];
            //    j++;
            //    aa[i, j] = a[1];
            //    i++;
            //    j = 0;
            //}
            //string[] s = Array.ConvertAll(Console.ReadLine().Trim().Split(' '));
            //string s = Console.ReadLine();
            //string[] su = s.Split(' ');
            //Console.WriteLine(su[1]);

        }
    }
}
