using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingNew.Property
{
    public partial class AddUserControl : UserControl
    {
        public AddUserControl()
        {
            InitializeComponent();
        }
        public String Addtext
        {
            get {return richTextBox1.Text; }
            set
            {
                richTextBox1.Text = value + richTextBox1.Text;
            }
        }

    
    }
}
