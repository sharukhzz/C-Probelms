using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingNew
{
    public partial class ProgesstimeForm : Form
    {
        public ProgesstimeForm()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
        }
        private Form2 obj;
        private Timer timer;
        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            obj = new Form2();
           // obj.Show();
            obj.ShowDialog();
        }

        private void ProgesstimeForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
