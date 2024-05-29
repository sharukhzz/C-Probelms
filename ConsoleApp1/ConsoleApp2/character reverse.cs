using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class character_reverse
    {
        string[] st = Console.ReadLine().Split(' ');
        public character_reverse()
        {
            int leng = st.Length;
            string[] sti = new string[leng];
            int j = 0;
            for (int i = leng - 1; i >= 0; i--)
            {
                sti[j] = st[i];
                j++;
            }
            int x = 0;
            string[] stri = new string[st.Length];
            for (int i = 0; i < sti.Length; i++)
            {

                int len = 0;
                string s = "";
                s = sti[i];
                char[] co = s.ToCharArray();
                len = sti[i].Length;
                for (int k = len - 1; k >= 0; k--)
                {
                    stri[x] += co[k];
                }
                x++;
            }
                foreach (var n in stri)
                {
                    Console.Write(n+" ");
                }

        }

        }
}
