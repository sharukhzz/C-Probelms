using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RR
{
    public partial class Userr : UserControl
    {
        public Userr()
        {
            InitializeComponent();
        }
        public delegate void Datas(bool f);
        public event Datas Evented;

        public event EventHandler Ee;

        public event EventHandler<int> Es;
        private void AQ_Click(object sender, EventArgs e)
        {
            Evented?.Invoke(true);
            Ee?.Invoke(this, e);
        }
        private static bool b;

        public  bool BBB { get => b; set {
                b = value;
                BackColor = Color.Beige;
            } }

    }
}
