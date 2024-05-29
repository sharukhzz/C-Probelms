using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class4
    {
        int t = int.Parse(Console.ReadLine());
        public Class4()
        {
            while (t-- > 0)
            {
                string s = Console.ReadLine();
                char[] a = s.ToCharArray();
                int c = 1, co = 1;
                int i = 0;
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            c++;
                            a[j] = ' ';
                        }
                        else { co++; }
                    }
                }
                if (c == a.Length)
                {
                    Console.WriteLine("0");
                }
                else if(c>co)
                {
                    Console.WriteLine(co);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
