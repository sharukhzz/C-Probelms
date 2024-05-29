using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressbar
{
    public partial class Form1 : Form
    {
        //public event EventHandler<int> Heights;
        //public event EventHandler<int> Widths;

        public Form1()
        {
            InitializeComponent();
            Progress.ProgValue += Panel1;
        }
        int a = 0;
        private void Panel1(object sender, int e)
        {
            a = e;
           Mains.Controls.Clear();
           int ww= Mains.Width - Progress.Width;
            int h = (Mains.Height*e)/100;
            int w =(ww*e)/100;
            Label l = new Label()
            {
                Size = new Size(w,h),
                BackColor = Color.Black,
                BorderStyle = BorderStyle.Fixed3D,
            };
            Mains.Controls.Add(l);
            Progress.HeightsShow = h;
            Progress.WidthsShow = w;
        }
        private void Panel1Resize(object sender, EventArgs e)
        {
            Resizes(sender,a);
        }

        private void Resizes(object sender, int e)
        {
            int ww = Mains.Width - Progress.Width;
            int h = (Mains.Height * e) / 100;
            int w = (ww * e) / 100;
            foreach(var Controls in Mains.Controls)
            {
                if(Controls is Label l)
                {
                    l.Size = new Size(w, h);
                }
            }
            Progress.Resizeheight = h;
            Progress.Resizewidth = w;
        }

    }
}
