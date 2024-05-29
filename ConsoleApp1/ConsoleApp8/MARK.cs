using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class MARK
    {
        public int n1;
        public int N1
        {
            get
            {
                return n1;
            }
            set
            {
                n1 = value;
            }
        }
        public int n2;
        public int N2
        {
            get
            {
                return n2;
            }
            set
            {
                n2 = value;
            }
        }
        public int sum;
        public int SUM
        {
            get
            {
                return sum;
            }
            set
            {
                sum = value;
                Merge();
            }
        }
            
        public int I { get; set; }
        public void Merge()
        {
           
        }
    }
}
