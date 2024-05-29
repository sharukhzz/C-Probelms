using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using tictactoe.Properties;


namespace tictactoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isuser1;
        public static int n = 2;
        private Form2 obj = new Form2();
        private void ButtonClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if(n%2==0)
            {
                b.Text = "X";
                label3.Text = "playing";
                label4.Text = "....";
                pictureBox2.Image = Resources.playing_ezgif_com_webp_to_gif_converter;
                pictureBox1.Image = Resources.waitingg;
            }
            else
            {
                b.Text = "O";
                label4.Text = "playing";
                label3.Text = "....";
                pictureBox2.Image = Resources.waitingg;
                pictureBox1.Image = Resources.playing_ezgif_com_webp_to_gif_converter;
            }
            b.Enabled = false;
            
            if((button1.Text==button2.Text && button2.Text==button3.Text && button1.Enabled==false) || (button1.Text == button4.Text && button4.Text == button7.Text && button1.Enabled==false)
                || (button1.Text == button5.Text && button5.Text == button9.Text && button1.Enabled==false) || (button4.Text == button5.Text && button5.Text == button6.Text && button4.Enabled==false)
                || (button7.Text == button8.Text && button8.Text == button9.Text && button7.Enabled==false) || (button2.Text == button5.Text && button5.Text == button8.Text && button2.Enabled==false)
                || (button3.Text == button6.Text && button6.Text == button9.Text && button3.Enabled==false) || (button3.Text == button5.Text && button5.Text == button7.Text && button3.Enabled==false))
                {
                    if (n % 2 == 0) isuser1 = true;
                    if (isuser1)
                    {
                        label5.Text = "Win";
                        label6.Text = "Lose";
                        MessageBox.Show("User1 wins");
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        label6.Text = "Win";
                        label5.Text = "Lose";
                        MessageBox.Show("User2 wins");
                        obj.Show();
                        this.Hide();
                    }

                }
            if (n == 10)
            {
                MessageBox.Show("Match Draw");
            }
            n++;
        }

    }
}
