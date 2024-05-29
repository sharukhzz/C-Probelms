using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roufh
{
    class Class1
    {
        public static void P()
        {
            int[,] a = { { 1, 2, 3 }, { 4,5,6 }, { 7,8,9 } };
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Transpose matrix ");
            int[,] b = new int[3, 3];
            for(int i=0;i<3;i++)
            {
                for(int j=i+1;j<3;j++)
                {
                    var temp = a[i, j];
                    a[i, j] = a[j, i];
                    a[j, i] = temp;
                    //Console.Write(a[i, j]);
                }
               // Console.WriteLine();
            }
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(a[i, j]);
               }
               Console.WriteLine();
            }
        }
    }
}
