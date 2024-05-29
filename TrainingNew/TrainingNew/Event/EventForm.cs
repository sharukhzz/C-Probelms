using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingNew
{
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
            EventsUserControl eve = new EventsUserControl(); 
            Controls.Add(eve); //add usercontrol by code
            eve.Location = new Point(200, 100); //changing usercontrol location by code
            eve.One += Eve_One;
            eve.Normal += Eve_Normal;
            eve.Multiple += Eve_Multiple;
            eve.EventDel += Eve_EventDel;
            eventsUserControl1.Normal += EventsUserControl1_Normal; //add usercontrol by design no need to create obj
        }

        private void EventsUserControl1_Normal(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
            eventsUserControl1.Normal -= EventsUserControl1_Normal;
        }

        private void Eve_EventDel(int i, int i2, int i3, string s)
        {
            textBox1.Text = s;
        }

        private void Eve_Multiple(object sender, (int i, string s) e)
        {
            textBox1.Text = e.s;
        }

        private void Eve_Normal(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Beige;
        }

        private void Eve_One(object sender, string e)
        {
            textBox1.Text = e;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
