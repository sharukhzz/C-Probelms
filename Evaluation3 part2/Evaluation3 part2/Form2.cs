using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation3_part2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form1.UserNames += Form1_UserNames1;
            UserManagerClass1cs.EEvents += UserManagerClass1cs_EEvents;
            UserManagerClass1cs.DEvents += UserManagerClass1cs_DEvents;
            foreach (var item in comboBox1.Items)
            {
                items.Add(item + "");
            }
        }


        public string Users { get; set; }
        public string UserName { get; set; }
        private List<string> items = new List<string>();
        private void UserManagerClass1cs_DEvents(string s1, string s2, string s3, string s4)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value == s1)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
        }

        private void UserManagerClass1cs_EEvents(string s1, string s2, string s3, string s4)
        {
            if (s1 != "" && s2!="" && s3!="" && s4!="" && dataGridView1.Columns.Count>1)
            {
                   dataGridView1.Rows.Add(s1, s2, s3, s4);
            }
        }


        private void Form1_UserNames1(string s1, string s2)
        {
            label8.Text = s1;
            label1.Text = s2;
        }

        public static EnumClasscs.UserLevel Change(string s)
        {
            if (s == "Admin") return EnumClasscs.UserLevel.Admin;
            if (s == "Administartor") return EnumClasscs.UserLevel.Administrator;
            if (s == "Manager") return EnumClasscs.UserLevel.Manager;
            if (s == "Supervisor") return EnumClasscs.UserLevel.Supervisor;
            else return EnumClasscs.UserLevel.Operator;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox3.Text;
            EveForm2?.Invoke(sender, label1.Text);
            Form1.User = label1.Text;
            //this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserDetailsClass userDetailsClass = new UserDetailsClass()
            {
                Names = textBox1.Text,
                Username = textBox2.Text,
                Password = textBox3.Text,
                UserLevell = Change(comboBox1.Text)
            };
            if (comboBox1.Text == "Administrator")
            {
                comboBox1.Items.Remove("Administrator");
                comboBox3.Items.Remove("Administartor");
            }
            UserManagerClass1cs.AddDetails(userDetailsClass);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            panel1.Visible = false;
            MessageBox.Show("Details Created");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //foreach(var item in items)
            //{
            //    if(!comboBox1.Items.Contains(item))
            //    comboBox1.Items.Add(item);
            //}
            panel4.Visible = false;
            panel1.Visible = true;
            panel3.Visible = false;
            panel2.Visible = false;
            comboBox3.Visible = false;
            //for(int i=0;i<comboBox1.Items.Count;i++)
            //{
            //    if (Change(label1.Text) <= Change(comboBox1.Items[i] + ""))
            //    {
            //        comboBox1.Items.Remove(comboBox1.Items[i]);
            //    }
            //}
            comboBox1.Items.Clear();
            if (label1.Text == "Admin" && !comboBox1.Items.Contains("Admin"))
            {
                comboBox1.Items.Add("Administrator");
                comboBox1.Items.Add("Manager");
                comboBox1.Items.Add("Supervisor");
                comboBox1.Items.Add("Operator");
            }
            if (label1.Text == "Administrator" && !comboBox1.Items.Contains("Administrator"))
            {
                comboBox1.Items.Add("Manager");
                comboBox1.Items.Add("Supervisor");
                comboBox1.Items.Add("Operator");
            }
            if (label1.Text == "Manager" && !comboBox1.Items.Contains("Manager"))
            {
                comboBox1.Items.Add("Supervisor");
                comboBox1.Items.Add("Operator");
            }
            if (label1.Text == "Supervisor")
            {
                comboBox1.Items.Add("Operator");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox3.Visible = false;
            panel1.Visible = false;
            panel3.Visible = true;
            panel2.Visible = false;
            panel4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            comboBox3.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
            comboBox3.Items.Clear();
            foreach (var item in comboBox1.Items)
            {
                comboBox3.Items.Add(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            comboBox4.Text = "";
            comboBox4.Items.Clear();
            panel2.Visible = true;
            comboBox3.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            foreach (var item in UserManagerClass1cs.list)
            {
                comboBox4.Items.Add(item.Username + "");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserManagerClass1cs.Delete(comboBox4.Text);
            panel2.Visible = false;
        }

        private void butto_Click(object sender, EventArgs e)
        {
            UserManagerClass1cs.Update(label8.Text, textBox4.Text, textBox5.Text);
            panel3.Visible = false;

        }
        public static event EventHandler<string> EveForm2;

        private void button_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            comboBox3.Visible = false;
        }
    }
}
