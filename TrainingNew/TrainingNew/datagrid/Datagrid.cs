using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingNew
{
    public partial class Datagrid : Form
    {
        public Datagrid()
        {
            InitializeComponent();
            datas.datagridEvent += Datas_datagridEvent; ;
        }
        List<DatagridClass> List = new List<DatagridClass>();
        private int index,edit=0;

        private void Datas_datagridEvent(object sender, (int employeeid, string name, int age, string department, int salary) e)
        {
            DatagridClass datagridClass = new DatagridClass()
            {
                employeeid = e.employeeid,
                name = e.name,
                age = e.age,
                department = e.department,
                salary = e.salary
            };
            if (edit == 1)
            {
                List.RemoveAt(index);
                dataGridView1.Rows.RemoveAt(index);
                List.Insert(index, datagridClass);
                dataGridView1.Rows.Insert(index, e.employeeid, e.name, e.age, e.department, e.salary);
            }
            else
            {
                List.Add(datagridClass);
                dataGridView1.Rows.Add(e.employeeid, e.name, e.age, e.department, e.salary);
            }
            edit = 0;
        }

        private datasUserControl datas = new datasUserControl();
        private void Datagrid_Load(object sender, EventArgs e)
        {
            Controls.Add(datas);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datas.Id = List[index].employeeid;
            datas.Names = List[index].name;
            datas.Age = List[index].age;
            datas.Department = List[index].department;
            datas.Salary = List[index].salary;
            edit = 1;
        }
    }
}
