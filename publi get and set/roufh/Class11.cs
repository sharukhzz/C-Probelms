using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roufh
{
    class Class11
    {
        public static void M()
        {
            int[][] grid = new int[3][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };

            int[,] dp = new int[grid.Length, grid[0].Length];

            int ans = Int32.MaxValue;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (i == 0)
                    {
                        dp[i, j] = grid[i][j];
                    }
                    else
                    {
                        dp[i, j] = Math.Min(get(i - 1, j, dp),Math.Min(get(i-1,j-1,dp),get(i-1,j+1,dp)))+grid[i][j];
                    }
                }
                if (i == grid.Length - 1)
                {
                    for (int k = 0; k < dp.GetLength(0); k++)
                    {
                        ans = Math.Min(ans, dp[i, k]);
                    }
                }
            }
           foreach(var a in dp) Console.WriteLine(string.Join(",",a));
            Console.WriteLine(ans);
        }
    public static int get(int row, int column, int[,] grid)
    {
        if(row>=0 && column>=0&&row<grid.GetLength(0)&&column<grid.GetLength(1))
        {
            return grid[row,column];
        }
            return Int32.MaxValue;
    }

        public static void das()
        {
            string s = "hjfad";
            int i = 0;
            foreach (char a in s) i++;
            Console.WriteLine(i);
            i = 0;
            while (true)
            {
                try
                {
                   char c= s[i++];
                }
                catch
                {
                    Console.WriteLine(i-1);
                    return;
                }
            }

        }
    }
}
