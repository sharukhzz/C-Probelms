using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DB.GetConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Detailsvalues> details=DB.AddDetails("ilam");
            string s = "";
            for(int i=0;i<details.Count;i++)
            {
              s += $"{details[i].id} {details[i].name} {details[i].address} {details[i].phno} {details[i].gender}\n";
            }
            label1.Text = s;
        }
    }
}
