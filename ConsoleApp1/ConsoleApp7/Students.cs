using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Students
    {
        public int id { get; set; }
        public int totalmark = 600;
        public string Name { get; set; }
        //public int mark1;
        public int Mark1 { get; set; }
        // public int mark2;
        public int Mark2 { get; set; }
        //public int mark3;
        public int Mark3 { get; set; }
        //public int mark4;
        public int Mark4 { get; set; }
        //public int mark5;
        public int Mark5 { get; set; }
        private int mark6;
        public int Mark6
        {
            get
            {
                return mark6;
            }
            set
            {
                mark6 = value;
                Total();
                Pf();
                Percentage();
                Cutoff();

            }
        }
        public void Total()
        {
            int Tot = Mark6 + Mark5 + Mark4 + Mark3 + Mark2 + Mark1;
            To = Tot;
        }
        public int To { get; set; }
        public void Pf()
        {
            string pf = "";
            if (Mark1 < 40 || Mark2 < 40 || Mark3 < 40 || Mark4 < 40 || Mark5 < 40 || mark6 < 40)
            {
                pf = "fail";
            }
            else
            {
                pf = "pass";
            }
            Passfail = pf;
        }
        public string Passfail{get; set;}
        public void Percentage()
        {
            float t = (Mark1 + Mark2 + Mark3 + Mark4 + Mark5 + Mark6) * 100;
            t = t / totalmark;
           // Console.WriteLine(t);
            Percent = t;
           
        }
        //public float percent;
        public float Percent{get; set;}
        public void Cutoff()
        {
            float t =Mark6+(float)(Mark4+Mark5)/2;
            Cut = t;
            //Console.WriteLine(Cut);
        }
        //public float cutoff;   
        public float Cut { get;set; }
        public int rank;
    }
}
