using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formcal
{
    public partial class Inputs : Form
    {
        public Inputs()
        {
            InitializeComponent();
        }
        //private delegate void names(int n1, int n2); //delegate and events
        //private event names Na;
        public event EventHandler<double> Resultedvalue;
        private void TKeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar!='\b' && e.KeyChar!='.' )
            {
                e.Handled = true;
            }
        }
        public void Cal(int number)
        {
                double n1 = Convert.ToDouble(textBox1.Text);
                double n2 = Convert.ToDouble(textBox2.Text);
                double res = 0;
                if (number == 1) res = n1 + n2;
                if (number == 2) res = n1 - n2;
                if (number == 3) res = n1 * n2;
                if (number == 4) res = n1 / n2;
                if (number == 5) res = n1 % n2;
                Resultedvalue?.Invoke(this, res);
        }

    }
}
