using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace job
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }
        public void Editting(bool b, JobDetails datas,UserControl11 obj1)
        {
            if (b)
            {
                obj1.IsClickk = true;
                obj1.IsClickk2 = false;
                obj1.Visiblity(false);
            }
            obj1.Location = new Point((this.Width - obj1.Width) / 2, (this.Height - obj1.Height) / 2);
            Controls.Add(obj1);
            datas.Name = obj1.name;

        }
        public void Editting2(bool b, ModelDetails datas,UserControl11 obj)
        {
            if (b)
            {
                obj.IsClickk = true;
                obj.IsClickk2 = false;
                obj.Visiblity(true);
            }
            obj.Location = new Point((this.Width - obj.Width) / 2, (this.Height - obj.Height) / 2);
            Controls.Add(obj);
        }
    }
}
