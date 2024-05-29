using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation3_part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form2.EveForm2 += Form2_EveForm2;
        }
        private bool b;
          public delegate void EventsNew(string s1, string s2);
        public static event EventsNew UserNames;
        public Form2 form2 = new Form2();

        public static string User { get; set; }

        private void Form2_EveForm2(object sender, string e)
        {
            label3.Text = e;
            User = e;
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label4.Text = "Warning Enter proper Username and password";
            List<string> li = new List<string>();
            int c = 0;
            foreach(var item in UserManagerClass1cs.list)
            {
                if(item.Username==textBox1.Text)
                {
                    label4.Text = "User name Already Added";
                    label4.Visible = true;
                }
                else
                {
                    c++;
                }
            }
            if (textBox1.Text != "" && textBox2.Text != ""  && label4.Visible==false)
            {
                User = label3.Text;
                if(!b) form2.Show();
                b = true;
                UserNames?.Invoke( textBox1.Text,label3.Text);
            }
            else
            {
                label4.Visible = true;
            }
        }
    }
}
