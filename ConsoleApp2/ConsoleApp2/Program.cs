using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /*class Sh
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name=value;
            }
        }
    }*/

      //get and set above

    class Program
    {
        static void Main(string[] args)
        {
            /*Sh obj = new Sh();
            obj.Name = "diou";
            Console.WriteLine(obj.Name);*/                           //getset


            /*inheritance_single obj1 = new inheritance_single();
            Console.WriteLine(obj1.a);
            Console.WriteLine(obj1.b);*/           //inheritance

            /* method_overloading obj2 = new method_overloading();
             Console.WriteLine(obj2.Sum(1, 2));
             Console.WriteLine(obj2.Sum(1, 2, 3));
             Console.WriteLine(obj2.Sum(1.2f, 2.3f));       */  //method overloading no of argument and changing data types

            /* method_overriding2 obj3 = new method_overriding2();
             obj3.eat();*/                                      //method overriding virtual and override

            string s = Console.ReadLine();
            long i = long.Parse(s);
            Console.WriteLine(i);
            Console.ReadLine();
        }

    }
}
