using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codechef
{
    class Class4
    {
        public static void J()
        {
            int ans=0,y = 5;
            while(y!=0)
            {
                ans = y % 2 + ans*10;
                y = y / 2;
            }
            Console.WriteLine(ans);
        }
        public static void K()
        {
            string s = "abbaccaddaeea", t = "aaaaa";
            string st = "";
            int c = 0;
            int F = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Length >= t.Length)
                {
                    for (int j = 0; j < t.Length; j++)
                    {
                        if(s[i]!=t[j])
                        {
                            F++;
                            if (F == t.Length) break;
                        }
                        if (s[i] == t[j])
                        {
                            st += s[i];
                            Console.WriteLine(st);
                            s = s.Remove(i, 1);
                        }
                    }
                    if (st.Length >= t.Length)
                    {
                        Console.WriteLine(st);
                        Console.WriteLine(s);
                        c++;
                        st = "";
                    }
                }
                Console.WriteLine(c);
            }
        }
        //public static void K()
        //{
        //    string s = "cbacdcbc";
        //    int flag = 0, flag2 = 0;
        //    List<string> li = new List<string>();
        //    string ss = "";
        //    string k = "";
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //       // ss = "";
        //        k = "";
        //        k = s[i].ToString();
        //        //for (int j = 0; j < ss.Length; j++)
        //        //{
        //        //    if (ss[j] == s[i])
        //        //    {
        //        //        flag = 1;
        //        //        break;
        //        //    }
        //        //}
        //        //if (flag != 1)
        //        //{
        //            for (int j = i + 1; j < s.Length; j++)
        //            {
        //                for (int u = 0; u < k.Length; u++)
        //                {
        //                    if (k[u] == s[j])
        //                    {
        //                        flag2 = 1;
        //                    }
        //                }
        //                if (flag2 != 1)
        //                {
        //                    k += s[j];
        //                }
        //            }
        //            li.Add(k);
        //            ss += s[i];
        //        }
        //    }
        //    Console.Write(String.Join(" ", li));
        //}
        public static void Mu()
        {
            string s = "aaabaaaa";
            for (int i = 0; i < s.Length; i++)
            {
                    for (int j = i+1; j < s.Length - 2; j++)
                    {
                        if (s[i] == s[j] && s[i] == s[j + 1])
                        {
                            Console.WriteLine(i);
                            s=s.Remove(i, 1);
                        Console.WriteLine(s);
                        break;
                        }
                    }
            }   
            Console.WriteLine(s);
        }
        public static void F()
        {
            int n = 9996;
            string s = n.ToString();
            Console.WriteLine(s);
            int max = n;
            char[] c = s.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                int s1 = 0;
                if(c[i]=='9' || c[i]=='6')
                {
                    if (c[i] == '9')
                    {
                        c[i] = '6';
                    }
                    else
                    {
                        c[i] = '9';
                    }
                    for(int j=0;j<c.Length;j++)
                    {
                        s1=(int)Char.GetNumericValue(c[j])+s1*10;
                        if(j==i)
                        {
                            if (c[i] == '9')
                            {
                                c[i] = '6';
                            }
                            else
                            {
                                c[i] = '9';
                            }
                        }
                    }
                }
                if(s1>max)
                {
                    max = s1;
                }
                Console.WriteLine(max);
            }
        }
        public static void M()
        {
            int[] nums = { 4, 4, 7, 6, 7 };
            int sum = nums.Sum();
            int s1 = 0, s2 = 0, x = 2,y=0;
            List<int> li = new List<int>();
            Array.Sort(nums);
            while (s1 <= s2)
            {
                y = 0;
                s1 = 0;
                s2 = 0;
                li.Clear();
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    if(y<x)   
                    {
                        s1 += nums[i];
                        li.Add(nums[i]);
                        Console.Write(String.Join(" ", li));
                        y++;
                    }
                    else
                    {
                        s2 += nums[i];
                        Console.WriteLine("s2 is : " + s2);
                    }
                }
                x++;
            }
            Console.Write(String.Join(" ", li));
        }
    }
}
