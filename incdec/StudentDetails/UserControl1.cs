using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDetails
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public event DataSaved Data;
        private TextBox textBoxs;
        private Label label;
        private List<string> li2 = new List<string>();
        private string i;
        public List<string> li = new List<string>();
        private int x = 0, y = 0;
        private List<TextBox> textBox = new List<TextBox>();
        private List<Label> ll = new List<Label>();
        public static List<string[]> Lists = new List<string[]>();

        public void Senduc(int r)
        {
            for (int i = 0; i < Lists.Count; i++)
            {
                if (r == i)
                {
                    List<string> s = Lists[i].ToList();
                    string ss = s[0];
                    pictureBox1.Image = new Bitmap(ss);
                    textBox1.Text = s[1];
                    textBox2.Text = s[2];
                    textBox3.Text = s[3];
                    textBox4.Text = s[4];
                    if (s.Count > 5)
                    {
                        int t = 5;
                        foreach (var n in textBox)
                        {
                            n.Text = s[t];
                            t++;
                        }
                    }
                }
            }
        }
        public void Del(int r)
        {
            List<string> s = Lists[r].ToList();
            Lists.RemoveAt(r);
            Lists.Insert(r, s.ToArray());
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            if(Form1.isIs)
            {
                textBoxs = textBox4;
                label = label5;
                Form1.isIs = false;
            }
            if (Form1.isAdd && x < Form1.list.Count)
            {
                    li.Clear();
                    li2.Clear();
                    TextBox t = new TextBox()
                    {
                        Location = new Point(textBoxs.Location.X, textBoxs.Location.Y + 40),
                        Size = textBoxs.Size,
                        Font = textBoxs.Font,
                    };
                    Controls.Add(t);
                    textBox.Add(t);
                    textBoxs = textBox[y];
                    Label l = new Label()
                    {
                        Location = new Point(label.Location.X, label.Location.Y + 40),
                        Size = label.Size,
                        Font = label.Font,
                        Text = Form1.list[x],
                    };
                    Controls.Add(l);
                    ll.Add(l);
                    label = l;
                    x++;
                    y++;
                    button1.Location = new Point(button1.Location.X, button1.Location.Y + 30);
                    UserControl1_Load(null, EventArgs.Empty);
            }
        }

            private void PictureBoxClick(object sender, EventArgs e)
            {
                using (OpenFileDialog open = new OpenFileDialog())
                {
                    open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        i = open.FileName;
                        pictureBox1.Image = new Bitmap(open.FileName);
                    }
                }
            }
        private void PhnoKeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SubmitClick(object sender, EventArgs e)
        {
            textBox4.Text +=  "@gmail.com";
            y = 0;
            if (i == null) i = "s";
            li.Add(i.ToString());
            li.Add(textBox1.Text);
            li.Add(textBox2.Text);
            li.Add(textBox3.Text);
            li.Add(textBox4.Text);
            if (li2.Count >= 0 && Form1.isAdd)
            {
                li2.Clear();
                if(textBox!=null)
                { 
                foreach (var l in textBox)
                {
                    if (Form1.coloumnindex >= 5)
                    {
                        li2.Add(l.Text);
                    }
                    else
                    {
                        li2.Add(l.Text);
                    }
                }
                foreach (var n in li2)
                {
                    li.Add(n);
                }
                }
            }
            Lists.Add(li.ToArray());
            Data?.Invoke(li.ToArray());
            y = 0;
            li.Clear();
            pictureBox1.Image = null;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            foreach(var n in textBox)
            {
                n.Text = null;
            }
            
        }
    }
}
