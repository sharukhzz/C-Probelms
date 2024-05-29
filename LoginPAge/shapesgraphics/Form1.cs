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

namespace shapesgraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.BackgroundImage = Resource1.playy;
            button3.BackgroundImage = Resource1.pause;
            button4.BackgroundImage = Resource1.Record;
            time = new Timer();
            time.Interval = 1000;
            time.Tick += Time_Tick;
        }

        private string shape = "";
        private int startx = 0, starty = 0, endx = 0, endy = 0, t = 0, h = 0, w = 0, ind = 0, n = 0,value=0,sp=0;
        private bool isDraw,isRec, isTrue = true, isRect, isCirc, isTri, isStart,isMouse,isProg,isValue;
        private Graphics g;
        private Rectangle r,c; 
        private Point[] tr;
        private Pen p = new Pen(Color.Black, 3);
        private List<Interface> li = new List<Interface>();
        private Rectangles rr;
        private Circles cc;
        private Triangles trr;
        private Timer time;

        private void Panel1Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            for (int i = 0; i < ind && li.Count > 0; i++)
            {
                Rectangles rr= li[i] as Rectangles;
                Circles cc = li[i] as Circles;
                Triangles trr = li[i] as Triangles;
                if (rr != null)
                {
                    r = new Rectangle(rr.Startx, rr.Starty, rr.Endx - rr.Startx, rr.Endy - rr.Starty);
                    g.DrawRectangle(p, r);
                }
                if (cc != null)
                {
                    c = new Rectangle(cc.Startx, cc.Starty, cc.Endx - cc.Startx, cc.Endy - cc.Starty);
                    g.DrawEllipse(p, c);
                }
                if (trr != null)
                {
                    tr = new Point[] {new Point(trr.Startx+(trr.Endx-trr.Startx)/2,trr.Starty),
                    new Point(trr.Startx,trr.Endy),new Point(trr.Endx,trr.Endy)};
                    g.DrawPolygon(p, tr);
                }
            }
            if (n==0)
            {
                if(shape== "Rectangle")
                {
                    r = new Rectangle(startx, starty, endx-startx, endy-starty);
                    g.DrawRectangle(p, r);
      
                }
                if(shape== "Circle")
                {
                    c = new Rectangle(startx, starty, endx - startx, endy - starty);
                    g.DrawEllipse(p, c);
                }
                if(shape== "Triangle")
                {
                    tr = new Point[] { new Point(startx+(endx-startx)/2,starty),
                    new Point(startx,endy),new Point(endx,endy)};
                    g.DrawPolygon(p, tr);
                }
            }
            if (!isValue)
            {
                if (isRect)
                {
                    double k = 100 / li.Count();
                    int max = Math.Max((rr.Endy - rr.Starty), (rr.Endx - rr.Startx));
                    double ans = max / k;
                    if (h < (rr.Endy-rr.Starty)) h += 1;
                    if (w < (rr.Endx-rr.Startx)) w += 1;
                    if (h < (rr.Endy-rr.Starty )|| w < (rr.Endx-rr.Startx))
                    {
                        r = new Rectangle(rr.Startx, rr.Starty, w, h);
                        g.DrawRectangle(p, r);
                        if ( w % ans <= 1 && progressBar.Value<=99)
                        {
                            progressBar.Value += 1;
                        }
                    }
                    else
                    {
                        time.Stop();
                        h = 0;
                        w = 0;
                        r = new Rectangle(rr.Startx, rr.Starty, rr.Endx - rr.Startx, rr.Endy - rr.Starty);
                        g.DrawRectangle(p, r);
                        if (ind != li.Count - 1)
                        {
                            ind++;
                            StartClick(null, EventArgs.Empty);
                        }
                    }
                }
                if (isCirc)
                {
                    double k = 100 / li.Count();
                    int max = Math.Max((cc.Endy - cc.Starty), (cc.Endx - cc.Startx));
                    double ans = max / k;
                    if (h < (cc.Endy - cc.Starty)) h += 1;
                    if (w < (cc.Endx - cc.Startx)) w += 1;
                    if (h < (cc.Endy - cc.Starty) || w < (cc.Endx - cc.Startx))
                    {
                        r = new Rectangle(cc.Startx, cc.Starty, w, h);
                        g.DrawEllipse(p, r);
                        if (w % ans <= 1 && progressBar.Value <= 99)
                        {
                            progressBar.Value += 1;
                        }
                    }
                    else
                    {
                        g.DrawEllipse(p, c);
                        time.Stop();
                        h = 0;
                        w = 0;
                        c = new Rectangle(cc.Startx, cc.Starty, cc.Endx - cc.Startx, cc.Endy - cc.Starty);
                        g.DrawEllipse(p, c);
                        if (ind != li.Count - 1)
                        {
                            ind++;
                            StartClick(null, EventArgs.Empty);
                        }
                    }
                }
                if (isTri)
                {
                    double k = 100 / li.Count();
                    int max = Math.Max((trr.Endy - trr.Starty), (trr.Endx - trr.Startx));
                    double ans = max / k;
                    if (h < (trr.Endy - trr.Starty)) h += 1;
                    if (w < (trr.Endx - trr.Startx)) w += 1;
                    if (h < (trr.Endy - trr.Starty) || w < (trr.Endx - trr.Startx))
                    {
                        tr = new Point[] { new Point(trr.Startx+(w-trr.Startx)/2,trr.Starty),
                        new Point(trr.Startx,h),new Point(w,h)};
                        g.DrawPolygon(p, tr);
                        if (w % ans <= 1 && progressBar.Value <= 99)
                        {
                            progressBar.Value += 1;
                        }
                    }
                    else
                    {
                        g.DrawPolygon(p, tr);
                        time.Stop();
                        h = 0;
                        w = 0;
                        tr = new Point[] {new Point(trr.Startx+(trr.Endx-trr.Startx)/2,trr.Starty),
                        new Point(trr.Startx,trr.Endy),new Point(trr.Endx,trr.Endy)};
                        g.DrawPolygon(p, tr);
                        if (ind != li.Count - 1)
                        {
                            ind++;
                            StartClick(null, EventArgs.Empty);
                        }
                    }
                }
            }
            if(isValue)
            {
                int ans = 100 / li.Count;
                int k = ans,x=0;
                while(ans<value)
                {
                    if(isRect)
                    {
                        Rectangles rrr = li[x] as Rectangles;
                        r = new Rectangle(rrr.Startx, rrr.Starty, rrr.Endx - rrr.Startx, rrr.Endy - rrr.Starty);
                        g.DrawRectangle(p, r);
                        x++;
                    }
                    ans += k;
                }
            }
        }

        private void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            shape = comboBox1.Text;
        }

        private void ProgressBar(object sender, EventArgs e)
        {
            value = progressBar.Value;

        }

        private void RecordClick(object sender, EventArgs e)
        {
            if (!isRec)
            {
                button2.Visible = false;
                button3.Visible = false;
                label2.Visible = false;
                comboBox2.Visible = false;
                button1.Visible = true;
                label1.Visible = true;
                comboBox1.Visible = true;
                progressBar.Visible = false;
                isRec = true;
            }
            else
            {
                button2.Visible = true;
                button3.Visible = true;
                label2.Visible = true;
                progressBar.Visible = true;
                comboBox2.Visible = true;
                button1.Visible = false;
                label1.Visible = false;
                comboBox1.Visible = false;
                isRec = false;
            }
        }

        private void StopClick(object sender, EventArgs e)
        {
            time.Stop();
        }

        private void DrawClick(object sender, EventArgs e)
        {
            n = 0;
            isTrue = true;
            if (!isDraw)
            {
                comboBox1.Items.Add("Rectangle");
                comboBox1.Items.Add("Circle");
                comboBox1.Items.Add("Triangle");
                comboBox2.Items.Add(200);
                comboBox2.Items.Add(100);
                isDraw = true;
            }
        }

        private void Panel1MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
            startx = e.X;
            starty = e.Y;
        }

        private void TimerClick(object sender, EventArgs e)
        {
            t = Convert.ToInt32(comboBox2.Text);           
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }


        private void StartClick(object sender, EventArgs e)
        {
            if(!isStart)
            {
                ind = 0;
            }
            isStart = true;
            n = 1;
            li.Count();      
            rr=li[ind] as Rectangles;
            cc = li[ind] as Circles;
            trr = li[ind] as Triangles;
            if(rr!=null)
            {
                isRect = true;
                isCirc = false;
                isTri = false;
            }
            if(cc!=null)
            {
                isRect = false;
                isCirc = true;
                isTri = false;
            }
            if(trr!=null)
            {
                isRect = false;
                isCirc = false;
                isTri = true;
            }
            time.Start();
        }

        private void Panel1MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouse)
            {
                endx = e.X;
                endy = e.Y;
                panel1.Invalidate();
            }
        }

        private void Panel1MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            if (shape == "Rectangle" && isTrue)
            {
                rr = new Rectangles
                {
                    Startx = startx,
                    Starty = starty,
                    Endx = endx,
                    Endy = endy,
                };
                li.Add(rr);
            }
            if (shape == "Circle" && isTrue)
            {
                cc = new Circles
                {
                    Startx = startx,
                    Starty = starty,
                    Endx = endx,
                    Endy = endy,
                };
                li.Add(cc);
            }
            if (shape == "Triangle" && isTrue)
            {
                trr = new Triangles
                {
                    Startx = startx,
                    Starty = starty,
                    Endx = endx,
                    Endy = endy,
                };
                li.Add(trr);
            }
            ind++;
        }

        private void Panel1MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right && !isMouse)
            {
                isTrue = true;               
            }
        }
        private void ProgressBarMouseDown(object sender, MouseEventArgs e)
        {
            isProg = true;
        }

        private void ProgressBar1MouseMove(object sender, MouseEventArgs e)
        {
            if (!isProg) return;
            if (value == 100)
            {
                value -= 1;
            }
            if(value==0)
            {
                value += 1;
            }
            if (e.X < sp)
            {
                if (value < 100 && value > 0)
                {
                    value -= 1;
                }
            }
            else
            {
                if (value < 100 && value >= 0)
                {
                    value += 1;
                }
            }
            progressBar.Value = value;
            sp = e.X;
        }

        private void ProgressBarMouseUp(object sender, MouseEventArgs e)
        {
            isProg = false;
            isValue = true;
            StartClick(null,EventArgs.Empty);
        }
    }
}
