using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combinations
{
    class Program
    {
        public static void Dfs(List<List<int>> li,List<int> comb,int n,int k,int start)
         {
            if(comb.Count()==k)
            {
                li.Add(new List<int>(comb));
                return;
            }
            for(int i=start;i<=n;i++)  //1234
            {
                comb.Add(i);
                Dfs(li, comb, n, k, i + 1);
                comb.RemoveAt(comb.Count() - 1);
            }
         }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            List<List<int>> li = new List<List<int>>();
            List<int> comb = new List<int>();
            Dfs(li, comb, n, k, 1);
           foreach(var nu in li)
            {
            Console.WriteLine(string.Join(" ",nu));
            }
            Console.ReadLine();
        }
    }
}
