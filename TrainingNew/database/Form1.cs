using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLibrary;


namespace database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DatabaseManager manager = new MySqlHandler("localhost", "root", "Sharuk@123.", "Training");

        private void button1_Click(object sender, EventArgs e)
        {
            string tablename = "Information";
            string s = manager.InsertData(tablename, new ParameterData[]
                {
                    new ParameterData("Id",Convert.ToInt32(textBox1.Text)),
                    new ParameterData("Name",textBox2.Text)
                }).Message;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var res = manager.FetchData("Information","Id=1").Value;
            if (res != null)
            {
                for (int i = 0; i < res["Id"].Count; i++)
                {
                    textBox4.Text += res["Id"][i].ToString();
                    textBox4.Text += res["Name"][i].ToString();
                }
            }
        }

        private void DatabseForm_Load(object sender, EventArgs e)
        {
            string s = manager.Connect().Message;
            bool b = manager.IsConnected;
            manager.CreateTable("Information", new ColumnDetails[] {
                new ColumnDetails("Id",BaseDatatypes.INT,10,10,IndexType.PrimaryKey),
                new ColumnDetails("Name",BaseDatatypes.VARCHAR,24)
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = 2;
            manager.DeleteData("Information", $"Id='{id}'",1);
        }
    }

}
