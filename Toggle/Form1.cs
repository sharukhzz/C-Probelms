using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toggle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Panel1Click(object sender, EventArgs e)
        {
            Button Togg = new Button
            {
                Text = "OnOff",
                Size = new Size(80, 30),
                BackColor=Color.AliceBlue,
            };
            panel1.Controls.Add(Togg);
        }
    }
}
