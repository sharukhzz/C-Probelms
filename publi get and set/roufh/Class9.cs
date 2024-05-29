using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roufh
{
    class Class9
    {
        public static int[,] res = new int[5, 6];
        public static void L()
        {
            int[,] a = { { 11,25,66,1,69,7},{23,55,17,45,15,52},{75,31,36,44,58,8},{22,27,33,25,68,4},{84,28,14,11,5,50} };
            int row = 0, col = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        row = i;
                        col = j;
                        GC(row, col, a);
                    }
                }
                else
                {
                    int j = 0;
                    row = i;
                    col = j;
                    GC(row, col, a);
                }
            }
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    Console.Write(res[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void GC(int row,int col,int[,] a)
        {
            int k1 = row, k2 = col;
            SortedSet<int> li = new SortedSet<int>();
            while(row<a.GetLength(0) && col<a.GetLength(1))
            {
                li.Add(a[row,col]);
                row++;
                col++;
            }
            int x = 0;
            while(k1<a.GetLength(0) && k2<a.GetLength(1))
            {
                res[k1, k2] = li.ElementAt(x);
                x++;
                k1++;
                k2++;
            }
            li.Clear();
        }
    }
}
