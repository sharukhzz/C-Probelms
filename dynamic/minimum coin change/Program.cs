using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                       
namespace minimum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coin = { 1, 2, 5 };
            int amount = 6;
            int[] dp = new int[amount + 1];
            for (int i = 1; i <= amount; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < coin.Length; j++)
                {
                    if (i >= coin[j] && dp[i - coin[j]] != -1)
                    {
                        min = Math.Min(min, dp[i - coin[j]]);
                    }
                }
                dp[i] = (min == int.MaxValue) ? -1 : min + 1;
                Console.WriteLine(String.Join(" ",dp));
            }
            Console.WriteLine(dp[amount]);
            //P.N obj = new P.N();
            //obj.F();
            //P.M.F();
            Console.ReadLine();
        }

    }
    //class P
    //{
    //    public abstract class M
    //    {
    //        public abstract void print();
    //        public static void F()
    //        {
    //            Console.WriteLine("as");
    //        }
    //    }
    //    public class N : M
    //    {
    //        public override void print()
    //        {

    //        }
    //       public virtual void F()
    //        {
    //            Console.WriteLine("afva");
    //        }
    //    }
    //}
}
