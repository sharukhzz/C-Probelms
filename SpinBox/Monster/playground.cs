using Monster.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monster
{
    public partial class playground : Form
    {
        public playground()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1500;
            timer.Tick += Timer_Tick;
            timer.Start();
            DoubleBuffered = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            k.Location = new Point(random.Next(0, Width - k.Width), random.Next(0, Height - k.Height));
            if(!k.Bounds.IntersectsWith(picture.Bounds))
            {
                Controls.Add(k);
            }

        }
        private killing k = new killing();
        private Form Form = new Form();
        private PictureBox picture = new PictureBox();
        private Timer timer;
        private int count;

        public void Pic(PictureBox p)
        {
            picture = p;
            picture.Size=new Size(k.Width,k.Height);
            picture.Location = new Point(0, 0);
        }

        private void playground_Load(object sender, EventArgs e)
        {
            count = Count.count;
            Controls.Add(picture);
            label1.Text =count.ToString();
            timer.Start();
        }

        private void playground_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && picture.Location.X-10>=0)
            {
                picture.Location = new Point(picture.Location.X - 10, picture.Location.Y);
            }
            if (e.KeyCode == Keys.W && picture.Location.Y-10>=0)
            {
                picture.Location = new Point(picture.Location.X, picture.Location.Y - 10);
            }
            if (e.KeyCode == Keys.D && picture.Location.X+picture.Width+10<=Width)
            {
                picture.Location = new Point(picture.Location.X + 10, picture.Location.Y);
            }
            if (e.KeyCode == Keys.S && picture.Location.Y+picture.Height+10<=Height)
            {
                picture.Location = new Point(picture.Location.X, picture.Location.Y + 10);
            }
            if(picture.Bounds.IntersectsWith(k.Bounds))
            {
                count--;
                label1.Text = count.ToString();
                Timer_Tick(null, EventArgs.Empty);
            }
            if(count==0)
            {
                timer.Stop();
                Score score = new Score();
                this.Hide();
                score.Show();
            }
        }
        
    }
}
