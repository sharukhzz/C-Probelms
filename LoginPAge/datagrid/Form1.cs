using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0,index;
        private void button1_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                DataGridViewTextBoxColumn dataGridViewText = new DataGridViewTextBoxColumn();
                dataGridViewText.HeaderText = textBox1.Text;
                dataGridView1.Columns.Add(dataGridViewText);
                DataGridViewTextBoxColumn dataGridViewText1 = new DataGridViewTextBoxColumn();
                dataGridViewText1.HeaderText = textBox3.Text;
                dataGridView1.Columns.Add(dataGridViewText1);
                DataGridViewTextBoxColumn dataGridViewText2 = new DataGridViewTextBoxColumn();
                dataGridViewText2.HeaderText = textBox5.Text;
                dataGridView1.Columns.Add(dataGridViewText2);
            }
            dataGridView1.Rows.Add();
            dataGridView1.Rows[x].Cells[0].Value = textBox2.Text;
            dataGridView1.Rows[x].Cells[1].Value = textBox4.Text;
            dataGridView1.Rows[x].Cells[2].Value = textBox6.Text;
            x++;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {         
            dataGridView1.Rows.RemoveAt(index);
        }
    }
}
