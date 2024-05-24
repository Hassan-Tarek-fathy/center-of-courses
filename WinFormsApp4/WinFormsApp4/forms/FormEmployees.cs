using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WinFormsApp4.forms
{
    public partial class FormEmployees : Form
    {
        public FormEmployees()
        {
            InitializeComponent();
        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"data source=DESKTOP-MQGQHM6\ASD;Initial Catalog=tech;integrated Security=true;";
            SqlConnection con = new SqlConnection(connectionString);

            //Line 1
            string queryStatement = $"SELECT age , salary , phone , city , street FROM employee where fname = '{textBox1.Text}' and lname = '{textBox2.Text}'";
            SqlCommand cmd = new SqlCommand(queryStatement, con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //Line 2
            label8.Text = reader.GetInt32(0).ToString();
            label4.Text = reader.GetDecimal(1).ToString();
            label3.Text = reader.GetString(2).ToString();
            label11.Text = reader.GetString(3).ToString();
            label12.Text = reader.GetString(4).ToString();

            con.Close();


        }

        private void FormEmployees_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
