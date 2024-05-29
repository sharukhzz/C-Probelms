using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roufh
{
    class Class6
    {
        public static void Rotate()
        {
            int[,] a = { { 7, 8, 9}, { 4, 5, 6 }, { 1, 2, 3} };
            int t = 3;
            int x = 0;
            while (t-->0)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = i + 1; j < a.GetLength(1); j++)
                    {
                        var temp = a[i, j];
                        a[i, j] = a[j, i];
                        a[j, i] = temp;
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
                Console.WriteLine("Array Rotation 90");
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = a.GetLength(1) - 1; j >= a.GetLength(1) / 2; j--)
                    {
                        int temp = a[i, j];
                        a[i, j] = a[i, x];
                        a[i, x] = temp;
                        x++;
                    }
                    x = 0;
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
            Console.WriteLine();
            int[,] b = { { 7, 8, 9,10 }, { 4, 5, 6,11 }, { 1, 2, 3,12 },{ 13, 14, 15, 16 } };
            int tt = 3;
            while (tt-- > 0)
            {
                for (int i = 0; i < b.GetLength(0); i++)
                {
                    for (int j = i + 1; j < b.GetLength(1); j++)
                    {
                        int temp = b[i, j];
                        b[i, j] = b[j, i];
                        b[j, i] = temp;
                    }
                }
                for (int i = 0; i < b.GetLength(0); i++)
                {
                    for (int j = 0; j < b.GetLength(1); j++)
                    {
                        Console.Write(b[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("left rotation");
                x = 0;
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int i = b.GetLength(0) - 1; i >= b.GetLength(0) / 2; i--) //if 4/2= || 3/2 >
                    {
                        int temp = b[i, j];
                        b[i, j] = b[x, j];
                        b[x, j] = temp;
                        x++;
                    }
                    x = 0;
                }
                for (int i = 0; i < b.GetLength(0); i++)
                {
                    for (int j = 0; j < b.GetLength(1); j++)
                    {
                        Console.Write(b[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine("One swift array rotation");
            int[,] m = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            int n = m.GetLength(0) * m.GetLength(1);
            int co = 0,rs=0,cs=0,re=m.GetLength(0)-1,ce=m.GetLength(1)-1;
            while(co<=n)
            {
                while(rs<=re && cs<=ce)
                {

                }
            }
        }
    }
}
