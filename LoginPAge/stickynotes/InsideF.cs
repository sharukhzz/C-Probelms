using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stickynotes
{
    public partial class InsideF : UserControl
    {
        private string currentString="";
        public InsideF()
        {
            InitializeComponent();
        }

        public string CurrentString { get => currentString; set
            {
                string a ="";
                currentString = value;
                if (value!=null)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (i % 40 == 0 && i!=0)
                        {
                            a += '\n';
                            Height = 10+label2.Height ;
                        }
                        a += value[i];
                    }
                    label2.Text = a;
                }

            }
        }
    }
}
