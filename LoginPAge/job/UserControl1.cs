using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace job
{
    public interface IDatas
    {
        string Name { get; set; }
        int Row { get; set; }
        int Coloumn { get; set; }
        int Price { get; set; }
    }
     
    public partial class UserControl11 : UserControl
    { 
        public UserControl11()
        {
            InitializeComponent();
        }
        private  bool isClicked;
         JobDetails j = new JobDetails();
         ModelDetails m = new ModelDetails();
        public bool IsClickk
        {
            get{ return isClicked; }
            set { isClicked = value; }
        }
        private bool isClicked2;
        public bool IsClickk2
        {
            get { return isClicked2; }
            set { isClicked2 = value; }
        }

        public delegate void DataSavedEventHandler(string name,int row,int coloumn,int price,string model,string runname);
        public DataSavedEventHandler DataSavedDelegate;

        public delegate void DataSavedEventHandler2(string name, int row, int coloumn, int price);
        public DataSavedEventHandler2 DataSavedDelegate2;

       public void Reset(bool b)
        {
            if (b)
            {
                j.Name = null;
                j.Row = 0;
                j.Coloumn = 0;
                j.Price = 0;
                j.Model = null;
                j.Runname = null;
            }
            else
            {
                m.Name = null;
                m.Row = 0;
                m.Coloumn = 0;
                m.Price = 0;
            }
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
        }
        public void Labelchange(TextBox textbox)
        {
            Label l = new Label
            {
                Size = textbox.Size,
                Location = textbox.Location,
                BorderStyle = textbox.BorderStyle,
                Text = textbox.Text,
                BackColor=textbox.BackColor,
            };
            Controls.Add(l);
            Controls.Remove(textbox);
        }
        public void Display(bool b)
        {
            if (b)
            {
                textBox1.Text = j.Name;
                textBox2.Text = j.Row.ToString();
                textBox3.Text = j.Coloumn.ToString();
                textBox4.Text = j.Price.ToString();
                textBox5.Text = j.Model;
                textBox6.Text = j.Runname;
                Labelchange(textBox1);
                Labelchange(textBox2);
                Labelchange(textBox3);
                Labelchange(textBox4);
                Labelchange(textBox5);
                Labelchange(textBox6);
            }
            else
            {
                textBox1.Text = m.Name;
                textBox2.Text = m.Row.ToString();
                textBox3.Text = m.Coloumn.ToString();
                textBox4.Text = m.Price.ToString();
                Labelchange(textBox1);
                Labelchange(textBox2);
                Labelchange(textBox3);
                Labelchange(textBox4);
            }
        }
        public void Visiblity(bool b)
        {
            if(b)
            {
                textBox5.Visible = false;
                textBox6.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                button1.Location = new Point(129, 286);
                Height = button1.Location.Y + 40;
            }
            else 
            {
                textBox5.Visible = true;
                textBox6.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                button1.Location = new Point(124, 416);
                Height = 464;
            }         
        }

        public  string name,model,runname;
        public int row, coloumn, price;

        private void SubmitClick(object sender, EventArgs e)
        {
            MessageBox.Show("the above information are saved");
            if (isClicked)
            {
                j.Name = textBox1.Text;
                j.Row = Convert.ToInt32(textBox2.Text);
                j.Coloumn = Convert.ToInt32(textBox3.Text);
                j.Price = Convert.ToInt32(textBox4.Text);
                j.Model = textBox5.Text;
                j.Runname = textBox6.Text;
                DataSavedDelegate?.Invoke(j.Name,j.Row,j.Coloumn,j.Price,j.Model,j.Runname);
            }
            else if(isClicked2)
            {
                m.Name = textBox1.Text;
                m.Row = Convert.ToInt32(textBox2.Text);
                m.Coloumn = Convert.ToInt32(textBox3.Text);
                m.Price = Convert.ToInt32(textBox4.Text);
                DataSavedDelegate2?.Invoke(m.Name,m.Row,m.Coloumn,m.Price);
            }
        }
    }
}
