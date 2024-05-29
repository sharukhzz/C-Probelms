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

namespace Training
{
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectangle = new Rectangle(200, 200, 100, 100);
            //rectangle.Location = new Point(200, 200);
            // graphics.DrawRectangle(Pens.Red, rectangle);
            //graphics.DrawArc(Pens.Black, rectangle, 0, 90);
            //graphics.DrawArc(Pens.Black, rectangle, 90, 90);
            //graphics.DrawArc(Pens.Black, rectangle, 180, 90);
            //graphics.DrawArc(Pens.Black, rectangle, 270, 90);
            // graphics.FillRectangle(Brushes.Red, rectangle);

            #region //AddArcinGraphicsPath
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rectangle, 10, 100);
            graphics.DrawPath(Pens.Black, path);
            #endregion

            #region Polygon points
            // GraphicsPath gp = new GraphicsPath();
            Point[] p = new Point[] { new Point(200, 250), new Point(180, 200), new Point(100, 170), new Point(170, 170),new Point(170,100),new Point(250,180)};
            graphics.FillPolygon(Brushes.Blue, p);
            #endregion

            #region Rounded Border
            //Rectangle Butrect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            //GraphicsPath gp = new GraphicsPath();
            //int r = 20; //roundeness of border
            //gp.AddArc(Butrect.X, Butrect.Y, r * 2, r * 2, 180, 90);
            //gp.AddArc(Butrect.X+Butrect.Width-2*r, Butrect.Y, r * 2, r * 2, 270, 90);
            //gp.AddArc(Butrect.X+Butrect.Width-r*2, Butrect.Y+Butrect.Height-r*2, r * 2, r * 2, 0, 90);
            //gp.AddArc(Butrect.X, Butrect.Y+Butrect.Height-r*2, r * 2, r * 2, 90, 90);
            //gp.CloseAllFigures();
            //graphics.DrawPath(Pens.Red, gp);

            Rectangle buttonRect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            GraphicsPath gp = new GraphicsPath();
            int radius = 20; // Radius for roundness

            // Top-left arc
            gp.AddArc(buttonRect.X, buttonRect.Y, 2 * radius, 2 * radius, 180, 90);

            // Top-right arc
            gp.AddArc(buttonRect.Right - 2 * radius, buttonRect.Y, 2 * radius, 2 * radius, 270, 90);

            // Bottom-right arc
            gp.AddArc(buttonRect.Right - 2 * radius, buttonRect.Bottom - 2 * radius, 2 * radius, 2 * radius, 0, 90);

            // Bottom-left arc
            gp.AddArc(buttonRect.X, buttonRect.Bottom - 2 * radius, 2 * radius, 2 * radius, 90, 90);

            gp.CloseFigure();

            graphics.DrawPath(new Pen(Color.Red, 2), gp);
            #endregion
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Invalidate();
        }
    }
}
