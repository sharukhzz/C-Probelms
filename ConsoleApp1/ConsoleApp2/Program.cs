using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\n1.with space reverse\n2.characterreverse\n3.countcharacter");
                Console.Write("enter a number : ");
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        with_space_reverse obj = new with_space_reverse();
                        break;
                    case 2:
                        character_reverse obj2 = new character_reverse();
                        break;
                    case 3:
                        countcharacter obj3 = new countcharacter();
                        break;
                }
            }
            Console.ReadLine();

        }
    }
}
