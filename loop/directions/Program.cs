using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace directions
{
    class Program
    {

        //private const int n = 3;
        //private const int m = 3;
        public static void Dfs(string word, string[,] board, int r, int c, List<string> li, string s, int count)
        {
            if (count < 1)
            {
                s += word[count];
                Console.WriteLine(s[count]);
                //count++;

            }
            if (s.Equals(word))
            {
                li.Add(s);
                Console.WriteLine(true);
                return;
            }
            if (r < 0 || r >= board.Length || c < 0 || c>= board.Length  || !s[count].Equals(word[count]))
            {
                return;
            }
            if (count > 0)
            {
                if (s[count].Equals(word[count]))
                {
                    return;
                }
                if (s[count].Equals(word[count]))
                {
                    s += word[count];
                    Console.WriteLine(s[count]);
                    count++;
                    return;
                }
            }

            Dfs(word, board, r + 1, c, li, s+board[r+1,c], count+1);
            Dfs(word, board, r - 1, c, li, s + board[r, c], count+1);
            Dfs(word, board, r, c + 1, li, s + board[r, c+1], count+1);
            Dfs(word, board, r, c - 1, li, s + board[r, c-1], count+1);
        }
        static void Main(string[] args)
        {
            //string[,] board = { { "A", "B", "C", "E" }, { "S", "F", "C", "S" }, { "A", "D", "E", "E" } };
            //string word = "ABCCED";
            //int c = 0;
            //List<string> li = new List<string>();
            //int rowstart = 0, columnstart = 0;
            ////for (int i = 0; i < board.Length; i++)
            ////{
            ////    for (int j = 0; j < board[0, 0].Length; j++)
            ////    {
            ////        if (i == 0)
            ////        {
            ////            if (board[i, j].Equals(word[0]) && board[i + 1, j].Equals(word[1]) || board[i, j + 1].Equals(word[1]) )
            ////            {
            ////                rowstart = i;
            ////                columnstart = j;
            ////                break;
            ////            }
            ////            // board[i, j - 1].Equals(word[1]) || board[i - 1, j].Equals(word[1]) 
            ////            break;
            ////        }
            ////    }
            ////}
            //Dfs(word, board, rowstart, columnstart, li, "", c);
            
            Console.ReadLine();




            //int[,] a = { { 0, 0, 1,0 }, { 0,0,0,0 }, { 0,1,0,1 },{ 0, 0, 1, 0 } };
            ////Ar(a, 0, 0);
            //Direct4 obj=new Direct4();
            //obj.Dir(a);
            //Console.ReadLine();
            ////Class1
        }
        //    static void Ar(int[,] a, int i, int j)
        //    {
        //        if(i==n-1 && j==m-1)
        //        {
        //            Print(a);
        //        }
        //        else if(j==m-1)
        //        {
        //            Ar(a, i + 1, 0);
        //        }
        //        else if(j<m-1)
        //        {
        //            Ar(a, i, j + 1);
        //        }
        //    }
        //    static void Print(int [,] a)
        //    {
        //        for(int i=0;i<n;i++)
        //        {
        //            for(int j=0;j<m;j++)
        //            {
        //                Console.Write(" " + a[i, j]);
        //            }
        //            Console.WriteLine();
        //        }
        //    }
        //}

    }
}
