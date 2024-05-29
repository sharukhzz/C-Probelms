using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mousecolour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = PointToClient(Cursor.Position);
            Bitmap b = new Bitmap(Screen.PrimaryScreen.Bounds.Width,Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(b);
            g.CopyFromScreen(p, new Point(0,0), new Size(1, 1),CopyPixelOperation.SourceCopy);
            button2.BackColor = b.GetPixel(0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = button2.BackColor;
        }
    }
}
