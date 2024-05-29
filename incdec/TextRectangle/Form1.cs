using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextRectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

      
        private Graphics graphics;
        private int posx, posy,w=40,h=40,i=0;
        private bool isMouse,isEnter;
        private Font font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
        private Timer timer;
        private string s;
        private bool isTimer,isFirst;
        private char[] c;

        private void button1_Click(object sender, EventArgs e)
        {
            KeyPreview = true;

        }

        private void Start(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Stop(object sender, EventArgs e)
        {
            isTimer = false;
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            isTimer = true;
            Invalidate();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsLetter(e.KeyChar))
            {
                s += e.KeyChar;
                isEnter = true;
                if(s!=null)
                {
                    w += 12;
                }
                Invalidate();
            }
            if(e.KeyChar=='\b')
            {
                s=s.Remove(s.Length - 1);
                w -= 12;
                isEnter = true;
                Invalidate();
            }
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;
            if (isMouse || isEnter)
            {
                graphics.DrawString(s,font , Brushes.Red, new Point(posx, posy));
                Rectangle r = new Rectangle(posx - 10, posy - 10, w, h);
                graphics.DrawRectangle(Pens.Red, r);
                isMouse = false;
                isEnter = false;
                if(s!=null) c = s.ToCharArray();

            }
            if(isTimer)
            {  
                if(!isFirst)
                {
                    graphics.Clear(Color.White);
                    s = "";
                    w = 40;
                    h = 40;
                    Rectangle rr = new Rectangle(posx - 10, posy - 10, w, h);
                    graphics.DrawRectangle(Pens.Red, rr);
                    isFirst = true;
                }
                if (i < c.Length)
                {
                    s += c[i];
                    graphics.DrawString(s, font, Brushes.Red, new Point(posx, posy));
                    Rectangle r = new Rectangle(posx - 10, posy - 10, w, h);
                    graphics.DrawRectangle(Pens.Red, r);
                    i++;
                    w += 12;
                }
                if (i >= c.Length) timer.Stop();
            }
        }

      
        private void Form1MouseDown(object sender, MouseEventArgs e)

        {
            posx = e.X;
            posy = e.Y;
            isMouse = true;
            Invalidate();
        }
    }
}
