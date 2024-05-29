using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class pattern
    {

        public void pat(int n)
        {
            int nu = 2 * n - 1;
            int s = 0;
            int e = nu - 1;
            int[,] a = new int[nu,nu];
            while (n != 0)
            {
                for (int i = s; i <=e; i++)
                {
                    for (int j = s; j <=e; j++)
                    {
                        if (i == s || j == s || i == e || j == e)
                        {
                            a[i,j] = n;
                        }
                    }
                    Console.WriteLine();
                }
                s++;
                e--;
                n--;
            }
             for(int i=0;i<nu;i++)
            {
                for(int j=0;j<nu;j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}