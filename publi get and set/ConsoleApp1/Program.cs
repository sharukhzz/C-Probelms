using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sh
    {
        private int age;
        public int Age
        {
            get { return age; }
            set {
                if (value > 0)
                { age = value; }
                else
                {
                    Console.WriteLine("enter the age in positive number");
       
                }       
                }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Sh obj = new Sh();
            //obj.Age = -2;
            ////Console.WriteLine("kakj : "+obj.Age);
            //Class1.PP();
            //Class1.Y();
            //Class2.LL();
            //Class2.U();
            // Class2.K();
            //Class2.NN();
            // Class2.LLq();
            //Class2.S();
            //Class2.KK();
            Console.WriteLine(Class2.Pal ("abbcccbbbcaaccbababcbcabca"));
            Console.ReadLine();
        }
    }
}
