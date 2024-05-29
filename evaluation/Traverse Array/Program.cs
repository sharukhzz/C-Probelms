using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traverse_Array
{
    class Program
    {
        private static List<string> list = new List<string>();
        static void Main(string[] args)
        {
            int[,] mat = { { 1, 4, 1 }, { 1, 5, 2 }, { 2, 3, 1 } };
            int target = 6;
            Dfs(mat, target, 0,0, 0,"");
            Console.WriteLine(String.Join(" ", list));
            Console.ReadLine();
        }
        public static void Dfs(int [,] mat,int target,int index,int j,int sum,string res)
        {
            if (sum == target)
            {
                list.Add(res);
                sum = 0;
            }
            if(index<0 || index>=mat.GetLength(0) || j<0 || j>=mat.GetLength(1) )
            {
                return;
            }
            Dfs(mat, target, index ,j+1, sum + mat[index, j] , res+mat[index,j]+"");
            Dfs(mat, target, index + 1, j + 1, sum + mat[index, j], res + mat[index, j] + "");
            Dfs(mat, target, index + 1, j , sum + mat[index, j], res + mat[index, j] + "");
            Dfs(mat, target, index +1, j+1, sum, res);
            Dfs(mat, target, index, j + 1, sum, res);
            Dfs(mat, target, index + 1, j, sum, res);
        }
    }
}
