using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnPasswordBoxTextChanged(object sender, EventArgs e)
        {
            button1.Visible = textBox2.Text == "123";
        }

        private void OnClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Clicked");
            MessageBox.Show("Clicked");
            //Form form2 = new Form();
            //Button button = new Button();
            //Button button2 = new Button();
            //button.Text = "111";
            //button.Location = new Point(50, 50);
            //button2.Location = new Point(0, 0);
            //Controls.Add(button);
            //panel1.Controls.Add(button2);
            //panel1.Controls.Remove(button2);
            //form2.StartPosition = FormStartPosition.CenterParent;
            //form2.ShowDialog();
            //int a = 10;
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
