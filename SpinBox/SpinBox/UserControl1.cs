using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpinBox
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public int ans = 0;
        public int max = 999;
        public int min = -999;
        private void Button1Click(object sender, EventArgs e)
        {
            if (ans - 1 < min) return;
            label.Text =(ans - 1).ToString();
            ans--;
        }

        private void Button2Click(object sender, EventArgs e)
        {
            if (ans + 1 > max) return;
            label.Text = (ans + 1).ToString();
            ans++;
        }
        private bool ismove;
        private int prev = 0;
        private void LabelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ismove = true;
            prev = e.X;
        }

        private void LabelMouseUp(object sender, MouseEventArgs e)
        {
            ismove = false;
        }

        private void LabelMouseMove(object sender, MouseEventArgs e)
        {
            if (!ismove) return;
            if(prev<e.X)
            {
                if (ans + 1 > max) return;
                label.Text = (ans + 1).ToString();
                ans++;
            }
            else
            {
                if (ans - 1 < min) return;
                label.Text = (ans - 1).ToString();
                ans--;
            }
            prev = e.X;
        }
        public string s = "";
        public int Get
        {
            set
            {
                label.Text = "";
                s = value.ToString();
                label.Text = s;
            }
        }
        public TextBox t=new TextBox();
        private void LabelMouseDoubleClick(object sender, MouseEventArgs e)
        {

            t.Text = label.Text;
            t.Size = label.Size;
            t.BackColor = Color.Black;
            t.Location = label.Location;
            t.Font = label.Font;
            t.ForeColor = Color.White;
            t.Multiline = true;
            Controls.Add(t);
            t.BringToFront();
            t.KeyPress += T_KeyPress;
           // t.KeyDown += T_KeyDown;
            // if (Convert.ToInt32(t.Text) < min || Convert.ToInt32(t.Text) > max) return;          
        }

        
        private void T_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
               
                // MessageBox.Show(t.Text);
                int v = Convert.ToInt32(t.Text);
                Controls.Remove(t);
                if (v < min) v = min;
                if (v > max) v = max;
                label.Text = v.ToString();
                ans = v;
            }
           if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
