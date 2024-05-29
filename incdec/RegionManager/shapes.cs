using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegionManager
{
    public partial class shapes : UserControl
    {
        public shapes()
        {
            InitializeComponent();
        }
        public delegate void Manager(string[] s);
        public event Manager RegionManager;
        public event EventHandler<int> Moves;
        public event EventHandler<int> Moves1;
        private List<string> li = new List<string>();

        private void shapes_Load(object sender, EventArgs e)
        {
            Height = Form1.h;
            Width = Form1.w;
        }

        private void Submitc(object sender, EventArgs e)
        {
            li.Add(textBox1.Text);
            li.Add(textBox2.Text);
            li.Add(textBox3.Text);
            li.Add(textBox4.Text);
            if (radioButton1.Checked) li.Add("Pen");
            if (radioButton2.Checked) li.Add("Brush");
            RegionManager?.Invoke(li.ToArray());
            li.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem== "Rectangle")
            {
                li.Add(comboBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Moves?.Invoke(null, 50);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Moves1?.Invoke(null, 20);
        }
    }
}
