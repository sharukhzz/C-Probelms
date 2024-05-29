using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapes
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        public List<Panel> li = new List<Panel>();       
        public bool ismouse;
        public Point prev = Point.Empty,mouse;
        public Panel Pan;
        private bool ismove, isrec, iscir, istri;
        public Panel pp;

        private void Panel1MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Pan = new Panel()
            {
                BackgroundImageLayout = ImageLayout.Stretch,
                
            };
            Pan.BringToFront();
            if (isrec)
            {
                Pan.BackgroundImage = Properties.Resources.Rectangle;
            }
            if (iscir)
            {
                Pan.BackgroundImage = Properties.Resources.Circle;
            }
            if (istri)
            {
                Pan.BackgroundImage = Properties.Resources.Tri;
            }

            ismouse = true;
            prev = e.Location;
            pp = null;
            Pan.Location = new Point(e.X, e.Y);
        }
        private void Panel1MouseMove(object sender, MouseEventArgs e)
        {
            if (!ismouse) return;
            Pan.Size = new Size(e.X - prev.X, e.Y - prev.Y);
        }

        private void Panel1MouseUp(object sender, MouseEventArgs e)
        {
            ismouse = false;
            Pan.Size = new Size(e.X - prev.X, e.Y - prev.Y);
            li.Add(Pan);
            Controls.Add(Pan);
            prev = Point.Empty;
          
            Pan.MouseDown += Pan_MouseDown;
            Pan.MouseMove += Pan_MouseMove;
            Pan.MouseUp += Pan_MouseUp;
            Pan.Click += Pan_Click;          
            foreach (var n in li)
            {
                Controls.Add(n);
            }
        }

        private void Pan_MouseUp(object sender, MouseEventArgs e)
        {
            ismove = false;
        }

        private void Pan_MouseMove(object sender, MouseEventArgs e)
        {
            if(ismove)
            {
                Panel pp = sender as Panel;
                pp.Left += e.X - mouse.X;
                pp.Top += e.Y - mouse.Y;
            }
        }

        private void Pan_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouse = e.Location;
                ismove = true;
            }
        }

        private void RecClick(object sender, EventArgs e)
        {
            isrec = true;
            iscir = false;
            istri = false;
            
        }
        private void CirClick(object sender, EventArgs e)
        {
            iscir = true;
            isrec = false;
            istri = false;
           
        }
        private void TriClick(object sender, EventArgs e)
        {
            istri = true;
            isrec = false;
            iscir = false;
            
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            li.Remove(pp);
            Controls.Remove(pp);
        }

        private void Pan_Click(object sender, EventArgs e)
        {
            if (pp != null)
            {
                pp.BorderStyle = BorderStyle.None;
            }
            Panel c = sender as Panel;
            c.BorderStyle = BorderStyle.FixedSingle;
            pp = c;
        }
    }
}
