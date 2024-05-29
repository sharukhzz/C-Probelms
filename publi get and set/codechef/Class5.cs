using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codechef
{
    class Class5
    {
        public static void Diamat()
        {
            //int n = int.Parse(Console.ReadLine());
            List<int> li = new List<int>();
            int[,] a = { { 11, 25, 66, 1, 69, 7 }, { 23, 55, 17, 45, 15, 52 }, { 75, 31, 36, 44, 58, 8 }, { 22, 27, 33, 25, 68, 4 }, { 84, 28, 14, 11, 5, 50 } };
            for (int i = 0; i < a.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    int k1 = i;
                    int k2 = j;
                   // Console.WriteLine(i + " " + j);
                    li.Clear();
                   while(i<a.GetLength(0) && j<a.GetLength(1))
                    {
                        li.Add(a[i, j]);
                     
                        i++;
                        j++;

                    }
                  //  Console.WriteLine(String.Join(" ", li));
                    i = k1;
                    j = k2;
                    li.Sort();
                    int x = 0;
                    while(i<a.GetLength(0) && j<a.GetLength(1))
                    {
                        a[i, j] = li[x];
                        x++;
                        i++;
                        j++;
                    }
                    i = k1;
                    j = k2;
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                   Console.Write(a[i, j] + " ");
                }
               Console.WriteLine();
            }
        }
    }
}
