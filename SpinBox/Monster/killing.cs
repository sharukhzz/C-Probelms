using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monster.Properties;

namespace Monster
{
    public partial class killing : UserControl
    {
        public killing()
        {
            InitializeComponent();
        }

        private void killing_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.killing;
        }
    }
}
