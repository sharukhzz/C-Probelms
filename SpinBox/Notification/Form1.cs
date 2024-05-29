using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 20000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (li.Count != 0)
            {
                Screen primaryScreen = Screen.PrimaryScreen;
                Form f = li[k] as Form;
                f.Close();
                y = primaryScreen.Bounds.Height - form.Height - 50;
                for (int i=1;i<li.Count;i++)
                {
                    if(!li[i].Visible && !li[i].IsDisposed)
                    {
                        li[i].Show();
                    }
                    li[i].Location = new Point(x, y);
                    y -= form.Height + 10;
                }
                li.RemoveAt(k);
            }
            else
            {
                timer.Stop();
            }
        }

        private Form2 form;
        public static List<Form> li = new List<Form>();
        public static string s;
        private bool isFirst;
        private int x=0, y=1,k=0;
        private Timer timer;

        private void Submit(object sender, EventArgs e)
        {
            form = new Form2();
            form.TextBox1TextChanged(null,EventArgs.Empty);
            Screen primaryScreen = Screen.PrimaryScreen;
            if (y > 0)
            {
                form.Show();
            }
            x = primaryScreen.Bounds.Width - form.Width;
            if (!isFirst)
            {
                 y = primaryScreen.Bounds.Height - form.Height - 40;
                 isFirst = true;
            }
            form.Location = new Point(x, y);
            li.Add(form);
            s = "";
            y -= form.Height + 10;
            richTextBox1.Text = "";
            timer.Start();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {      
            s = richTextBox1.Text;
        }
    }
}
