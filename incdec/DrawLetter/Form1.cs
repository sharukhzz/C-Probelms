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

namespace DrawLetter
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
        private Graphics g;
        private GraphicsPath gp;
        private Point[] point;
        private Timer timer;
        private bool isTimer,isFirst;
        private List<Point[]> li = new List<Point[]>();
        private int i = 0,j=0;

        protected override void OnPaint(PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            if (!isTimer && !isFirst)
            {
                //npoint = new Point[] { new Point(185, 220), new Point(180, 220), new Point(180, 190), new Point(215, 205), new Point(215, 190),new Point(220,190) };
                //t point = new Point[] { new Point(140, 200), new Point(130, 200), new Point(130, 170), new Point(110, 170), new Point(110, 155), new Point(140, 155) };
                //r point = new Point[] { new Point(245, 200), new Point(240, 200), new Point(240, 160), new Point(245, 148),new Point(255,146),new Point(265,146),new Point(275,150),new Point(280,155),new Point(279,172),new Point(268,174),new Point(279,200),new Point(270,200) };
                //p point = new Point[] { new Point(300, 220), new Point(290, 220),new Point(290,160),new Point(300,152),new Point(340,152),new Point(344,159),new Point(344,195),new Point(305,195) };
                //g.DrawLines(Pens.White, point);
                gp = new GraphicsPath();
                point = new Point[] { new Point(150, 200), new Point(130, 200), new Point(130, 140),new Point(180,175),new Point(180,140),new Point(200,140),new Point(200,200),new Point(155,170),new Point(155,200),new Point(153 ,200) };
                gp.AddLines(point);
                g.FillPath(Brushes.White, gp);
                li.Add(point);
                //n point = new Point[] { new Point(180,220),new Point(190, 220), new Point(190, 205), new Point(225, 220), new Point(225, 190), new Point(220, 190) };
                //tpoint = new Point[] { new Point(140, 200), new Point(150, 200), new Point(150, 170), new Point(170, 170), new Point(170, 155),new Point(140,155) };
                //r point = new Point[] { new Point(245, 200), new Point(250, 200),new Point(250,165),new Point(253,162),new Point(255,160),new Point(262,160),new Point(272,162),new Point(272,164),new Point(268,166),new Point(252,168),new Point(264,200),new Point(270,200) };
              //p  point = new Point[] { new Point(300, 220), new Point(306, 220) ,new Point(306,170),new Point(308,167),new Point(330,167),new Point(333,170),new Point(333,185),new Point(305,185)};
               // g.DrawLines(Pens.White, point);
                li.Add(point);
                isFirst = true;
            }
            else if(isTimer)
            {            
                Point[] p1 = li[0] as Point[];
               // Point[] p2 = li[1] as Point[];
                //if(i>=p1.Length-1)
                //{
                //    isFirst = false;
                //    isTimer = false;
                //    Invalidate();
                //    timer.Stop();
                //}
                //if(i<p2.Length-1)
                //{
                //    for(int j=0;j<i;j++)
                //    {
                //        g.DrawLine(Pens.White, p1[j], p1[j + 1]);
                //        g.DrawLine(Pens.White, p2[j], p2[j + 1]);
                //    }
                //    g.DrawLine(Pens.White, p1[i],p1[i+1]);
                //    g.DrawLine(Pens.White, p2[i], p2[i + 1]);
                //    i++;
                //}     
                if(i>=p1.Length/2)
                {
                    isFirst = false;
                    isTimer = false;
                    Invalidate();
                    timer.Stop();
                }
                if(i<p1.Length/2)
                {
                    int k2 = point.Length -1;
                    for (int k = 0; k < i; k++)
                    {
                        g.DrawLine(Pens.White, p1[k], p1[k + 1]);
                        g.DrawLine(Pens.White, p1[k2], p1[k2 - 1]);
                        k2--;
                    }
                    g.DrawLine(Pens.White, p1[i], p1[i + 1]);
                    g.DrawLine(Pens.White, p1[j], p1[j - 1]);
                    i++;
                    j--;
                }
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void TimerClick(object sender, EventArgs e)
        {
            i = 0;
            j = point.Length - 1;
            isTimer = true;
            timer.Start();
        }

        private void StopClick(object sender, EventArgs e)
        {
            timer.Stop();
            Invalidate();
        }
    }
}
