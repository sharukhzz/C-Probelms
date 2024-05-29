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
    public partial class Form1 : Form
    {
        public static string fname;
        public static string lname;
        public static string email;

        public static Boolean sms;
        public static Boolean reports;
        public static Boolean transaction;

        Form2 obj = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1Click(object sender, EventArgs e)
        {
            fname = textBox1.Text;
            lname = textBox2.Text;
            email = textBox3.Text;
            obj.Show();
            this.Hide();
        }
        private void CheckBox1CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                sms = true;
                label4.Text = "Services charges may aplly for Sms";
            }
            else
            {
                sms = false;
                label4.Text = "...";
            }
        }

        private void CheckBox2CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                reports = true;
            }
            else
            {
                reports = false;
            }
        }

        private void CheckBox3CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                transaction = true;
                label6.Text = "Services charges may aplly for Transcation";
            }
            else
            {
                transaction = false;
                label6.Text = "...";
            }
        }
    }
}
