using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Button b;
        private int fh=0,fw=0,x=0,y=0,sx=0,sy=0,num=0,ex=0,ey=0;
        private List<Button> li = new List<Button>();
        private bool isMove;

        private void Button1Click(object sender, EventArgs e)
        {
            num++;
            fh = panel1.Height;
            fw = panel1.Width - panel2.Width;
            b = new Button
            {
                BackColor=Color.Red,
                Size=new Size(50,50),
            };
            b.Location = new Point(x, y);
            b.Text = num.ToString();
            x = x + 100;
            if (x+100>fw)
            {
                x = 0;
                y = y + 100;
            }
            b.MouseDown += B_MouseDown;
            b.MouseMove += B_MouseMove;
            b.MouseUp += B_MouseUp;
            li.Add(b);
            panel1.Controls.Add(b);                        
        }

        private void B_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
            Button B = sender as Button;        
            for (int i = 0; i < li.Count; i++)
            {
                B.Location = new Point(B.Left + (ex - sx), B.Top + (ey - sy));
                if (li[i].Location == B.Location)
                {
                    B.Location = new Point(Math.Abs(B.Left+ (ex - sx)+100), Math.Abs(B.Top+ (ey - sy) + 100));
                }
            }
        }

        private void B_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMove) return;
            ex = e.X;
            ey = e.Y;
        }

        private void B_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            sx = e.X;
            sy = e.Y;
        }
    }
}
