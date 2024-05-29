using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_rec
{
    class Program
    {
        public static int M(int[,] a, int s, int e, int min, int ans)
        {
            if (s < 0 || e < 0 || s >= a.GetLength(0) || e >= a.GetLength(1)) return 0;
            if (s == a.Length - 1 && e == a.Length - 1)
            {
                if (min < ans)
                {
                    ans = min;
                }
            }
            if (a[s, e + 1] < a[s - 1, e])
            {
                M(a, s, e + 1, min + a[s, e], ans);
            }
            else
            {
                M(a, s - 1, e, min + a[s, e], ans);
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int[,] dungeon = {{-2,-3,3},{-5,-10,1},{10,30,-5}};
            int ans = Int32.MaxValue;
            M(dungeon, 0, 0, 0, ans);
        }
    }
}
