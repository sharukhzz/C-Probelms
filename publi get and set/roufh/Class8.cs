using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roufh
{
    class Class8
    {
        static int p = 0;
        public static void II()
        {
            int m = 2, n = 2,F=0,row=0,col=0;
            int[,] ind = { { 1, 1 }, { 0,0} };
            int[,] a = new int[m, n];
            for(int i=0;i<ind.GetLength(0);i++)
            {
                for(int j=0;j<ind.GetLength(1);j++)
                {
                    if(F==0)
                    {
                        row = ind[i, j];
                        F = 1;
                    }
                    else
                    {
                        col = ind[i, j];
                        F = 0;
                    }
                }
                //Console.WriteLine(row + " " + col);
                GC(row, col, a);
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                    if (a[i, j] % 2 != 0)
                    {
                        p++;
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine(p);
        }
        public static void GC(int row,int col,int [,] a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(i==row )
                    {
                        a[i, j] = a[i, j] + 1;
                    }
                    if (j == col)
                    {
                        a[i, j] = a[i, j] + 1;
                    }
                }
            }
        }
    }
}
