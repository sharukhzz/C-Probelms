using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace License
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            totalsecond--;
            int hour = totalsecond / 3600;
            int minute = totalsecond / 60;
            int second = totalsecond % 60;
            textBox3.Text = hour.ToString() +":"+minute.ToString() +":"+ second.ToString();
            if(totalsecond<=0)
            {
                timer.Stop();
                MessageBox.Show("License is expired");
            }
        }

        private DateTime dateTime;
        private Timer timer;
        private int totalsecond;

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            try
            {
                string f = File.ReadAllText(@"D:\File.txt"); 
                textBox2.Text = f;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "0")
            {
                MessageBox.Show("License is not expired");
            }
            else
            {
                MessageBox.Show("License is expired");
            }
            label3.Visible = true;
            textBox3.Visible = true;
            totalsecond = int.Parse(textBox2.Text) * 60;
            timer.Start();

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
        }
    }
}
