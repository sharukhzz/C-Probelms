using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ratinmaze
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[,] a = new int[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
                //Console.WriteLine();
            }
            //ratinmazes(a,n);
            //Rat2(a, r,c);
            Water(a, r, c);
         }
        public static void ratinmazes(int [,] a,int n)
        { 
            int f = 1,ans=0;
            int s = 0, e = 0;
            while (s < n - 1 && e < n - 1)
            {
                      if (a[0, 0] == 0 && a[n - 1, n - 1] == 0)
                      {
                         f = 0;
                        break;
                      }
                     else if (a[s, e] == 1)
                     {
                        if (a[s, e + 1] == 1 && ans==0)
                        {
                            e = e + 1;
                            
                        }
                        else if (a[s + 1, e] == 1 && ans==1)
                        {
                            s = s + 1;
                            
                        }
                    else if (a[s + 1, e] == 1 && ans == 0)
                    {
                        s = s + 1;

                    }
                    else if(a[s,e+1]== 0 && ans==0)
                        {
                        e = e - 1;
                        ans++;
                        }
                        else if(a[s+1,e]==0 && ans==1)
                        {
                        ans++;
                        }
                    if (ans > 1)
                    {
                        f = 0;
                        break;
                    }
                }

                      
            }

            if (f == 0)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine("found");
            }

            Console.ReadLine();
        }
        public static void Rat2(int[,] a,int r,int c)
        {
            int k1 = 0, k2 = 0;
            for(int i=0;i<r;i++)
            {
                for(int j=0;j<c;j++)
                {
                    if(a[i,j]==2)
                    {
                        k1 = i;
                        k2 = j;
                    }
                }
            }
            int s = k1, e = k2,c1=0,c2=0,c3=0,c4=0;
            int[] a1 = new int[10];
            while(e<4 && e>=0 && s<4 && s>=0)
            {
                if(a[s,e+1]==0)
                {
                    e = e + 1;
                    a[s, e ] = 3;
                    a1[0] = c1++;
                }
                else if(a[s,e-1]==0)
                {
                    e = e - 1;
                    a1[1] = c2++;
                    Console.WriteLine(c2);
                    if (s == 0 || e == 0 || s == 3 || e == 3)
                    {
                            break;
                    }
                }
                else if(a[s+1,e]==0)
                {
                    s = s + 1;
                    a[s, e] = 3;
                    a1[2] = c3++;
                }
                else if(a[s-1,e]==0)
                {
                    s = s - 1;
                    a[s, e] = 3;
                    a1[3] = c4++;
                }

                else if (s == 0 || e == 0)
                {
                    break;
                }
                Console.WriteLine(s + " " + e);
            }
            for(int i=0;i<a1.Length;i++)
            {            
                    Console.WriteLine(a1[i]);
            }
        }
        public static void Water(int[,] a,int r,int c)
        {
            int k = 0;
            int min = a[0, k];
            for(int i=0;i<r;i++)
            {
                if(min>a[i,k])
                {
                    min = a[i, k];
                }
            }
            Console.WriteLine(min);
        }
    }
}
