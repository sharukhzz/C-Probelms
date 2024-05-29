using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_array_combination
{
    class Program
    {
        public static void Dfs(string[] s,int start,string res,List<string> li)
        {
            if(res.Length==s.Length)
            {
                li.Add(res);
            }
            else
            {
                string c = s[start];
                foreach(var n in c)
                {
                    Dfs(s, start + 1, res + n, li);
                }
            }
        }
        static void Main(string[] args)
        {
            string[] ss = { "0","1","abc", "def","ghi","jkl","mno","pqrs","tuv","wxyz" };
            string digits = "239";
            int digit = int.Parse(digits);
            List<string> lii = new List<string>();
            foreach(var h in ss)
            {
                while(digit!=0)
                {
                    int ans = digit % 10;
                    if (ans != 0 && ans != 1) lii.Add(ss[ans]);
                    digit = digit / 10;

                }
            }
            string[] s = lii.ToArray();
            List<string> li = new List<string>();
            Dfs(s, 0, "", li);
            Console.WriteLine(string.Join(" ", li));
            Console.ReadLine();
        }
    }
}
