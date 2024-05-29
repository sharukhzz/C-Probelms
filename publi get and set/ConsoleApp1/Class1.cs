using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public static void Y()
        {
            string s = "DDI";
            int flag = 1;
            List<int> li = new List<int>();
            int x = 0, y = s.Length;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'D')
                {
                    li.Add(y);
                    y--;
                    flag = 1;
                }
                else
                {
                    li.Add(x);
                    x++;
                }
            }
            if(flag==1)
            {
                li.Add(y);
            }
            else
            {
                li.Add(x);
            }
            foreach(var  n in li)
            {
                Console.Write(n + " ");
            }
        }
        public static void PP()
        {
            //string s = "aaaabbbbcccc";
            //char[] ss = s.ToCharArray();
            //Array.Sort(ss);
            //string ssy = new string(ss);
            ////Console.WriteLine(ssy);
            //StringBuilder su = new StringBuilder();
            //int k = 0;
            //while(k<s.Length)
            //{
            //    su.Append(ss[0])
            //    for(int i=0;i<ss.Length;i++)
            //    {
            //        if(s[i]<)
            //   }
            //}
            //string[] s = { "prssn", "da" };
            //string a = "";
            //for(int i=0;i<s.Length;i++)
            //{
            //    a += s[i];
            //}
            //Console.WriteLine(a);
            int[] nums = { 1 };
            int k = 1;
            int s = 0, e = k;
            float max = 0;
            while (e <= nums.Length)
            {
                float a = 0;
                for (int i = s; i < e; i++)
                {
                    a += nums[i];
                }
               // if(co==k)
                Console.WriteLine("s is : " + s);
                Console.WriteLine("e is : "+e);
                a = a / k;
                Console.WriteLine(a);
                if (a > max)
                {
                    max = a;
                }
                //if (e == nums.Length)
                //{
                    s++;
                    e = s+k;
                    //Console.WriteLine("s is"+s);
                    //Console.WriteLine("e is"+e);
               // }
            }
            Console.WriteLine("max is : " + max);
        }
    }
}
