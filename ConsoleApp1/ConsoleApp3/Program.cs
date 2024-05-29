using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Sum(int r, int c)
        {
            int[,] a = new int[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(a[i, j]+" ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("splitting row : ");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("splitting coloumn : ");
            int w = int.Parse(Console.ReadLine());
            int[] sum = new int[100];
            int[] s1 = new int[100];
            int[] s2 = new int[100];
            int[] s3 = new int[100];
            int[] s4 = new int[100];
            int l1 = 0, l3 = w, x = 0;
            while (((l3 - 1) < c))
            {
                int m1 = 0,m3 = q;
                while ((m3 - 1) < r)
                {
                    int su = 0;
                    //l2 = Math.Abs(c - Math.Abs(((c - 3) - l3)));
                    //m2 = Math.Abs(r - Math.Abs(((r - 3) - m3)));
                    for (int i = m1; i < m3; i++)
                    {
                        for (int j = l1; j < l3; j++)
                        {
                            su += a[i, j];
                        }
                    }
                    sum[x] = su;
                    s1[x] = m1;
                    s2[x] = l1;
                    s3[x] = m3;
                    s4[x] = l3;
                    x++;
                    m1++;
                    m3++;
                }
                l1=l1+1;
                l3=l3+1;
            }
            Console.WriteLine("the sum matrix is : ");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(sum[i]);
            }
            int m = sum[0];
            int u = 0;
            for(int i=0;i<sum.Length-1;i++)
            {
                if (sum[i] != 0)
                {
                    if (m < sum[i])
                    {
                        m = sum[i];
                        u = i;
                    }
                }
            }
            Console.WriteLine("highest sum is : "+m);
            Console.WriteLine("the highest sum matrix element is : ");
            for(int i=s1[u];i<s3[u];i++)
            {
                for(int j=s2[u];j<s4[u];j++)
                {
                    Console.Write(a[i, j]+" ");
                }
                Console.WriteLine();
            }
            int min = sum[0];
            int um = 0;
            for(int i=0;i<sum.Length;i++)
            {
                if (sum[i] != 0)
                {
                    if (sum[i] <= min)
                    {
                        min = sum[i];
                        um = i;
                    }
                }
            }
            Console.WriteLine("lowest sum is : "+min);
            Console.WriteLine("the lowest sum matrix element is : ");
            for (int i = s1[um]; i < s3[um]; i++)
            {
                for (int j = s2[um]; j < s4[um]; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("no of row : ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("no of coloumn : ");
            int c = int.Parse(Console.ReadLine());
            if (r >= 3 && c >= 3)
            {
                Sum(r, c);
            }
            Console.ReadLine();
        }
    }
}