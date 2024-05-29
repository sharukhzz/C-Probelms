using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class FLAMES
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        public FLAMES()
        {

            int K = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j])
                    {
                        c++;
                    }
                }
                if (c < 1)
                {
                    K++;
                }
            }
            for (int i = 0; i < s2.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < s1.Length; j++)
                {
                    if (s2[i] == s1[j])
                    {
                        c++;
                    }
                }
                if (c < 1)
                {
                    K++;
                }
            }
            Console.WriteLine(K);
            string s = "flames";
            char[] a = s.ToCharArray();
            /*int x = s.Length;
            if(K<7)
            {
                for(int i=1;i<=x;i++)
                {
                    if(K%i==0)
                    {
                        s=s.Replace(s[i], ' ');
                    }
                }
                Console.WriteLine(s);*/
            /*  int v = 0;
              for(int i=0;i<6;i++)
              {
              if(v<5)
                  {
                      if (K > 6)
                      {
                          i = 0;
                      }
                      a[K-1] = ' ';
                      K += K;
                      v++;

                  }


              }
              string p = a.ToString();
              Console.WriteLine(a);*/
            int ans = K;
            bool[] b = new bool[7];

            int count = 0, it = 0;

            for (int i = 1; i <= 6; i++)
            {
                it++;

                if (b[i] == true)
                {
                    if (i == 6)
                        i = 0;
                    it--;
                    continue;
                }
                //  Console.WriteLine(it);
                if (it == ans)
                {

                    it = 0;
                    b[i] = true;
                    count++;
                    // Console.WriteLine(i + "  "+ count);
                }

                if (count == 5)
                {
               
                    break;
                }

                if (i == 6)
                    i = 0;
            }

            for (int i = 1; i < 7; i++)
            {
                if (b[i] == false)
                    ans = i;
            }

            switch (ans)
            {
                case 1:
                    Console.WriteLine("Friends");
                    break;
                case 2:
                    Console.WriteLine("Love");
                    break;
                case 3:
                    Console.WriteLine("Affection");
                    break;
                case 4:
                    Console.WriteLine("Marraige");
                    break;
                case 5:
                    Console.WriteLine("Enemy");
                    break;
                case 6:
                    Console.WriteLine("Sister");
                    break;

            }

        }


    }
}
   
   



