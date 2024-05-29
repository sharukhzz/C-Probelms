using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation2Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calendar calendar = new Calendar();
        private void Form1_Load(object sender, EventArgs e)
        {
            Controls.Add(calendar);
        }
    }
}
