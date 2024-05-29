using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Clas
    {
        public static void PP()
        {
            int n = 25;
            List<int> li = new List<int>();
            int i = 0, k = 0;
            while (i <= n )
            {
                if(n==0 || i==0)
                {
                    li.Add(i);
                    i++;
                }
                if ( n == 1 || n == 2 || i == 1 || i == 2)
                {
                    //Console.WriteLine("n is : " + n);
                    li.Add(1);
                    i++;
                }
                else
                {
                    int ans = li[k] + li[k + 1] + li[k + 2];
                    li.Add(ans);
                    k++;
                    i++;
                }
            }
            for (int j = 0; j < li.Count; j++)
            {
                Console.Write(li[j] + " ");
            }
            Console.WriteLine("ans is : "+Convert.ToInt32(li[n]));
        }
        public static void L()
        {

            string text = "alice is a good girl she is a good student";
            string first = "a";
            string second = "good";
            string[] s = new string[2];
            int x = 0;
            string[] t1 = text.Split();
            for (int i = 0; i < t1.Length; i++)
            {
               // Console.WriteLine(t1[i]);
                if (t1[i].Equals(first))
                {
                    if (t1[i + 1].Equals(second))
                    {
                       
                        s[x] = t1[i + 2].ToString();
                        x++;
                    }
                }
            }
            for(int i=0;i<s.Length;i++)
            {
                Console.Write(s[i]);
            }
            List<string> li = new List<string>();
            li.Sort();
            Convert.ToInt16(li[li.Count - 1]);
            li.ToArray();
        }
        public Clas()
        {
            //string s = "sf#h";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i]=='#')
            //    {
            //        s=s.Remove(i,1);
            //        s=s.Remove(i - 1,1);
            //    }
            //}
            //Console.WriteLine(s);
            //for(int i=0;i<8-1;i+=2)
            //{
            //    Console.Write(i + " ");
            //}
            //string ransomNote = "fffbfg";
            //string magazine = "effjfggbffjdgbjjhhdegh";
            //int c = 0;
            //char[] m = magazine.ToCharArray();
            //char[] r = ransomNote.ToCharArray();
            //for (int i = 0; i < ransomNote.Length; i++)
            //{
            //    for (int j = 0; j < magazine.Length; j++)
            //    {
            //        if (r[i] == m[j])
            //        {
            //            c++;
            //            m[j] = '0';
            //            break;
            //        }
            //    }
            //}
            //Console.Write(c);
            //Array.Sort(m, r);
            //string s = "as";
            string s = "abcd";
            string t = "abcde";
            char n = char.Parse(s);
            //char[] s1 = s.Split().ToCharArray();
            char[] t1 = t.ToCharArray();
            string[] s2 = s.Split(' ');
            //Array.Sort(s1);
            //Array.Sort(t1);
            //int flag = 0;
            //StringBuilder st = new StringBuilder();
            //int c = 0;
            //for (int i = 0; i < t1.Length; i++)
            //{
            //    for (int j = 0; j < s1.Length; j++)
            //    {
            //        if(t1[i]==s1[j])
            //        {
            //            c++;
            //        }
            //    }
            //    if(c==0)
            //    {
            //        flag = 1;
            //        Console.Write("sad");
            //    }
            //    if (flag==1)
            //    {
            //        Console.Write(t1[i]);
            //        st.Append(t1[i]);
            //    }
            //}
            //Console.Write(st);
        }
    }
}
