using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mac_permutation
{
    class Program
    {
        static void P(string s,int start,int end,List<string> li)
        {
            if (start == end)
            {
                li.Add(s);
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    s = Sw(s, start, i);
                    P(s, start + 1, end, li);
                }
            }
        }
        static string Sw(string s,int i,int j)
        {
            char[] ch = s.ToCharArray();
            char temp = ch[i];
            ch[i] = ch[j];
            ch[j] = temp;
            return new string(ch);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            string s ="";
            for(int i=1;i<=n;i++)
            {
                s += i;
            }
            List<string> li = new List<string>();
            P(s, 0, s.Length - 1,li) ;
            Console.WriteLine(String.Join(" ", li));
            Console.WriteLine("answer is : "+li[k-1]);
            Console.WriteLine(li.Count);
            Console.ReadLine();
        }
    }
}
