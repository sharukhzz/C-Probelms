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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            userControl11.Data += UserControl11_Data;
        }
        private void UserControl11_Data(string[] details)
        {
            Datas?.Invoke(details);
        }
        public void Sendd(int r)
        {
            userControl11.Senduc(r);
        }

        public event DataSaved Datas;
    }
}
