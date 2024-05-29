using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class3
    {
        //int n = int.Parse(Console.ReadLine());
        public Class3()
        {
            int Sum = 0, m = 1, y = 1;
            int[] a = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
            int t = int.Parse(Console.ReadLine());
            int c = 0, ans = 0;
            Array.Sort(a);
            int[] b = new int[100];
            int[] d = new int[100];
            int[] e = new int[100];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    d[i] = a[i];
                    e[i] = a[i];
                    Sum += a[i];
                    if (i != a.Length - 1)
                    {
                        b[i] = a[i];
                    }
                }
            }
            if (Sum < t)
            {
                Console.WriteLine("-1");
            }
            else
            {
                int flag = 0;
                for (int i = e.Length - 1; i >= 0; i--)
                {
                    if (e[i] != 0)
                    {
                        ans = t - Math.Abs(e[i]);
                        e[i] = 0;
                    }
                    for (int j = e.Length - 1; j >= 0; j--)
                    {
                        if (ans == e[j] && e[j] != 0)
                        {
                            flag = 1;
                            // Console.WriteLine("ta");
                        }
                        else if (e[j] < ans && e[j] != 0)
                        {
                            ans -= e[j];
                        }
                    }

                }
                if (flag == 1)
                {
                    Console.WriteLine("target");
                    Console.WriteLine("c is : " + c);

                }
                else
                {
                    int p = 1;
                    while (Sum > t)
                    {
                        Sum = 0;
                        if (d[a.Length - p] % 2 == 0)
                        {
                            int l = d[a.Length - p] / 2;
                            if (m % 2 == 0)
                            {
                                if (y % 2 != 0)
                                {
                                    b[a.Length - p] = l;
                                    b[a.Length - 1] = l;
                                    Console.Write("xyz");
                                }
                                else
                                {
                                    b[a.Length - p] = l;
                                }
                                y++;
                            }
                            else
                            {
                                b[a.Length - p] = l;
                                //b[a.Length] = l;
                            }
                            c++;
                            Console.WriteLine("yes");
                        }
                        else
                        {
                            b[a.Length + 4] = d[a.Length - 1];
                            p++;
                            m++;
                            Console.WriteLine("no");
                        }
                        //b[a.Length] = 0;
                        for (int i = 0; i < b.Length; i++)
                        {
                            if (b[i] != 0)
                            {
                                Console.WriteLine(b[i]);
                                d[i] = b[i];
                                Sum += d[i];
                            }
                        }
                        ans = 0;
                        if (Sum != t)
                        {
                            for (int i = 0; i < d.Length; i++)
                            {
                                int s1 = 0;
                                for (int j = 1; j < d.Length; j++)
                                {
                                    int s = 0;
                                    for (int k = j + 1; k < d.Length; k++)
                                    {
                                        if (d[i] != 0 && d[j] != 0 && d[k] != 0)
                                        {
                                            s = d[i] + d[j] + d[k];
                                        }
                                    }
                                    if (s == t)
                                    {
                                        ans = s;
                                    }
                                    if (d[i] != 0 && d[j] != 0)
                                    {
                                        s1 = d[i] + d[j];
                                    }
                                    if (s1 == t)
                                    {
                                        ans = s1;
                                    }

                                }

                            }
                            if (ans != 0)
                            {
                                Sum = ans;
                            }
                            Console.WriteLine("Sum is : " + Sum);
                        }
                        else
                        {
                            Console.WriteLine("Sum is : " + Sum);
                        }

                    }
                    Console.WriteLine("c is : " + c);
                }

            }
        }
    }
}
 