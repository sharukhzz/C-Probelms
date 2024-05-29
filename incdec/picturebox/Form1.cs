using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace picturebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter ="SVG files (*.svg)|*.svg|All files(*.*)|*.*";
                if(openFile.ShowDialog()==DialogResult.OK)
                {
                    string selected = openFile.FileName;
                    pictureBox1.Image = new Bitmap(selected);
                }
            };
        }
    }
}
