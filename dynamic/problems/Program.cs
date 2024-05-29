using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    class Program
    {
        public static void anagaram(string s1, string s2)
        {
            int c=0;
            char[] a = s1.ToCharArray();
            char[] b = s2.ToCharArray();
            for(int i=0;i<a.Length;i++)
            {
                for(int j=0;j<b.Length;j++)
                {
                    if(a[i]==b[j])
                    {
                        c++;
                        b[j] = ' ';
                        break;
                    }
                }
            }
            if(c==a.Length)
            {
                Console.WriteLine("it is a anagram");
            }
            else
            {
                Console.WriteLine("not a anagram");
            }
        }
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            anagaram(s1, s2);
            Console.ReadLine();
        }
        
    }
}
