using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergeinterval
{
    public class Range
    {
        public int Start { get; set; }
        public int End { get; set; }
        public int Value { get; set; }
        public Range(int Start, int End, int Value)
        {
            this.Start = Start;
            this.End = End;
            this.Value = Value;
        }
        public bool Check(int start1,int start2,int end1,int end2,int k)
        {
            int max = Math.Max(start1, start2);
            int min = Math.Min(end1,end2);
            if(max-min<=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
