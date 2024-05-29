using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roufh
{
    class Class10
    {
        public static void Fallingpath()
        {
            int[,] m = { { -19, 57 }, { -40, -5 } };
            int y = 0,c=0,x=0,n=0;
            while (n < m.GetLength(0))
            {
                int[] a=G(m,x,y,n);
                x=a[0];
                y = a[1];
                c += a[2];
                n++;
            }
            Console.WriteLine(c);
        }
        public static int[] G(int[,] m,int row,int col,int i)
        {
            int p = 0, q = 0;
            int[] a = new int[3];
            int min = Int32.MaxValue;
            for (int j = 0; j < m.GetLength(1); j++)
            {
                if(m[i,j]<min)
                {
                    if (row == 0 && col == 0)
                    {
                        min = m[i, j];
                        p = i;
                        q = j;
                    }
                    else
                    {
                        if (i == row + 1 && j == col - 1 || i == row + 1 && j == col || i == row + 1 && j == col + 1)
                        {
                            min = m[i, j];
                            p = i;
                            q = j;
                        }
                    }
                }
            }
            a[0] = p;
            a[1] = q;
            a[2] = min;
            return a;
        }
    }
}
