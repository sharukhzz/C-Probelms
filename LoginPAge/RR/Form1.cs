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

namespace RR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            us.Evented += Us_Evented;
        }

        private void Us_Evented(bool f)
        {
            BackColor = Color.Black;
        }

        Userr us = new Userr();
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controls.Add(us);
        }
        Class1 c = new Class1();
        private void button1_Click(object sender, EventArgs e)
        {
            us.BBB = true;
            c.isTrue();
        }
    }
}
