using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roufh
{
    class Class4
    {
        public static int Mat1()
        {
            int[,] mat = { {1,0,0},{0,1,0},{0,0,1} };
            int count = 0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i,j] == 1)
                    {
                        int flag = 1;
                        int r = i, c = j, k1 = r, k2 = c;
                        int co = 0;
                        while (r < mat.GetLength(0))
                        {
                            if (mat[r, c] == 1)
                            {
                                co++;
                            }
                            r++;
                        }
                        if(co>1)
                        {
                            flag = 0;
                        }
                        co = 0;
                        r = k1;
                        while (r >= 0)
                        {
                            if (mat[r, c] == 1)
                            {
                                co++;
                            }
                            r--;
                        }
                        if (co > 1)
                        {
                            flag = 0;
                        }
                        co = 0;
                        r = k1;
                        while (c < mat.GetLength(1))
                        {
                            if (mat[r, c] == 1)
                            {
                                co++;
                            }
                            c++;
                            
                        }
                        if (co > 1)
                        {
                            flag = 0;
                        }
                        co = 0;
                        c = k2;
                        while (c >= 0)
                        {
                            if (mat[r, c] == 1)
                            {
                                co++;
                            }
                            c--;   
                        }
                        if (co > 1)
                        {
                            flag = 0;
                        }
                        co = 0;
                        c = k2;
                       // Console.WriteLine(flag);
                        if (flag == 1)
                        {
                            count++;
                            Console.WriteLine(i + " " + j);
                        }
                    }
                }
            }
            return count;
        }
    }
}
