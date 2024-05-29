using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace job
{

    public class JobDetails :  IDatas
    { 
        public string Name { get; set; }
        public int Row { get; set; }
        public int Coloumn { get; set; }
        public int Price { get; set; }
        public string Model { get; set; }
        public string Runname { get; set; }
    }
}