using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[,] mat = new int[r,c];
            for(int i=0;i<c;i++)
            {
                for(int j=0;j<r;j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
