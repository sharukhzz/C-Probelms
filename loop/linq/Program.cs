using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 1, 2, 3, 4, 5 };
            ////count
            //int n = a.Count(k => k==1);
            //Console.WriteLine(n);
            //int n1 = a.ElementAt(1);
            //Console.WriteLine(n1);
            ////int[] a1 = a.Distinct(1);
            //Console.ReadLine();
            int id = int.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            D obj = new D();
            obj.Ip += Ip1;
            List<int> d = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                d.Add(id + (age+1));
            }
            obj.Reads(d);
            Console.ReadLine();
        }
            private static void Ip1(int id, int age)
            {
            Console.WriteLine($"{id}:{age}");
            }
        
    }
        public class D
        {
            public delegate void ev(int id, int age);
            public event ev Ip;
        public void Reads(List<int> d)
        {
            int len = d.Count();
            for(int i=0;i<len;i++)
            {
                if(Ip!=null)
                {
                 //   Ip.Invoke(d);
                }
            }
        }
    }
}
