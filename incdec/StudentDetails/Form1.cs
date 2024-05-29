using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDetails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            form2.Datas += Form2_Datas;
            panel2.Hide();
           
        }
        public static string Text1, cellvalue;
        private UserControl1 uc = new UserControl1();
        public Form2 form2;
        public static  bool isAdd,isVis,isIs,isVar, isTrue,isAd,isFis;
        public static List<string> list=new List<string>();
        private List<Form> Li = new List<Form>();
        private List<Button> buttons = new List<Button>();
        private int y = 0,x=0, rowindex,count=0,index=0,tot=0,res=0;
        public delegate void Evts(int r, Form2 form);
        private Color c = Color.Blue;
        public static int coloumnindex;

        private void Form2_Datas(string[] details)
        {
            if (index <= 10)
            {
                if (index > 0 && count < int.Parse(textBox2.Text) - 1)
                {
                    isFis = true;
                    ForwardClick(null, EventArgs.Empty);
                    y++;
                    isAd = true;
                    View(tot);
                    y--;
                }
                if (dataGridView1.RowCount >= 1 && isVis)
                {
                    dataGridView1.Rows.RemoveAt(rowindex);
                    dataGridView1.Rows.Insert(rowindex, details);
                    count++;
                }
                else if (count < int.Parse(textBox2.Text))
                {
                    dataGridView1.Rows.Add(details);
                    count++;
                    isAd = false;
                }
                if (count == int.Parse(textBox2.Text))
                {
                    tot += int.Parse(textBox2.Text);
                    View(tot);
                    count = 0;
                    index++;
                    isAd = false;
                }
            }
            else
            {
                MessageBox.Show("the value cannot be added the list is full");
            }
        }

        public void View(int tot)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i < tot && i >= res)
                {
                    dataGridView1.Rows[i].Visible = true;
                }
                else
                {
                    dataGridView1.Rows[i].Visible = false;
                }
            }
            if(!isAd) res += int.Parse(textBox2.Text);
        }

        public void RowClick(object sender, EventArgs e)
        {
            if (!isVar)
            {
                isIs = true;
                isVar = true;
            }
            else
            {
                isIs = false;
            }
            isVis = false;
            form2.ShowDialog();
        }

        private void ColClick(object sender, EventArgs e)
        {
            isVis = false;
            panel2.Show();
            isAdd = true;
        }

        private void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectionMode == DataGridViewSelectionMode.FullRowSelect)
            {
                DataGridViewCell d = dataGridView1.Rows[e.RowIndex].Cells[0];
                string s = d.Value.ToString();
                pictureBox1.Image = new Bitmap(s);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ColsubmitClick(object sender, EventArgs e)
        {
            panel2.Hide();
            list.Add(textBox1.Text);
            dataGridView1.Columns.Add(textBox1.Text, textBox1.Text);
            textBox1.Text = "";
        }
        private void DataGridView1CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            isVis = true;
            rowindex = e.RowIndex;
            form2.Sendd(rowindex);
            form2.ShowDialog();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.BackColor = c;
            button7.Text = "2";
            buttons.Add(button7);
            button8.Text = "3";
            buttons.Add(button8);
            button9.Text = "4";
            buttons.Add(button9);
            button10.Text = "5";
            buttons.Add(button10);
            button11.Text = ".";
            buttons.Add(button11);
        }

        private void ForwardClick(object sender, EventArgs e)
        {
           if(y<=0)
            {
                y = 0;
            }
           
            foreach (var n in buttons)
            {
                if (n.BackColor != c)
                {
                    x++;
                }
                else if (n.BackColor == c && y < 3 )
                {
                    n.BackColor = buttons[y].BackColor;
                    buttons[y].BackColor = c;
                }
            }
            if(y==0)
            {
                button6.BackColor = button11.BackColor;
                button7.BackColor = c;
            }
            if (y == 1)
            {
                button7.BackColor = button11.BackColor;
                button8.BackColor = c;
            }
            if(y==2)
            {
                button8.BackColor = button11.BackColor;
                button9.BackColor = c;
            }
            if (y==3)
                {
                    button7.Text = ".";
                    button8.Text = "4";
                    button8.BackColor = button7.BackColor;
                    button9.Text = "5";
                    button9.BackColor = c;
                    button10.Text = "6";
                    button11.Text = ".";
                }
                if(y==4)
                {
                    button8.Text = "5";
                    button9.Text = "6";
                    button10.Text = "7";
                }
                if(y==5)
                {
                    button8.Text = "6";
                    button9.Text = "7";
                    button10.Text = "8";
                    button11.Text = "9";
                }
                if(y==6)
                {
                    button10.BackColor = c;
                    button9.BackColor = button8.BackColor;
                }
                if(y==7)
                {
                    button11.BackColor =c;
                    button10.BackColor = button9.BackColor;
                }
                if(y==8)
                {
                    button12.BackColor =c;
                    button11.BackColor = button10.BackColor;
                }
                if(y<=4 && y>=8)
                {
                    y++;
                }
            if(x==buttons.Count && !isTrue)
            {
                buttons[0].BackColor = c;
                button6.BackColor = button8.BackColor;
                isTrue = true;
                x++;
            }
            if(isTrue)
            {
                if (y != 7 && y!=0)
                {
                    button6.BackColor = button11.BackColor;
                }
            }
            y ++;
            if (!isFis)
            {
                tot += int.Parse(textBox2.Text);
                View(Math.Abs(tot));
            }
        }

        private void BackwardClick(object sender, EventArgs e)
        {
            isFis = false;
            if(y<=0)
            {
                y = 0;
            }
            if(y>=9)
            {
                y = 9;
            }
            foreach(var n in buttons)
            {
                if(n.BackColor==c && y!=1 && y<4)
                {
                    n.BackColor = buttons[y].BackColor;
                    buttons[y - 2].BackColor =c;
                   
                }
            }
            if(y==1)
            {
                button6.BackColor = c;
                button7.BackColor = button8.BackColor;
                int b = 0;
                int b2 = int.Parse(textBox2.Text);
            }
            if(y==4)
            {
                button7.Text = "2";
                button8.Text = "3";
                button9.Text = "4";
                button10.Text = "5";
                button11.Text = ".";
            }
            if(y==5)
            {
                button8.Text = "4";
                button9.Text = "5";
                button10.Text = "6";
                button11.Text = ".";
            }
            if(y==6)
            {
                button8.Text = "5";
                button9.Text = "6";
                button10.Text = "7";
                button11.Text = ".";
            }
            if(y==7)
            {
                button9.BackColor = c;
                button10.BackColor = button11.BackColor;
            }
            if(y==8)
            {
                button10.BackColor = c;
                button11.BackColor = button12.BackColor;
            }
            if(y==9)
            {
                button12.BackColor = button6.BackColor;
                button11.BackColor = c;
            }
            y--;
            tot -= int.Parse(textBox2.Text);
            res -= int.Parse(textBox2.Text)+2; 
            View(Math.Abs(tot));
        }

      
    }
}
