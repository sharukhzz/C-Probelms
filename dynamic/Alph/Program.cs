using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alph
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0,xx=0;
            string[,] alphabet = new string[6, 5];
            string[] alph = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (x <= 25)
                    {
                        alphabet[i, j] = alph[x];
                        x++;
                    }
                }
            }
            string target = "leet",s="";
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (xx < target.Length)
                    {
                        if (alphabet[i, j] == target[xx] + "")
                        {
                            while (i-- > 0)
                            {
                                s += "D";
                            }
                            while (j-- > 0)
                            {
                                s += "R";
                            }
                            xx++;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(s);
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(alphabet[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
