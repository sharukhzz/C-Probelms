using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roufh
{
    class MinPath
    {
        public void MinPathSum()
        {
            int[,] grid =new int[,] { { 1, 3, 1 },{ 1, 5, 1 },{ 4, 2, 1 } };
            int[,] dp = new int[grid.GetLength(0), grid.GetLength(1)];

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (i == 0 && j == 0) dp[i, j] = grid[i,j];
                    if (i == 0 && j>0) dp[i, j] = dp[i, j - 1] + grid[i,j];
                    if (j == 0 && i>0) dp[i, j] = dp[i - 1, j] + grid[i,j];

                    if(i>0 && j>0)dp[i, j] = grid[i,j] + Math.Min(dp[i - 1, j], dp[i, j - 1]);
                }
            }
            Console.WriteLine(dp[grid.GetLength(0)-1, grid.GetLength(1)-1]);
            //return dp[grid.Length - 1, grid[0].Length - 1];
        }
    }
}
