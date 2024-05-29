using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tictactoe.Properties;

namespace tictactoe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private bool iswin;
        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.n % 2 == 0)
            {
                label1.Text = "User 1 Wins";
                iswin = true;
            }
            else
            {
                label1.Text = "User 2 Wins";
            }
            if (iswin)
            {
                pictureBox1.Image = Resources.playing_ezgif_com_webp_to_gif_converter;
                pictureBox2.Image = Resources.waitingg;
            }
            else
            {
                pictureBox1.Image = Resources.waitingg;
                pictureBox2.Image = Resources.playing_ezgif_com_webp_to_gif_converter;
            }
        }
    }
}
