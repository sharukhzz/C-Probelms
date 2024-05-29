using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManager
{
    public class ModelDetails : Interfacedatas
    {
        public string Name { get; set; }
        public int Row { get; set; }
        public int Coloumn { get; set; }
        public int Price { get; set; }
    }
}
