using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coloumn_row
{
    public partial class Form1 : Form
    {
        private List<Label> li = new List<Label>();
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void Buttons(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
            //li.Clear();
            //int r = int.Parse(textBox1.Text);
            //int c = int.Parse(textBox2.Text);
            //int h = panel2.Height / r;
            //int w = panel2.Width / c;
            //int co = 0;
            //for (int i = 0; i < r; i++)
            //{
            //    for (int j = 0; j < c; j++)
            //    {
            //        co++;
            //        //Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            //        Label p = new Label()
            //        {
            //            Size = new Size(w, h),
            //            Location = new Point(j * w, h * i),
            //            BorderStyle = BorderStyle.Fixed3D,
            //            Text = co.ToString(),
            //            // BackColor = randomColor,
            //        };
            //        p.Click += P2Click;
            //        panel2.Controls.Add(p);
            //        li.Add(p);
            //    }
            //}
            panel2.Controls.Clear();
            int rows = int.Parse(textBox1.Text);
            int cols = int.Parse(textBox2.Text);
            int currentTotal = rows * cols;
            int existingTotal = li.Count;
            int diff = existingTotal - currentTotal;
            if (diff > 0)
            {
                while (diff-- > 0)
                {
                    Label label = li[li.Count - 1];
                    label.Click -= P2Click;
                    li.Remove(label);
                }
            }
            else
            {
                while (diff++ < 0)
                {
                    Label label = new Label()
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        Font = new Font(Font.FontFamily, 14),
                    };
                    label.Click += P2Click;
                    li.Add(label);
                }
            }
            int labelWidth = panel2.Width / cols;
            int labelHeight = panel2.Height / rows;
            int i = 0, j = 0, counter = 0;
            foreach (Label label in li)
            {
                label.Location = new Point(j *labelWidth, i *labelHeight);
                label.Size = new Size(labelWidth, labelHeight);
                panel2.Controls.Add(label);
                j++;
                label.Text = (++counter) + "";
                if (j == cols)
                {
                    i++;
                    j = 0;
                }
            }
        }

        private void Panel2Resize1(object sender, EventArgs e)
        {
            int rows = int.Parse(textBox1.Text);
            int columns = int.Parse(textBox2.Text);
            int cellWidth = panel2.Width / columns;
            int cellHeight = panel2.Height / rows;
            int counter = 0;
            foreach (var label in li)
            {
                label.Size = new Size(cellWidth, cellHeight);
                label.Location = new Point((counter) % columns * cellWidth, (counter) / columns * cellHeight);
                counter++;
            }
        }

        private void P2Click(object sender, EventArgs e)
        {
            Label l = sender as Label;
            if (l == null) return;
            foreach(Label ll in li)
            {
                if(ll!=l)
                {
                    ll.BackColor = Color.White;
                }
            }
            l.BackColor = Color.Yellow;
            l.ForeColor = Color.Red;
        }

        private void Button3Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
        }

        private void TextBox1KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\r') e.Handled = true;
        }

        private void TextBox2KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\r') e.Handled = true;
        }
    }
}
