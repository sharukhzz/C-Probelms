using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Elepant : IAnimal
    {
        public string AnimalName { get; set; }
        public string Age { get; set; }
        public string Species { get; set; }
        public int TuskLength { get; set; }

        public Elepant(string a,string aa,string sp,int t)
        {
            AnimalName = a;
            Age = aa;
            Species = sp;
            TuskLength = t;
        }

        public string MakeSound()
        {
            return "Huge";
        }
    }
}
