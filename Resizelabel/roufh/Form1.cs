using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roufh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            public Label l = new Label
            {
                BackColor = Color.Yellow,
                ForeColor = Color.Red,
                BorderStyle = BorderStyle.Fixed3D,
            };
        private bool ismouse;
        private Point prev ;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            ismouse = false;
            l.Size = new Size(e.X - prev.X, e.Y - prev.Y);
            panel1.Controls.Add(l);
            prev = Point.Empty;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!ismouse) return;
           l.Size = new Size(e.X - prev.X, e.Y - prev.Y);
            panel1.Controls.Add(l);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ismouse = true;
            prev = e.Location;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
