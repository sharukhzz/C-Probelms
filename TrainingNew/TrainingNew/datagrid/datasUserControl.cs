using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingNew
{
    public partial class datasUserControl : UserControl
    {
        public datasUserControl()
        {
            InitializeComponent();
        }
        public event EventHandler<(int employeeid, string name, int age, string department, int salary)> datagridEvent;
        private void button1_Click(object sender, EventArgs e)
        {
            datagridEvent?.Invoke(sender, (Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text)));
        }
        //private int id, age, salary;
        //private string name, department;

        public int Id
        {
            set { textBox1.Text = value+""; }
        }
        public int Age
        {
            set { textBox3.Text = value + ""; }
        }
        public int Salary
        {
            set { textBox5.Text = value + ""; }
        }
        public string Department
        {
            set { textBox4.Text = value; }
        }
        public string Names
        {
            set { textBox2.Text = value + ""; }
        }
    }
}
