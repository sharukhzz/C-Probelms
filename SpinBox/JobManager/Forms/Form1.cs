
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            obj.dataSavedEvent += Event;
        }
        JobDetails job = new JobDetails();
        ModelDetails model = new ModelDetails();
        Interfacedatas data;
        bool check = false;
        private void CreateClick(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
               obj.Visibility(true,job);
                check = true;
              
            }
            if(radioButton2.Checked)
            {
                obj.Visibility(false,model);
                check = false;
               
            }
            obj.Location = new Point((panel2.Width - obj.Width) / 2, ((panel2.Height - obj.Height) - panel1.Height + 70) / 2);
           
        }
       
        private void EditClick(object sender, EventArgs e)
        {
            EditForm edit = new EditForm();
            edit.Editting(check, data);
            edit.Show();
            
        }

        public void Event(bool isjob, Interfacedatas datas)
        {
            data = datas;
        }
    }
}
