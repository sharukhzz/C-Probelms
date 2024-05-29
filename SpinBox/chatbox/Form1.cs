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

namespace chatbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        private Graphics graphics;
        private static  int x, y,width,height,h,w,hh;
        private bool isDraw,isFirst;
        private Rectangle rectangle;
        private List<Rectangle> rectangles = new List<Rectangle>();
        private List<string> textBoxes = new List<string>();
        private List<Point> points = new List<Point>();
        private Dictionary<string, string> dictionaries = new Dictionary<string, string>();
        private string s;
        private bool isDict;

        private void EnterMouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            isDraw = true;
            Invalidate();
        }

        private void Form1Load(object sender, EventArgs e)
        {
           
            if(!isFirst)
            {
                y = panel1.Height + 10;
                dictionaries.Add("Hi", "How can i help you");
                dictionaries.Add("What is your name", "I am chitti 2.0");
                isFirst = true;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            if (isDraw)
            {
                x = Width - 20 - TextRenderer.MeasureText(textBox1.Text, textBox1.Font, new Size(0, Height)).Width;
                width = TextRenderer.MeasureText(textBox1.Text, textBox1.Font, new Size(0, Height)).Width;
                w = width;
                height = TextRenderer.MeasureText(textBox1.Text, textBox1.Font, new Size(Width, 0)).Height;
                hh = height;
                if (width > Width)
                {
                   height += height;
                }
                s = "";
                if (width > Width)
                {

                    foreach (var text in textBox1.Text)
                    {
                        width = TextRenderer.MeasureText(s, textBox1.Font, new Size(0, Height)).Width;
                        if (width > Width)
                        {
                            s = "";
                            h += hh;
                        }
                        else
                        {
                            s += text;
                        }
                    }
                    if (x < 0) x = 0;
                    rectangle = new Rectangle(x, y, w, h + hh);
                    graphics.FillRectangle(Brushes.Blue, rectangle);
                    s = "";
                    width = w;
                    height += height;
                    for (int i = 0; i < textBox1.Text.Length; i++)
                    {
                        if (i == textBox1.Text.Length - 1)
                        {
                            graphics.DrawString(s, textBox1.Font, Brushes.White, new Point(x, y));
                        }
                        width = TextRenderer.MeasureText(s, textBox1.Font, new Size(0, Height)).Width;
                        if (width > Width)
                        {
                            graphics.DrawString(s, textBox1.Font, Brushes.White, new Point(x, y));
                            s = "";
                            y += 30;
                        }
                        else
                        {
                            s += textBox1.Text[i];
                        }
                    }
                }
                else if (width < Width)
                {
                    rectangle = new Rectangle(x, y, width, height);
                    graphics.FillRectangle(Brushes.Blue, rectangle);
                    graphics.DrawString(textBox1.Text, textBox1.Font, Brushes.White, new Point(x, y));
                }
                rectangles.Add(rectangle);
                textBoxes.Add(textBox1.Text);
                points.Add(new Point(x, y));
                y += hh + 10;
                x = 0;
                foreach (var di in dictionaries)
                {
                    if (di.Key == textBox1.Text)
                    {
                        textBox1.Text = di.Value;
                        isDict = true;
                    }
                }
                if(!isDict)
                {
                    textBox1.Text = "No results Found";
                }
                width = TextRenderer.MeasureText(textBox1.Text, textBox1.Font, new Size(0, Height)).Width;
                height = TextRenderer.MeasureText(textBox1.Text, textBox1.Font, new Size(Width, 0)).Height;

                 rectangle = new Rectangle(x, y, width, height);

                GraphicsPath gp = new GraphicsPath();
                int radius = 10; // Adjust the radius to control the roundness of the corners
                gp.AddArc(x, y, radius * 2, radius * 2, 180, 90);
                gp.AddArc(x + width - radius * 2, y, radius * 2, radius * 2, 270, 90);
                gp.AddArc(x + width - radius * 2, y + height - radius * 2, radius * 2, radius * 2, 0, 90);
                gp.AddArc(x, y + height - radius * 2, radius * 2, radius * 2, 90, 90);
                gp.CloseFigure();

                graphics.FillPath(Brushes.Red, gp);

                //rectangle = new Rectangle(x, y, width, height);
                //GraphicsPath gp = new GraphicsPath();
                //gp.StartFigure();
                //gp.AddArc(rectangle, 180, 90);
                //gp.AddArc(rectangle, 270, 90);
                //gp.AddArc(rectangle, 0, 90);
                //gp.AddArc(rectangle, 90, 90);
                //gp.CloseFigure();
                //graphics.FillPath(Brushes.Red, gp);
                //  graphics.FillRectangle(Brushes.White, rectangle);
                graphics.DrawString(textBox1.Text, textBox1.Font, Brushes.Black, new Point(x, y));
                rectangles.Add(rectangle);
                textBoxes.Add(textBox1.Text);
                points.Add(new Point(x, y));
                //for (int i = 0; i < rectangles.Count; i++)
                //{
                //    graphics.FillRectangle(Brushes.Blue, rectangles[i]);
                //    graphics.DrawString(textBoxes[i], textBox1.Font, Brushes.White, points[i]);
                //}
                y += height ;
                isDraw = false;
                textBox1.Text = "";
                isDict = false;
            }
        
        }
    }
}
