using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class2
    {
        string s1 = Console.ReadLine();
        string s2 =Console.ReadLine();
        public Class2()
        {
            if(s1.Length.Equals(s2.Length))
            {
                int x = 0,c=0;
                while(x<s1.Length)
                {
                    if(s1[x]==s2[x])
                    {
                        c++;
                    }
                    x++;
                }
                Console.WriteLine(s1.Length - c);
            }
            else
            {
                int c = 0;
               if(s1.Contains(s2))
                {
                    Console.WriteLine(c);
                }
                else
                {
                    int[] a = new int[10];
                    int[] a1 = new int[s2.Length];
                    int[] a2 = new int[s2.Length];
                    int[] a3 = new int[s2.Length];
                    string st = "";
                    int x=0,k=0,u=0;
                    int s = 0, e =s2.Length-1,sum = 0;
                    while(e<s1.Length)
                    {
                        k = 0;
                        sum = 0;
                        x = s;
                        for(int i=0;i<s2.Length;i++)
                        {
                            a1[k] = Math.Abs(Math.Abs(s1[x]) - Math.Abs(s2[i]));
                            sum += a1[k];
                            Console.WriteLine(Math.Abs(Math.Abs(s1[x]) - Math.Abs(s2[i])));
                            x++;
                        }
                        Console.WriteLine("sum is"+sum);
                        a[u] = sum;
                        k++;
                        s++;
                        e++;
                        u++;
                    }
                    int min = 99999,l=0;
                    for(int i=0;i<a.Length;i++)
                    {
                        if (a[i] != 0)
                        {
                            Console.WriteLine("SUM IS : " + a[i]);
                            if (a[i] != 0)
                            {
                                if (a[i] < min)
                                {
                                    min = a[i];
                                    l = i;
                                }
                            }
                        }

                    }
                   for(int i=l;i<=l+(s2.Length-1);i++)
                    {
                        st += s1[i];
                    }
                    Console.WriteLine(st);
                }
            }
        }
    }
}
