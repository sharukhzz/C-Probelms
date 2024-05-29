using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minnn
{
    class Program
    {
        static List<int> lii = new List<int>();
        static void Main(string[] args)
        {
            int t = 6;
            int[] a = { 1,2,5};
            Dfs(a, t, 0, 0, new List<int>());
            Console.WriteLine(String.Join(" ", lii));
            Console.ReadLine();
        }
        public static void Dfs(int[] a,int target,int index,int sum,List<int> li)
        {
            if(sum==target)
            {
                lii.Add(int.Parse(String.Join("",new List<int>(li))));
            }
            if(index>=a.Length)
            {
                return;
            }
            Dfs(a, target, index + 1, sum + a[index], new List<int>(li) { a[index] });
            Dfs(a, target, index + 1, sum, new List<int>(li));
        }
    }
}
