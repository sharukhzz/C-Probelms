using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codechef
{
    class Class8
    {
        public static void E()
        {
            Dictionary<char, int> di = new Dictionary<char, int>();
            di.Add('c', 3);
            di.Add('b', 2);
            di.Add('a', 1);
            Dictionary<char, int> di2 = new Dictionary<char, int>();
            for(int i = 0; i < di.Count; i++)
            {
                int minv = di.ElementAt(i).Value;
                char mink= di.ElementAt(i).Key;
                for (int j = 0; j < di.Count; j++)
                {
                    if (minv > di.ElementAt(j).Value)
                    {
                        minv= di.ElementAt(j).Value;
                        mink = di.ElementAt(j).Key;
                        Console.WriteLine(mink);

                    }

                }
                di2.Add(mink, minv);
                di.Remove(mink);
            }
            Console.WriteLine("hello");
            foreach (var pair in di2) Console.WriteLine(pair.Key + " -> " + pair.Value);
        }
    }
}
