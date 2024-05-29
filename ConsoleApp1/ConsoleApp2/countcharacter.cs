using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class countcharacter
    {
        string s = Console.ReadLine();
        public  countcharacter()
            {
            int x = 0;
            char[] a = new char[s.Length];
            for(int i=0;i<s.Length;i++)
            {
                if (s[i] != ' ')
                {
                    int c = 0;
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (s[i] == s[j])
                        {
                            c++;
                        }
                    }

                    a[x] = s[i];
                    x++;
                    int y = 0;
                    for (int k = 0; k < a.Length; k++)
                    {
                        if (s[i] == a[k])
                        {
                            y++;
                        }
                    }
                    if (y == 1)
                    {
                        Console.WriteLine(s[i] + "=" + c);
                    }
                }
                
                //s = s.Replace(s[0].ToString(), string.Empty);   
            }

            }
    }
}
