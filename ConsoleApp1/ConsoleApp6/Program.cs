using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Student
    {
        // public string s;
        public string S
        {
            get;
            set;
        }
       // public int m;
        public int M
        {
            get;
            set;

        }
        public void Per(out float g)
        {
            float f = M * 100;
            f = ((f) / 600);
            g = f;
            //Console.WriteLine(g);
        }
        public float g;
        public float P
        {
            get
            {
                return g;
            }
            set
            {
                float g = value;
            }
        }
        /* public void Rank(List<Student> d, int n)
         {
             for (int j = 0; j < n; j++)
             {
                 int c = 1;
                 for (int k = j + 1; j < n; j++)
                 {
                     if (d[j].M > d[k].M)
                     {
                         c++;
                     }
                 }
                 d[j].rank = c;
             }

         }*/
        public int rank;
        //        public int Ra
        //        {
        //            get
        //            {
        //                return rank;
        //            }
        //            set
        //            {
        //                rank = value;
        //            }
        //        }
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the size : ");
            int n =int.Parse( Console.ReadLine());
            int y = n;
            var d = new List<Student>(n);
            int i = 1;
            while (n-- > 0)
            {
                Student stu = new Student();
                Console.Write("enter the name : ");
                stu.S = Console.ReadLine();
                //d.Add(Console.ReadLine());
                Console.Write("enter the mark : ");
                stu.M = int.Parse(Console.ReadLine());
                Console.Write("enter the mark : ");
               // stu.M2 = int.Parse(Console.ReadLine());
               // Console.Write("enter the mark : ");
              //  stu.M3 = int.Parse(Console.ReadLine());
                stu.Per(out float g);
                stu.g = g;  
                d.Add(stu);
                //stu.Rank(d, n);   
                i++;
            }
            //Console.WriteLine("da1");
            for (int j = 0; j < y; j++)
            {
                //Console.WriteLine("da2");

                int c = 1;
                for (int k = 0; k < y; k++)
                {
                    if (d[j].M < d[k].M)
                    {
                        c++;
                        //Console.WriteLine("da");
                    }
                   // Console.WriteLine("dadfs");
                }
                d[j].rank = c;
            }
            Console.WriteLine("name" +" "+ "marks" +" " + "percentage" +" "+"rank");
            foreach (var k in d)
            {
                Console.WriteLine(k.S + " " + k.M + " "+k.P+" "+k.rank);
            }
            Console.WriteLine("enter the id to remove : ");
            int id = int.Parse(Console.ReadLine());
       //     for(int o=1;o<y;i++)
         //   {
            //    d[o].remove;
           // }
            Console.ReadLine();
        }
    }
}
