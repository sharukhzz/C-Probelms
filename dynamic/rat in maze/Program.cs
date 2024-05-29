using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rat_in_maze
{
    class Program
    {
        public static void Dfs(bool [,]visited,int[,] a,int n,int r,int c,List<string> li,string w)
        {
            if (r < 0 || r >= n || c < 0 || c >= n || visited[r, c] || a[r, c] == 0) return;
            if(r==n-1 && c==n-1)
            {
                Console.WriteLine("found");
                li.Add(w);
                return;
            }
            visited[r, c] = true;
            Dfs(visited, a, 4, r + 1, c,li,w+"d");
            Dfs(visited, a, 4, r - 1, c,li,w+"u");
            Dfs(visited, a, 4, r , c +1,li,w+"r");
            Dfs(visited, a, 4, r, c-1,li,w+"l");
            visited[r, c] = false;
        }
        static void Main(string[] args)
        {
            int[,] a = { { 1, 0, 0, 0 }, { 1, 1, 0, 0 }, { 0, 1, 0, 0 }, { 0, 1, 1, 1 } };
            bool[,] visited = new bool[4,4];
            List<string> li = new List<string>();
            Dfs(visited, a, 4,0, 0,li,"");
            Console.WriteLine(String.Join(" ", li));
            Console.ReadLine();
            
        }
    }
}
