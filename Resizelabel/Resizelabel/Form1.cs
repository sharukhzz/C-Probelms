using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resizelabel
{
    public partial class Form1 : Form
    {
        List<Label> Li = new List<Label>();
        public Form1()
        {
            InitializeComponent();
        }
        int ph = 0;
        int pw = 0;
        int max = 0;
        int count = 0;
      
        private void Button1Click(object sender, EventArgs e)
        {
            
            int maxHeight = panel1.Height;
            
                int p1w = panel1.Width - panel2.Width;
                int h = Convert.ToInt32(richTextBox1.Text);
                int w = Convert.ToInt32(richTextBox2.Text);
            if (ph +h < maxHeight)
            {
                Label l = new Label()
                {
                    Size = new Size(w, h),
                    BorderStyle = BorderStyle.Fixed3D,
                    BackColor = Color.Yellow,
                    Location = new Point(pw, ph),
                    Text = count++.ToString(),
                    ForeColor = Color.Black,
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                panel1.Controls.Add(l);
                Li.Add(l);
                pw += l.Width;
                if (max < l.Height)
                {
                    max = l.Height;
                }
                if (pw + l.Width > p1w)
                {
                    pw = 0;
                    ph += max;
                    max = 0;
                }
            }
        }
        int m = 0;
        private void Panel1Resize(object sender, EventArgs e)
        {
            int ch = 0;
            int cw = 0;
            int pww = panel1.Width - panel2.Width;
            foreach (var control in panel1.Controls)
            {
                if (control is Label l)
                {
                    l.Location = new Point(cw, ch);
                    cw += l.Width;
                    if (m < l.Height)
                    {
                        m = l.Height;
                    }
                    if (cw + l.Width > pww)
                    {
                        cw = 0;
                        ch += m;
                        m = 0;
                        //pw = l.Location.X + pw;
                        ph = ch;
                    }
                }
            }
            pw = panel1.Controls.OfType<Label>().Last().Location.X + panel1.Controls.OfType<Label>().Last().Width;
            ph = panel1.Controls.OfType<Label>().Last().Location.Y;
        }
    }
}
