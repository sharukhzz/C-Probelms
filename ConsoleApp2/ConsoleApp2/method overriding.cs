using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class method_overriding1
    {
        public virtual void eat()
        {
            Console.Write("eat");
        }
    }
    class method_overriding2 : method_overriding1
    {
        public override void eat()
        {
            Console.WriteLine("eating");
        }

    }
}
