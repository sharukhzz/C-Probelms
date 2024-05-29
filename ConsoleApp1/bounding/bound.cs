using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bounding
{
    class Range
    {
        public int Start { get; set; }
        public int End { get; set; }
    }


    class bound
    {
        static void Main(string[] args)
        {

            int size = 1;

            Dictionary<int, Range> dict = new Dictionary<int, Range>();

            while (true)
            {
                Range r = new Range();
                
                Console.WriteLine("Enter start range :");
                r.Start = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter end range :");
                r.End = Convert.ToInt32(Console.ReadLine());

                int len = dict.Count;
                for (int i = 0; i < len; i++)
                {

                    int max = Math.Max(dict.ElementAt(i).Value.Start, r.Start);
                    int min = Math.Min(dict.ElementAt(i).Value.End, r.End);

                    if (max - min < 0)
                    {
                        r.Start = Math.Min(dict.ElementAt(i).Value.Start, r.Start);
                        r.End = Math.Max(dict.ElementAt(i).Value.End, r.End);
                        dict.Remove(dict.ElementAt(i).Key);
                        i--;
                        len--;
                        continue;
                    }
                }

                dict.Add(size, r);
                size++;

                foreach (KeyValuePair<int, Range> it in dict)
                {
                    Console.WriteLine(it.Value.Start + " - " + it.Value.End);
                }
            }
            Console.ReadLine();

        }
    }
}
