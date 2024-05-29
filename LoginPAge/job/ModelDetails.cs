using System;

namespace job
{
    public class ModelDetails : IDatas
    {
        public  string Name { get; set; }
        public int Row { get; set; }
        public int Coloumn { get; set; }
        public int Price { get; set; }
    }
}