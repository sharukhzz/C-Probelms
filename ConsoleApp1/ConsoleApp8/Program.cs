using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{

    class Program
    {
        static private  Dictionary<int,MARK> d = new Dictionary<int,MARK>();
        static private Dictionary<int, MARK1> d1 = new Dictionary<int, MARK1>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n1.add number\n2.Merge \n3.Print");
                int n = int.Parse(Console.ReadLine());
          
                switch (n)
                {
                    case 1:
                        ADD();
                        break;
                    case 2:
                        Merge();
                        break;
                    case 3:
                        Print();
                        break;
                }
            }
             Console.ReadLine();
        }
       
        public static void ADD()
        {
            MARK mar = new MARK();
            Console.Write("enter number 1 : ");
            mar.n1 = int.Parse(Console.ReadLine());
 
            Console.Write("enter number 2 : ");
            mar.n2 = int.Parse(Console.ReadLine());

            Console.Write("enter the sum : ");
            mar.sum = int.Parse(Console.ReadLine());
            mar.I = d.Count+1;
            d.Add(mar.I,mar);
            Print();
           
        }
        public static void Print()
        {
            int Ans = 0;
            foreach (KeyValuePair<int, MARK> n in d)
            {
              
                Ans += n.Value.SUM;
                Console.WriteLine(n.Key + " = " + n.Value.N1 + " - " + n.Value.N2 + " - " + Ans);
            }
        }
        public static void Merge()
        {
            int k1 = 0, k2 = 0;
            MARK1 m2 = new MARK1();
            for (int i=0;i<d.Count;i++)
            {
                int key1 = d.Keys.ElementAt(i);
                MARK value1 = d.Values.ElementAt(i);
                for (int j = i + 1; j < d.Count; j++)
                {
                    int key2 = d.Keys.ElementAt(j);
                    MARK value2 = d.Values.ElementAt(j);
                    if (value1.N1 <= value2.N2 && value2.N1 <= value1.N2)
                    {
                        k1 = Math.Min(value1.N1, value2.N1);
                        k2 = Math.Max(value1.N2, value2.N2);
                        value2.N1 = k1;
                        value2.N2 = k2;
                        m2.I = d1.Count + 1;
                    }
                }
            }
            m2.k1 = k1;
            m2.k2 = k2;
            d1.Add(m2.I, m2);
            //Console.WriteLine()
            foreach (KeyValuePair<int,MARK1> f in d1)
            {
                Console.WriteLine(f.Key + " " + f.Value.K1+" "+f.Value.K2);
            }
           
        }
       
    }
}
