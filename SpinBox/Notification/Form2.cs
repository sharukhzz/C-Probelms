using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notification
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CloseClick(object sender, EventArgs e)
        {
            this.Close();
            for (int i = 0; i < Form1.li.Count; i++)
            {
                if (Form1.li[i].Location.Y == this.Location.Y)
                {
                    Form1.li.Remove(Form1.li[i]);
                }
            }
        }

        public void TextBox1TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = Form1.s;
            int textHeight = TextRenderer.MeasureText(textBox1.Text, textBox1.Font, new Size(textBox1.Width, 0), TextFormatFlags.WordBreak).Height;
            this.Height = textHeight+20;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
