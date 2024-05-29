using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codechef
{
    class Class6
    {
        public static bool K()
        {
            char[,] b = {{'1','3','.','.','7','.','.','.','.' }
,{'6','.','.','1','9','5','.','.','.' }
,{'.','9','3','.','.','.','.','6','.' }
,{'8','.','.','.','6','.','.','.','3'}
,{'4','.','.','8','.','3','.','.','1'}
,{'7','.','.','.','2','.','.','.','6'}
,{'.','6','.','.','.','.','2','8','.'}
,{'.','.','.','4','1','9','.','.','5'}
,{'.','.','.','.','8','.','.','7','9'}};
            int flag = 0;
            int sr = 0, sc = 0, er = 0, ec = 0;
            HashSet<char> hr = new HashSet<char>();
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    // bool bo=int.TryParse(b[i][j],out b[i][j]);
                    if (b[i, j] != '.')
                    {
                        int n = (int)Char.GetNumericValue(b[i, j]);
                        //Console.WriteLine(n);
                        int r = i, c = j, k1 = r, k2 = c;
                        int co = 0;
                        while (c < b.GetLength(1))
                        {
                            if ((int)Char.GetNumericValue(b[r, c]) == n)
                            {
                                co++;

                            }
                            if (co >= 2)
                            {
                                flag = 1;
                                break;
                            }
                            c++;
                        }
                        c = k2;
                        co = 0;
                        while (r < b.GetLength(0))
                        {
                            if ((int)Char.GetNumericValue(b[r, c]) == n)
                            {
                                co++;
                            }
                            if (co >= 2)
                            {
                                flag = 1;
                                break;
                            }
                            r++;
                        }
                        r = k1;
                        co = 0;

                        // Console.WriteLine(flag + " " + i + j + " " + n);
                    }
                    if (i == 0 && j == 0 || i == 0 && j == 3 || i == 0 && j == 6 || i ==3 && j==0 || i==3 && j==3 || i==3 && j==6 || i==6 && j==0 || i==6 && j==3 || i==6 && j==6)
                    {
                        sr = i;
                        sc = j;
                        er = sr + 2;
                        ec = sc + 2;
                        int count = 0;
                       // Console.WriteLine(sr + " " + sc + " " + er + " " + ec);
                        for (int x = sr; x <= er; x++)
                        {
                            for (int y = sc; y <= ec; y++)
                            {
                                if (b[x, y] != '.')
                                {
                                    Console.WriteLine(x + " " + y);
                                    count++;
                                    hr.Add(b[x,y]);         
                                }
                            }
                        }
                        // Console.WriteLine(count + " " + hr.Count + " " + sr + " " + sc);
                        //Console.WriteLine(flag);
                        Console.WriteLine("hr is"+hr.Count);
                        //Console.Write(String.Join(" = ", hr));
                        if (hr.Count != count)
                        {
                            flag = 1;
                           Console.WriteLine(flag + " " + i + j);
                        }
                        hr.Clear();
                    }
                   
                }
            }
            return (flag == 1) ? false : true;
        }
    }
}
