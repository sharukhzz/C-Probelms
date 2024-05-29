using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobManager
{
  
    public partial class UserControls : System.Windows.Forms.UserControl
    {
        public event DataSavedEventHandler dataSavedEvent;

        public UserControls()
        {
            InitializeComponent();
        }
        public void UpdateValues(bool isJob,Interfacedatas datas)
        {
            if(isJob)
            {
                JobDetails job = datas as JobDetails;
                textBox1.Text = job.Name;
                textBox2.Text = job.Row.ToString();
                textBox3.Text = job.Coloumn.ToString();
                textBox4.Text = job.Price.ToString();
                textBox5.Text = job.Modelname.ToString();
                textBox6.Text = job.Runname.ToString();
            }
        }
        public void Visibility(bool isJob, Interfacedatas data)
        {
            if(isJob)
            {
                label5.Visible = true;
                label6.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                button1.Location = new Point(83, 450);
                Height = 513;
            }
            else
            {
                label5.Visible = false;
                label6.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                button1.Location = new Point(101, 297);
                Height = button1.Location.Y+40;
            }
        }
        private void SubmitClick(object sender, EventArgs e)
        {
            MessageBox.Show("The datas are saved");
            Interfacedatas datas;
            if(label6.Visible)
            {
                JobDetails job = new JobDetails
                {
                    Name = textBox1.Text,
                    Row = Convert.ToInt32(textBox2.Text),
                    Coloumn = Convert.ToInt32(textBox3.Text),
                    Price = Convert.ToInt32(textBox4.Text),
                    Modelname = textBox5.Text,
                    Runname=textBox6.Text,
                };
                datas = job;
            }
            else
            {
                ModelDetails model = new ModelDetails
                {
                    Name = textBox1.Text,
                    Row = Convert.ToInt32(textBox2.Text),
                    Coloumn = Convert.ToInt32(textBox3.Text),
                    Price = Convert.ToInt32(textBox4.Text),
                };
                datas = model;
            }
            dataSavedEvent?.Invoke(label6.Visible, datas);
        }
    }
}
