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
    public partial class Form1 : Form
    {

        public JobDetails jobDetails = new JobDetails();
        public ModelDetails modelDetails=new ModelDetails();


        UserControl11 obj1 = new UserControl11();
        
        public Form1() 
        {
            InitializeComponent();
        }
        public bool isClick,isClick2;


        private void RadioButton1CheckedChanged(object sender, EventArgs e)
        {        
            panel1.Controls.Clear();
            obj1.IsClickk2 = false;
            obj1.IsClickk = true;
        }
        private void RadioButton2CheckedChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            obj1.IsClickk = false;
            obj1.IsClickk2 = true;
        }
        private void CreateClick(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if (radioButton1.Checked)
            {
               obj1.Reset(true);
                obj1.DataSavedDelegate += U1;
                obj1.Visiblity(false);
            }
            if (radioButton2.Checked)
            {
               obj1.Reset(false);
                obj1.DataSavedDelegate2 += U2;
                obj1.Visiblity(true);
            }
            obj1.Location = new Point((panel1.Width - obj1.Width) / 2, ((panel1.Height - obj1.Height) - panel2.Height) / 2);
            panel1.Controls.Add(obj1);
        }
        private void EditClick(object sender, EventArgs e)
        {
            //isClick = false;
            //isClick2 = false;
            //if (radioButton1.Checked)
            //{
            //    isClick = true;
            //}
            //if (radioButton2.Checked)
            //{
            //    isClick2 = true;
            //}
            //if (isClick)
            //{
            //    obj1.DataSavedDelegate += U1;
            //    obj1.IsClickk2 = false;
            //    obj1.IsClickk = true;
            //    obj1.Location = new Point((panel1.Width - obj1.Width) / 2, ((panel1.Height - obj1.Height) - panel2.Height) / 2);
            //    panel1.Controls.Add(obj1);
            //}
            //else
            //{
            //    obj1.DataSavedDelegate2 += U2;
            //    obj1.IsClickk = false;
            //    obj1.IsClickk2 = true;
            //    obj1.Location = new Point((panel1.Width - obj1.Width) / 2, ((panel1.Height - obj1.Height) - panel2.Height) / 2);
            //    panel1.Controls.Add(obj1);
            //}



            //if (radioButton1.Checked)
            //{
            //    obj1 = new JobDetails();
            //    obj1.DataSavedDelegate += U1;
            //}
            //else if (radioButton2.Checked)
            //{
            //    obj1 = new ModelDetails();
            //    obj1.DataSavedDelegate2 += U2;
            //}
            //obj1.Location = new Point((panel1.Width - obj1.Width) / 2, ((panel1.Height - obj1.Height) - panel2.Height) / 2);
            //panel1.Controls.Add(obj1);
            //panel1.Controls.Clear();

           


            Edit obj = new Edit();           
            if (radioButton1.Checked)
            {
                //obj.Controls.Add(obj1);
                obj.Editting(true, jobDetails,obj1);
                obj1.DataSavedDelegate += U1;
            }
            else if (radioButton2.Checked)
            {
               obj.Editting2(true, modelDetails,obj1);
                //obj.Controls.Add(obj1);
            }
            obj.Show();
           // panel1.Controls.Add(obj1);
        }
       
        private void ResetClick(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                obj1.Reset(true);
            }
            if(radioButton2.Checked)
            {
                obj1.Reset(false);
            }
        }

        private void ViewClick(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                obj1.Visiblity(false);
                obj1.Display(true);
            }
            if(radioButton2.Checked)
            {
                obj1.Visiblity(true);
                obj1.Display(false);
            }
            obj1.Location = new Point((panel1.Width - obj1.Width) / 2, ((panel1.Height - obj1.Height) - panel2.Height) / 2);
            panel1.Controls.Add(obj1);
        }

        private void U1(string name, int row, int coloumn, int price, string model, string runname)
        {
            jobDetails.Name = name;
            jobDetails.Row = row;
            jobDetails.Coloumn = coloumn;
            jobDetails.Price = price;
            jobDetails.Model = model;
            jobDetails.Runname = runname;
        }

        private void U2(string name, int row, int coloumn, int price)
        {
            modelDetails.Name = name;
            modelDetails.Row = row;
            modelDetails.Coloumn = coloumn;
            modelDetails.Price = price;
        }
    }
}
