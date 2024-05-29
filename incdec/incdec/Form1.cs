using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace incdec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Panel1Resize(object sender, EventArgs e)
        {
            int height = panel1.Height - numericUpDown1.Height;
            int width = panel1.Width - numericUpDown1.Width;
            numericUpDown1.Location = new Point(width / 2, height / 2);
            //numericUpDown1.Size = new Size(width/2, height/2);
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1Click(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToString();
            label2.Text = dateTimePicker1.Value.ToLongDateString();
            label3.Text = dateTimePicker1.Value.ToShortDateString();
            label4.Text = dateTimePicker1.Value.ToShortTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Form2 obj = new Form2();
        private void button2_Click(object sender, EventArgs e)
        {
            obj.Show();
        }
    }
}
