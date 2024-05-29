using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation2Part2
{
    public partial class Calendar : UserControl
    {
        public Calendar()
        {
            InitializeComponent();
        }
        private bool isFirst, isFirst1,isFirst2, isClicked;
        private List<RichTextBox> richTextBoxes = new List<RichTextBox>();

        private void comboBox1_Click(object sender, EventArgs e)
        {
            if (!isFirst)
            {
                comboBox1.Items.Add("1");
                comboBox1.Items.Add("2");
                comboBox1.Items.Add("3");
                comboBox1.Items.Add("4");
                comboBox1.Items.Add("5");
                comboBox1.Items.Add("6");
                comboBox1.Items.Add("7");
                comboBox1.Items.Add("8");
                comboBox1.Items.Add("9");
                comboBox1.Items.Add("10");
                comboBox1.Items.Add("11");
                comboBox1.Items.Add("12");
                isFirst = true;
            }
            
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            if (!isFirst1)
            {
                int year = 2000;
                for (int i = year; i <= 2024; i++)
                {
                    comboBox2.Items.Add(i);
                }
                isFirst1 = true;
            }
          
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            if(!isFirst2)
            {
                richTextBoxes.Add(richTextBox8);
                richTextBoxes.Add(richTextBox9);
                richTextBoxes.Add(richTextBox10);
                richTextBoxes.Add(richTextBox11);
                richTextBoxes.Add(richTextBox12);
                richTextBoxes.Add(richTextBox13);
                richTextBoxes.Add(richTextBox14);
                richTextBoxes.Add(richTextBox15);
                richTextBoxes.Add(richTextBox16);
                richTextBoxes.Add(richTextBox17);
                richTextBoxes.Add(richTextBox18);
                richTextBoxes.Add(richTextBox19);
                richTextBoxes.Add(richTextBox20);
                richTextBoxes.Add(richTextBox21);
                richTextBoxes.Add(richTextBox22);
                richTextBoxes.Add(richTextBox23);
                richTextBoxes.Add(richTextBox24);
                richTextBoxes.Add(richTextBox25);
                richTextBoxes.Add(richTextBox26);
                richTextBoxes.Add(richTextBox27);
                richTextBoxes.Add(richTextBox28);
                richTextBoxes.Add(richTextBox29);
                richTextBoxes.Add(richTextBox30);
                richTextBoxes.Add(richTextBox31);
                richTextBoxes.Add(richTextBox32);
                richTextBoxes.Add(richTextBox33);
                richTextBoxes.Add(richTextBox34);
                richTextBoxes.Add(richTextBox35);
                richTextBoxes.Add(richTextBox36);
                richTextBoxes.Add(richTextBox37);
                richTextBoxes.Add(richTextBox38);
                richTextBoxes.Add(richTextBox39);
                richTextBoxes.Add(richTextBox40);
                richTextBoxes.Add(richTextBox41);
                richTextBoxes.Add(richTextBox42);
                richTextBoxes.Add(richTextBox43);
                richTextBoxes.Add(richTextBox44);
                richTextBoxes.Add(richTextBox45);
                richTextBoxes.Add(richTextBox46);
                richTextBoxes.Add(richTextBox47);
                richTextBoxes.Add(richTextBox48);
                richTextBoxes.Add(richTextBox49);
                isFirst2 = true;
            }
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            SubmitClick(null, EventArgs.Empty);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            SubmitClick(null, EventArgs.Empty);
        }

        private void SubmitClick(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "")
            {
                int n, day = 1, x = 0;
                DateTime datetime = new DateTime(Convert.ToInt32(comboBox2.Text), Convert.ToInt32(comboBox1.Text), 1);
                DayOfWeek s = datetime.DayOfWeek;
                if (richTextBox1.Text == s + "")
                {
                    n = 1 + 7;
                    if (n == 8)
                    {
                        x = 0;
                    }

                }
                if (richTextBox2.Text == s + "")
                {
                    n = 2 + 7;
                    if (n == 9)
                    {
                        x = 1;
                    }
                }
                if (richTextBox3.Text == s + "")
                {
                    n = 3 + 7;
                    if (n == 10)
                    {
                        x = 2;
                    }
                }
                if (richTextBox4.Text == s + "")
                {
                    n = 4 + 7;
                    if (n == 11)
                    {
                        x = 3;
                    }
                }
                if (richTextBox5.Text == s + "")
                {
                    n = 5 + 7;
                    if (n == 12)
                    {
                        x = 4;
                    }
                }
                if (richTextBox6.Text == s + "")
                {
                    n = 6 + 7;
                    if (n == 13)
                    {
                        x = 5;
                    }
                }
                if (richTextBox7.Text == s + "")
                {
                    n = 7 + 7;
                    if (n == 14)
                    {
                        x = 6;
                    }
                }
                int flag = 0;
                if (int.Parse(comboBox2.Text) % 4 == 0)
                {
                    flag = 1;
                }
                int k = 0;
                if (comboBox1.Text == "1" || comboBox1.Text == "3" || comboBox1.Text == "5" || comboBox1.Text == "7" || comboBox1.Text == "12" || comboBox1.Text == "8" || comboBox1.Text == "10")
                {
                    k = 31;
                }
                if (comboBox1.Text == "4" || comboBox1.Text == "6" || comboBox1.Text == "9" || comboBox1.Text == "11")
                {
                    k = 30;
                }
                if (comboBox1.Text == "2" && flag == 1)
                {
                    k = 29;
                }
                if (comboBox1.Text == "2" && flag == 0)
                {
                    k = 28;
                }
                foreach (var nn in richTextBoxes)
                {
                    nn.Text = "";
                    nn.BackColor = richTextBox1.BackColor;
                }
                for (int i = x; i < richTextBoxes.Count; i++)
                {
                    if (day <= k)
                    {
                        richTextBoxes[i].Text = day + "";
                        day++;
                    }
                }
                if (isClicked) button1_Click(sender, EventArgs.Empty);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isClicked = true;
            DateTime today = DateTime.Now;
            int day = today.Day;
            foreach(var days in richTextBoxes)
            {
                if(day+""==days.Text)
                {
                    days.BackColor = Color.Blue;
                }
            }
        }
    }
}
