using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TrainingNew
{
    public partial class ToolTipForm : Form
    {
        public ToolTipForm()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "button");
        }
        private int sx, sy;
        private Graphics graphics;
        private bool isDraw,isResize;
        private void button2_MouseHover(object sender, EventArgs e)
        {
            Point cursor = this.PointToClient(Cursor.Position);
            sx=cursor.X+button2.Width/2;
            sy=cursor.Y+button2.Height/2;
            isDraw = true;
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (!isDraw) return;
            graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
           
            string s = "This is custom tool tip";
            SizeF textpoint = graphics.MeasureString(s,this.Font);

            Rectangle r = new Rectangle(sx, sy, Convert.ToInt32(textpoint.Width)+10, Convert.ToInt32(textpoint.Height)+10);
            Rectangle but = new Rectangle(button2.Left, button2.Top, button2.Width, button2.Height);
            while (!isResize)
            {
                if (r.IntersectsWith(button2.Bounds))
                {
                    sx = button2.Right + 10;
                    sy = button2.Bottom + 10;
                    r.X = sx;
                    r.Y = sy;
                }
                else
                {
                    isResize = true;
                }
            }


            graphics.DrawRectangle(Pens.Red, r);

            graphics.DrawString(s, Font, Brushes.Black,sx+5,sy+5);
            isResize = false;
        }
    }
}
