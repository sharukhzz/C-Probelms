using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combination_sum
{
    class Program
    {
        public static void Dfs(int[] a,List<List<int>> li,List<int> comb,int t,int sum,int start)
        {
            if(sum==t)
            {
                Console.WriteLine(String.Join(" ", comb));
                li.Add(new List<int>(comb));
            }
            if(start>=a.Length)
            {
                return;
            }
            Dfs(a, li, new List<int>(comb) { a[start] }, t, sum + a[start], start + 1);
            Dfs(a, li,new List<int>(comb), t, sum, start + 1);
        }
        static void Main(string[] args)
        {
            int[] a = { 3,2, 3, 5 };
            int t = 8;
            List<List<int>> li = new List<List<int>>();
            List<int> comb = new List<int>();
            Dfs(a, li, comb, t, 0, 0);
            foreach(var n in li)
            {
                Console.WriteLine(String.Join(" ",n));
            }
            Console.ReadLine();
        }
    }
}
