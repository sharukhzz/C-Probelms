using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class2
    {
        public static string Pal(string s)
        {
            string max ="";
            for(int i=0;i<s.Length;i++)
            {
                for(int j=i+1;j<s.Length;j++)
                {
                    if(s[i]==s[j])
                    {
                        string ss = s.Substring(i, j-i+1 );
                        if(IsBoll(ss))
                        {
                            max = (ss.Length > max.Length) ? ss : max;
                        }
                    }
                }
            }
            return max;
        }
        public static bool IsBoll(string ss)
        {
            for (int i = 0, j = ss.Length - 1; i < j; i++,j--)
            {
                if (ss[i] != ss[j]) return false;
            }
            return true;
        }
        public static bool KK(int n,List<int> queens)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                }
            }
            
            return true;
        }

        public static void S()
        {
            int u = 1;
            char s = (char)u;
            string allowed = "cad";
            string[] words = { "cc", "acd", "b", "ba", "bac", "bad", "ac", "d" };
            int st = 0,cc=0;
            while(st<words.Length)
            {
                int co = 0;
                string k = "";
                k = words[st];
                for(int i=0;i<k.Length;i++)
                {
                    for(int j=0;j<allowed.Length;j++)
                    {
                        if(k[i]==allowed[j])
                        {
                            co++;
                        }
                    }
                }
                if(co>=k.Length)
                {
                    cc++;
                }
                st++;
            }
            Console.WriteLine(cc);
        }
        public static void LLq()
        {
            string s = "abcdefghijk";
            char fill = 'x';
            int k = 3;
            int st = 0, e = k;
            List<string> li = new List<string>();
           while(st<s.Length)
            {
                if (e <= s.Length)
                {
                    string k1 = "";
                    for (int i = st; i < e; i++)
                    {
                        k1 += s[i];
                    }
                    Console.WriteLine("k is : " + k1);
                    li.Add(k1);
                    st = e;
                    e += 3;
                }
                else
                {
                    string k1 = "";
                    for(int i=st;i<s.Length;i++)
                    {
                        k1 += s[i];
                    }
                    while(k1.Length<k)
                    {
                        k1 += fill.ToString();
                    }
                    Console.WriteLine("k1 is :" + k1);
                    li.Add(k1);
                    st = e;
                }
            }
            Console.WriteLine(String.Join(",", li));
            //int n = 14;
            //int a = 0;
            //while (n >= 1)
            //{
            //    if (n % 2 == 0)
            //    {
            //        a += n / 2;
            //        n = n / 2;
            //        Console.WriteLine(a);
            //        Console.WriteLine("n"+n);
            //    }
            //    else
            //    {
            //        n = n - 1;
            //        a += n / 2;
            //        n = n / 2;
            //        Console.WriteLine("a1 is"+a);
            //        Console.WriteLine("n1 is"+n);
            //    }
            //}
            //Console.WriteLine(a);
        }
        public static void NN()
        {
            int[] digits = { 1, 2, 3 };
            int a = 0, x = 0;
            int[] b = new int[digits.Length];
            for (int i = 0; i < digits.Length; i++)
            {
                a = digits[i] + a * 10;
            }
            Console.Write(a);
            a = a + 1;
            while (a > 0)
            {
                Console.WriteLine("guy" + a % 10);
                b[x] = a % 10;
                x++;
                a = a / 10;
                Console.WriteLine("a is : " + a);
            }
            // Console.WriteLine(String.Join(',',b));
            Array.Reverse(b);
            for(int i=0;i<b.Length;i++)
            {
                Console.Write(b[i] + " ");
            }
            
        }
        public static void K()
        {
            string s = "OXOOX";
            int st = 0, e = 3, c = 0;
            for (int i = 0; i < s.Length; i++)
            {
                //st = i;
               
                Console.WriteLine("st is : " + st);
                Console.WriteLine("e is : " + e);
                if (st < s.Length)
                {
                    for (int j = 0; j < e; j++)
                    {
                        if (s[j] == 'X')
                        {
                            Console.WriteLine("j is : " + j);
                            c++;
                            break;
                        }
                    }
                }
                st += 3;
                e = e + 3;
                    while (e > s.Length)
                    {
                        e--;
                        if(e==s.Length)
                        {
                        break;
                        }
                    Console.WriteLine("eeeeee is : " + e);
                }
            }
            Console.WriteLine(c);
        }
        public static void U()
        {
            string s = "OXOOX";
            int st = 0, e = 0, c = 0;
            StringBuilder ss = new StringBuilder(s);
            //Console.WriteLine(ss);
            for (int i = 0; i < ss.Length; i++)
            {
                    st = i;
                    e = st + 3;
                    Console.WriteLine("st is : " + st);
                    Console.WriteLine("e is : " + e);
                    if (e <= ss.Length )
                    {
                        for (int j = st; j < e; j++)
                        {
                            Console.WriteLine("j is : " + j);
                            if (s[j] == 'X')
                            {
                                ss=ss.Replace(ss[j].ToString(),"O");
                                Console.WriteLine("replace : "+ s.Replace(ss[j].ToString(), "O"));
                            }
                        }
                        c++;
                        Console.WriteLine("c is : " + c);
                    }
            }
            Console.WriteLine(c);
        }
        public static void LL()
        {
            string s = "ab", t = "A",result="";
            int st = 0, e = t.Length,flag=0;
            if (e > s.Length)
            {
                Console.WriteLine();
            }
            else
            {
                while (flag == 0)
                {
                    while (st <= Math.Abs(e - (s.Length)))
                    {
                        string ss = "";
                        ss = s.Substring(st, e);
                        int c = 0;
                        for (int i = 0; i < ss.Length; i++)
                        {
                            if (t.Contains(ss[i].ToString()))
                            {
                                c++;
                            }
                        }
                        if (c == t.Length)
                        {
                            result = ss;
                            Console.WriteLine("result is : " + result);
                            flag = 1;
                            break;
                        }
                        Console.WriteLine(ss);
                        st++;
                    }
                    e++;
                    st = 0;
                }
            }
        }
            
    }
}
