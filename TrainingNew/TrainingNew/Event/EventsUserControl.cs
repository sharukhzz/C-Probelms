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
    public partial class EventsUserControl : UserControl
    {
        public EventsUserControl()
        {
            InitializeComponent();
        }
        public event EventHandler Normal;
        public event EventHandler<string> One;
        public event EventHandler<(int i,string s)> Multiple;
        public delegate void DelEvents(int i, int i2, int i3, string  s);
        public event DelEvents EventDel;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Normal?.Invoke(sender, EventArgs.Empty);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            One?.Invoke(sender, textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Multiple?.Invoke(sender, (1, textBox3.Text));
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            EventDel?.Invoke(1, 2, 3, textBox4.Text);
        }
    }
}
