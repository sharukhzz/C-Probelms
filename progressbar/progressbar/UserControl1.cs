using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressbar
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            //Mains+=
        }
        private static int val = 0;
        private void ProgressBar1Click(object sender, EventArgs e)
        {
            val = progressBar1.Value;
        }
        private bool isMousePressed;
        private int prev = 0;
        public event EventHandler<int> ProgValue;
        private void ProgressBarMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
                isMousePressed = true;
                prev = e.X;
        }
       private void ProgressBar1MouseUp(object sender, MouseEventArgs e)
        {
            isMousePressed = false;
            ProgValue?.Invoke(this, progressBar1.Value);
            H.Text = heights.ToString();
            W.Text = widths.ToString();

        }
        private void ProgressBarMouseMove(object sender, MouseEventArgs e)
        {
           
            if (!isMousePressed || progressBar1.Value < 0) return;
            if (progressBar1.Value >= 100)
            {
                progressBar1.Value -= 1;
            }
            if (prev < e.X)
            {
                progressBar1.Value += 1;
            }
            else if(progressBar1.Value>0)
            {
                progressBar1.Value -= 1;
            }
            prev = e.X;
          
        }
        public int heights;
        public int HeightsShow
        {
            get{ return heights; }
            set{heights=value;}
        }
        public int widths;
        public int WidthsShow
        {
            get { return widths; }
            set { widths = value; }
        }
        public int Resizeheight
        {
            set
            {
                H.Text = value.ToString();
            }
        }
        public int Resizewidth
        {
            set
            {
                W.Text = value.ToString();
            }
        }
    }
}
