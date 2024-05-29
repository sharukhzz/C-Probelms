using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "abc";
            Permute(input, 0, input.Length - 1);
            Console.ReadLine();
        }
        static void Permute(string str, int left, int right)
        {
            if (left == right)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    str = Swap(str, left, i);
                    Permute(str, left + 1, right);
                    str = Swap(str, left, i); // Backtrack to the previous state
                }
            }
        }

        static string Swap(string str, int i, int j)
        {
            char[] chars = str.ToCharArray();
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
            return new string(chars);
        }
    }
}
