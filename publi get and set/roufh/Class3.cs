using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roufh
{
    class Class3
    {
        public static void Spiral()
        {
            int[,] matrix = { {1,2,3,4},{5,6,7,8},{9,10,11,12} };
                IList<int> res = new List<int>();
                int top = 0, left = 0, right = matrix.GetLength(1) - 1, bot = matrix.GetLength(0) - 1, elements = matrix.GetLength(0) * matrix.GetLength(1);

                while (res.Count < elements)
                {
                    // Go right 
                    for (int i = left; i <= right && res.Count < elements; i++)
                    {
                        res.Add(matrix[top,i]);
                    }
                    top++;

                    // Go down
                    for (int j = top; j <= bot && res.Count < elements; j++)
                    {
                        res.Add(matrix[j,right]);
                    }
                    right--;

                    // Go left
                    for (int i = right; i >= left && res.Count < elements; i--)
                    {
                        res.Add(matrix[bot,i]);
                    }
                    bot--;

                    // Go up
                    for (int i = bot; i >= top && res.Count < elements; i--)
                    {
                        res.Add(matrix[i,left]);
                    }
                    left++;
                }
        Console.Write(String.Join(" ", res));
        }
    }
}
