using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    class PersonClass
    {
        //public string FirstName { get; set; }
        //public string Lastname { get; set; } //get set
        //public int Age { get; set; }

        public string FirstName { get; set; }
        public string Lastname { get; set; } //get set
        public int Age { get; set; }
        public PersonClass(string f,string l,int a)
        {
            FirstName = f;
            Lastname = l;
            Age = a;
        }

        public string Fullname()
        {
            return FirstName + Lastname;
        }

        public void Print(RichTextBox richTextBox)
        {
            richTextBox.Text = FirstName + " " + Lastname + " " + Age;
        }
    }
}
