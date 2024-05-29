using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* for(int i=0;i<100;i++)
             {
                 Console.WriteLine(i);
             }*/
            //Class1 obj = new Class1();
            // obj.t = 1;
            // int t = int.Parse(Console.ReadLine());
            //Funcs(t);
            //  F(t);
            // FF();
            //Class2 obj = new Class2();

            //Class3.Fu();
            // Class3.D();
            // Class3.G();
            //Clas p = new Clas();
            //Clas.L();
            // Clas.PP();
            // Class4 i = new Class4();
            // Class4.U();
            //Class4.UI();
            //  Class5.MM();
            int[][] points = new int[3][] {new int[]{100,200,100 },new int[]{ 200,50,200},new int[]{ 100, 200, 100 }
            };
            int[][] res=Class5.ImageSmoother(points);
            for(int i = 0; i < res.Length; i++)
            {
                for(int j = 0; j < res[i].Length; j++)
                {
                    Console.Write(res[i][j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public static void Funcs(int t)
        { 
            while(t-->0)
            {
                int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                int n = a[0];
                int w1 = a[1];
                int w2 = a[2];
                int[] aa = new int[n];
                aa=Array.ConvertAll(Console.ReadLine().Trim().Split(),int.Parse);
                Array.Sort(aa);
                int c = 0, max = 0;
                for(int i=0;i<n;i++)
                {
                    if(a[i]==a[i+1])
                    {
                        c+=2;
                        max = a[i];
                        Console.WriteLine(c);
                    }
                    i++;
                }
                int ans =  w2 + (c * max);
                if(ans>=w1)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
        public static void F(int t)
        {
            while(t-->0)
            {
                int n1 = int.Parse(Console.ReadLine());
                int[] a1 = new int[n1];
                a1 = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                int n2 = int.Parse(Console.ReadLine());
                int[] a2 = new int[n2];
                a2 = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                int[] a = new int[n1 + n2];
               for(int k=0;k<a1.Length;k++)
                {
                    a[k] = a1[k];
                }
                int i = 0;
                while (n2-- > 0)
                {
                    a[n1] = a2[i];
                    n1++;
                    i++ ;
                }
                int s = 0, e = 1,max=0;
                while (s < a.Length)
                {
                    int sum = 0;
                    for (int x = s; x < e; x++)
                    {
                        sum += a[x];
                        Console.WriteLine(a[x]);
                    }
                   
                    if (max<sum)
                    {
                        max = sum;
                    }
                    e++;
                    if(e>=a.Length-1)
                    {
                        s++;
                        e = s;
                    }
                    
                }
                Console.WriteLine(max);
            }
        }
        public static void FF()
        {
            //int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(),int.Parse);
            //List<int > d = a.Distinct().ToList();
            //d.Sort();
            //int ans = 0;
            //if (d.Count < 3)
            //{
            //    ans = d[d.Count - 1];
            //}
            //else
            //{
            //    ans = d[d.Count-3];
            //}
            //Console.WriteLine(ans);
            /* string s = "  ";
             string[] su = s.Split(' ');
             int count = 0;
              foreach(string n in su)
             {
                 if(n!= string.Empty && n!=" ")
                 {
                     count++;
                 }
             }
             Console.WriteLine(count);
             string.IsNullOrEmpty(s);*/
            int n = 5,x=0;
            string ans = "";
            while(n>0)
            {
                ans = n % 2 + ans;
                n = n / 2;
            }
            Console.WriteLine(ans);
            string s = ans;
            string su="";
            for(int i=0;i<s.Length;i++)
            {
               if(s[i]=='1')
                {
                    su += '0';
                }
               else if(s[i]=='0')
                {
                    su += '1';
                }
            }
            Console.WriteLine(su);
            int suu = int.Parse(su);
            while(suu>0)
            {
               if(suu%10!=0)
                {
                    x = x * 10 + 2;
                }
               suu = suu / 10;
            }
            Console.WriteLine(x);
            double y = 0;
            for(int i=0;i<su.Length;i++)
            {
                if(su[i]=='1')
                {
                    y += Math.Pow((double)2 ,(double)(su.Length - (i+1)));
                }
            }
            int yy = (int)y;
            Console.WriteLine(y);
        }
    }   
}
