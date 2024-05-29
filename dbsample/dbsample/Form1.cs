using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dbsample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private const string ConnectionString = "Server=localhost;Database=winformdb;Uid=root;Pwd=Sharuk@123.;";
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO login (Username, Password) VALUES (@name, @email)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@email", email);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Record inserted successfully!");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee + "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usernameToDelete = textBox3.Text;

            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "DELETE FROM login WHERE Username = @Username";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", usernameToDelete);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the specified User .");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string u = textBox4.Text;
            string p = textBox5.Text;
            using (MySqlConnection con = new MySqlConnection(ConnectionString))
            {
                con.Open();
                string query = "UPDATE login SET Password=@pas WHERE Username=@user ";
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@user", u);
                    command.Parameters.AddWithValue("@pas", p);
                    int rowAffected = command.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Record Updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the specified usename.");
                    }
                }
            }
        }
    }
}

