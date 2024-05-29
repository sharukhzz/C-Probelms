using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class with_space_reverse
    {
      
        string[] st = Console.ReadLine().Split(' ');
        public with_space_reverse()
        {
            int len = st.Length;
            string[] stri = new string[len];
            int j = 0;
            for (int i = len-1; i >= 0; i--)
            {
                stri[j] = st[i];
                j++;
            }
            foreach (var n in stri)
            {
                Console.Write(n+" ");
            }
          
        }
    }
}
