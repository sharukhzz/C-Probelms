using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parentheses
{
    class Program
    {
        static void Dfs(List<string> li,int open,int close,int max,string res)
        {
            if(max*2==res.Length)
            {
                li.Add(res);
            }
            if(open<max)
            {
                Dfs(li, open + 1, close, max, res + "(");
            }
            if(close<open)
            {
                Dfs(li, open, close + 1, max, res + ")");
            }

        }
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            int k = 3;
            Dfs(li, 0,0, k,"");
            Console.WriteLine(String.Join(" ", li));
            Console.ReadLine();
        }
    }
}
