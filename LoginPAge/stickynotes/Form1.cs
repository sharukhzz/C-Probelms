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

namespace stickynotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private InsideF inside = new InsideF();
        private Font fonts;

        private void UserControl_Texts1(string s, Font font)
        {
            fonts = font;
            inside.CurrentString = s;
        }

        private void UserControl_Open(object sender, EventArgs e)
        {
           // Form2 form2 = new Form2();
            UserControl1 uc = new UserControl1();
            //form2.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            // form2.Location = new Point(uc.Location.X + uc.Width+Location.X+Width, this.Location.Y);
            //form2.Show();
        }

        private void UserControl_Exits(bool exit)
        {
            //if(exit) form2.Close();
        }

        private void AddClick(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            UserControl1 UserControl = new UserControl1();
            form2.Controls.Add(UserControl);
            UserControl.Dock = DockStyle.Fill;
            Random r = new Random();
            Screen screen = Screen.PrimaryScreen;
            Rectangle bound = screen.Bounds;
            form2.Location = new Point(r.Next(0, bound.Width), r.Next(0, bound.Height));
            form2.Show();
            Controls.Add(inside);
            inside.Width = Width;
            inside.Height = 25;
            inside.Location = new Point(0, button1.Height);
            inside.BackColor = Color.Red;
            UserControl.Exits += UserControl_Exits;
            UserControl.Open += UserControl_Open;
            UserControl.Texts += UserControl_Texts1;
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
