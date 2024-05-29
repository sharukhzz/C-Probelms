using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class1
    {
        int n1 = int.Parse(Console.ReadLine());
        //int n2 = int.Parse(Console.ReadLine());
        public Class1()
        {
            int n2 = n1;
            int n3 = n1;
            int sum = 0;
            while(n1!=0)
            {
                int res = n1 % 10;
               sum = sum * 10 + res;
                n1 = n1 / 10;
            }
            Console.WriteLine(sum);
            
            string s2 = "";
            while(n2!=0)
            {
                int res = n2 % 2;
                s2 = res + s2;
                n2 = n2 / 2;
            }
            Console.WriteLine(s2);
            string s3 = "";
            for(int i=s2.Length-1;i>=0;i--)
            {
                s3 += s2[i];
            }
            Console.WriteLine(s3);
            if (sum == n3 && s2.Equals(s3))
            {
                Console.WriteLine("palindrome and binary number is also plaindrome");
            }
            else if(sum==n3 && s2!=s3)
            {
                Console.WriteLine("only palindrome and binary number is not palindrome");
            }
            else if(sum!=n3 && s2.Equals(s3))
            {
                Console.WriteLine("not a palindrome and binary number is plaindrome");
            }
            else
            {
                Console.WriteLine("not a palindrome and binary number is not plaindrome");
            }
        }
    }
}
