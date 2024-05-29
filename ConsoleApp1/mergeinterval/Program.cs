using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergeinterval
{
  
    class Program
    {
        private static int m = 0;
        static void Main(string[] args)
        {
            List<Range> lis = new List<Range>();
            while (true)
            {
                int Start;
                M("Enter start value: ");
                Start = m;
                int End;
                M("Enter end value: ");
                End = m;
                int Value;
                M("Enter Value : ");
                Value = m;
                Range obj = new Range(Start, End, Value);
                int len = lis.Count();
                if (len == 0)
                {
                    lis.Add(obj);
                }
                else
                {
                    for (int k = 0; k < len; k++)
                    {
                        if (obj.Check(lis.ElementAt(k).Start, obj.Start, lis.ElementAt(k).End, obj.End, k))
                        {
                            obj.Start = Math.Min(lis.ElementAt(k).Start, obj.Start);
                            obj.End = Math.Max(lis.ElementAt(k).End, obj.End);
                            obj.Value = obj.Value + lis.ElementAt(k).Value;
                            lis.Remove(lis.ElementAt(k));
                            k--;
                           len--;
                            continue;
                        }

                    }
                    lis.Add(obj);
                }
                Print(lis);
            }
            Console.ReadLine();
        }
        static void M(string text)
        {
            label1:
            Console.Write(text);
            if(!int.TryParse(Console.ReadLine(),out m))
            {
                Console.WriteLine("invalid input enter again in number format");
                goto label1;
            }
        }

        public static void Print(List<Range> lis)
        {
            foreach (var n in lis.OrderBy(k => k.Start))
            {
                Console.WriteLine(n.Start + " - " + n.End + " - " + n.Value);
            }
        }

    }
}
