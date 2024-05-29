using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPAge
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text=Form1.fname;
            label4.Text = Form1.lname;
            label13.Text = Form1.email;
            if(Form1.sms)
            {
                label6.Text = "✔";
            }
            if(Form1.reports)
            {
                label10.Text = "✔";
            }
            if(Form1.transaction)
            {
                label9.Text = "✔";
            }
        }
    }
}
