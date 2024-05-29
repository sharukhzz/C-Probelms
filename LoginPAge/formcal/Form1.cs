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
    public partial class Form1 : Form
    {
        private Inputs obj = new Inputs();
        public Form1()
        {
            InitializeComponent();
            obj.Resultedvalue += Cal;
        }
        private int num = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            obj.Show();      
        }    
        
        private void Cal(object sender,double f)
        {
            textBox1.Text = f.ToString();
        }

        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) num = 1; 
            if (radioButton2.Checked) num = 2;
            if (radioButton3.Checked) num = 3;
            if (radioButton4.Checked) num = 4;
            if (radioButton5.Checked) num = 5;
            obj.Cal(num);
        }
    }
}
