using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Lion : IAnimal
    {
        public string AnimalName { get;set; }
        public string Age { get; set; }
        public string Species { get; set; }
        public int Sizes { get; set; }

        public Lion(string an,string a,string s,int siz)
        {
            AnimalName = an;
            Age = a;
            Species = s;
            Sizes = siz;
        }

        public string MakeSound()
        {
            return "Barking";
        }
    }
}
