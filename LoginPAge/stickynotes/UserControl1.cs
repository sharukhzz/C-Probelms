using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stickynotes
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public delegate void Toexit(bool exit);
        public event Toexit Exits;
        public event  EventHandler Open;
        public delegate void Textchanged(string s,Font font);
        public event Textchanged Texts;
        private bool isInitial;

        private void ExitClick(object sender, EventArgs e)
        {
            Exits?.Invoke(true);
        }

        private void AddClick(object sender, EventArgs e)
        {
            Open?.Invoke(null, e);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Texts?.Invoke(richTextBox1.Text,richTextBox1.Font);

        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isInitial)
            {
                richTextBox1.Text = "";
                isInitial = true;
            }
        }
    }
}
