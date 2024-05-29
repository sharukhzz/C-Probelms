using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codechef
{
    class Class3
    {
        static int left = 0;
        static int tr = 3, tc = 1;
        public static void REC()
        {
            int[,] a = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

            Console.WriteLine(minSum(tr,tc,a,new Dictionary<string,List<List<int>>>()));
        }
        
        public static List<List<int>> minSum(int row, int column, int[,] arr, Dictionary<string, List<List<int>>> memo)
        {
            string s = row + "," + column;
            if (memo.ContainsKey(s)) return memo[s];

            if (row == 0 && column == 0) return new List<List<int>> { new List<int> {arr[row,column] },new List<int> { arr[row,column]}  };
            if (row < 0 || column < 0 || row > arr.Length || column > arr.Length) return new List<List<int>> { new List<int> { 100000 }, new List<int> { -1 } }; ;

            List<List<int>> left = minSum(row, column - 1, arr, memo);
            List<List<int>> up = minSum(row - 1, column, arr, memo);
            List<List<int>> diagonal = minSum(row - 1, column - 1, arr, memo);

            int min = Math.Min(left[0][0]+arr[row,column], Math.Min(up[0][0]+arr[row,column], diagonal[0][0]+arr[row,column]));

            if (left[0][0] + arr[row, column]==min)
            {
                memo[s] = new List<List<int>> { new List<int> { left[0][0]+arr[row,column]},new List<int> (left[1] ) };
                memo[s][1].Insert(0,arr[row,column]);
            }
            else if (up[0][0]+arr[row,column]==min)
            {
                memo[s] = new List<List<int>> { new List<int> { up[0][0] + arr[row, column] }, new List<int>(up[1]) };
                memo[s][1].Insert(0, arr[row, column]);
            }
            else
            {
                memo[s] = new List<List<int>> { new List<int> { diagonal[0][0] + arr[row, column] }, new List<int>(diagonal[1]) };
                memo[s][1].Insert(0, arr[row, column]);
            }

            if (row == tr && column == tc)
            {
                Console.WriteLine(memo[s][0][0]+":"+string.Join("->",memo[s][1]));
            }
            return memo[s];
        }


        static void RR(int tr,int tc,int [,] a)
        {
            //int n = 1;
            if (tc > 0)
            {
                left += a[tr, tc];
                Console.Write(left + " ");
                RR(tr, tc - 1, a);
            }
            else if(tr>=0)
            {
                left += a[tr, tc];
                Console.Write(left + " ");
                RR(tr-1, tc , a);
            }
            //return RR(tr, tc + 1, a) ? n != 0 : RR(tr, tc - 1, a);
            //int Right = a[tr, tc];
            //RR(tr - 1, tc, a);
            //int Diag = a[tr, tc];
            //RR(tr - 1, tc - 1, a);
            // max = Math.Min(left, Right);
            //+ Right + " " + Diag + " " + max);
            List<String> li = new List<string>();
          

            
        }

        public static string LongestPalindrome(string s)
        {
            string maxS = "";
            s = "aacabdkacaa";
            string temp = s;
            for (int i = 0; i < s.Length; i++)
            {

                int index = temp.LastIndexOf(s[i]);
                if (index < i)
                {
                    temp = s;
                    continue;
                }
                string check = temp.Substring(i, index-i+1);
                
                if (isPalin(check))
                {
                    maxS = (check.Length > maxS.Length) ? check : maxS;
                    temp = s;
                    continue;
                }
                temp = temp.Substring(0, index-i);
                i--;
            }
            return maxS;

        }

        public static bool isPalin(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j]) return false;
            }
            return true;
            //int i=Int32.MaxValue;
            
        }
    }
}
