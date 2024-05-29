using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace ConsoleApp4
{
    /*class Class4
    {
        static void Ko(int [] a,int n,)
        {
            if (mini != a[0])
            {
                int x = a[0];
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    a[i] = a[i + 1];
                }
                a[(a.Length - 1)] = x;
                print(a, n);
                check(ref a, ref n);
            }
            else
            {
                remove(ref a, ref n, mini);
            }
           
        }
        static void print(int[] a,int n)
        {
            for (int j = 0; j < a.Length; j++)
            {
                Console.Write(" " + a[j]);
            }
            Console.WriteLine();
        }
        static void re(int []a)
        {
                    int p = 0, l = a.Length;
                    int[] b = new int[l - 1 - p];
                    for (int g=1;g<a.Length-1;g++)
                    {
                        b[g - 1] = a[g];
                    }
                    for (int f = 0; f<b.Length; f++)
                    {
                        Console.Write(" " + a[f]);
                    }
        }
        public Class4()
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            int l = a.Length;
            for (int i = 0; i < l; i++)
            {
                int p = 1;
                for (int j=i+1;j<l;j++)
                {
                    if(a[i]>a[j])
                    {
                        Ko(a,l);
                    }      
                }
                p++;   
            }

        }
    }
}*/