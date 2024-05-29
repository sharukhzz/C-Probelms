using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class ClassesForm1 : Form
    {
        public ClassesForm1()
        {
            InitializeComponent();
        }
        private void ClassesForm1_Load(object sender, EventArgs e)
        {
           PersonClass person1=new PersonClass("sharuk","khan",21);
            PersonClass person2 = new PersonClass("Gokul","das",22);
            //person1.FirstName = "sharuk";
            //person1.Lastname = "Khan";
            //person1.Age = 21;
            //person2.FirstName = "Gokul";
            //person2.Lastname = "Das";
            //person2.Age = 21;
            person1.Print(richTextBox1);
            person2.Print(richTextBox2);
            string s=person2.Fullname();
            //richTextBox1.Text = person1.FirstName + " " + person1.Lastname + " " + person1.Age;
            //richTextBox2.Text = person2.FirstName + " " + person2.Lastname + " " + person2.Age;
        }


    }
}
