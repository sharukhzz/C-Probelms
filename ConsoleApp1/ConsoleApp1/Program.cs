using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        

        static void  Main(string[] args)
        {
            string s = "56-98";
            Console.WriteLine(Add(s));
            Console.ReadKey();
        }

        static int add(int a,int b) =>  a + b;
        static int sub(int a, int b) => a - b;
        static int mul(int a, int b) => a * b;
        static int div(int a, int b) => a / b;
        static int mod(int a, int b) => a % b;

        static int split(int index,string s)
        {
            string res = "";
            for(int i = index; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i])) res += s[i];
                else break;
            }
            return Int32.Parse(res);
        }

        static int Add(string s)
        {
            List<int> num = new List<int>();
            List<char> sym = new List<char>();
            string numb = "";
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == '+')
                {
                    sym.Add(s[i]);
                    num.Add(Int32.Parse(numb));
                    numb = "";
                }
                else if (s[i] == '-')
                {
                    sym.Add(s[i]);
                    num.Add(Int32.Parse(numb));
                    numb = "";
                }
                else numb += s[i];
            }

            Console.WriteLine(string.Join(",",numb));
            Console.WriteLine(string.Join(",",sym));
            return 0;
        }
    }
}
