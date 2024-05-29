using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no for row : ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the no of coloumn : ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[m, n];
            Console.WriteLine("enter the value of matrix line by line : ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            int max = 0;
            max = (m > n) ? m : n;
            int[,] r = new int[max, max];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    r[i, j] = mat[i, j];
                }
            }
            if (m == n)
            {
                Console.WriteLine("enter the degree of matrix : ");
                int nn = int.Parse(Console.ReadLine());
                nn = nn / 90;
                while (nn-- > 0)
                {
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = i + 1; j < n; j++)
                        {
                            int temp = mat[i, j];
                            mat[i, j] = mat[j, i];
                            mat[j, i] = temp;
                        }
                    }
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(mat[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    for (int i = 0; i < m; i++)
                    {
                        int x = 0;
                        for (int j = n - 1; j >= n / 2; j--)
                        {
                            int temp = mat[i, x];
                            mat[i, x] = mat[i, j];
                            mat[i, j] = temp;
                            x++;
                        }
                    }
                    Console.WriteLine("Answer is : ");
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(mat[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("enter the degree of matrix : ");
                    int nn = int.Parse(Console.ReadLine());
                    nn = nn / 90;
                    while (nn-- > 0)
                    {
                        mat = Fun(mat);
                    }
                }
            }
                Console.ReadLine();
        }

         public static int[,] Fun(int[,] mat1)
        {
            int[,] res = new int[mat1.GetLength(1), mat1.GetLength(0)];
            int req = mat1.GetLength(0) - 1;
            int reqcol = 0;
            for (int i = 0; i < mat1.GetLength(1); i++)
            {
                req = mat1.GetLength(0) - 1; 
                for (int j = 0; j < mat1.GetLength(0); j++)
                {
                    res[i, j] = mat1[req, reqcol];
                    req--;
                        Console.Write(res[i,j]+" ");
                }
                reqcol++;
                Console.WriteLine();
            }
            return res;
        }
    }
 }
