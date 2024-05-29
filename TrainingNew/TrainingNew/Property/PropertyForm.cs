using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingNew
{
    public partial class PropertyForm : Form
    {
        public PropertyForm()
        {
            InitializeComponent();
            prevWidth = Width;
            prevHeight = Height;
        }
        private int prevWidth, prevHeight;

        private void button1_Click(object sender, EventArgs e)
        {
            Classforpropety.Text = richTextBox1.Text; //in class get set
            richTextBox1.Text = Classforpropety.Text;
            addUserControl1.Addtext = richTextBox1.Text; //form to obj using property
            richTextBox1.Text = addUserControl1.Addtext; //setting value from usercontrol to form like event
        }

        private void button2_Click(object sender, EventArgs e)
        {
            subUserControl1.Subtext = richTextBox1.Text; //only using set in usercontrol not using get means return
        }
        protected override void OnResize(EventArgs e)
        {
            if (prevWidth != 0)
            {
                richTextBox1.Width = Width / (prevWidth/richTextBox1.Width);
                richTextBox1.Height = Height / (prevHeight/richTextBox1.Height);
                prevWidth = Width;
                prevHeight = Height;
            }
        }
    }
}
