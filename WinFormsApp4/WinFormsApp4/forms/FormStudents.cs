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
    public partial class FormStudents : Form
    {
        public FormStudents()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormStudents_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"data source=DESKTOP-MQGQHM6\ASD;Initial Catalog=tech;integrated Security=true;";
            SqlConnection con = new SqlConnection(connectionString);

            //Line 1
            string queryStatement = $"SELECT address , college , specialization FROM student where name = '{textBox2.Text}'";
            SqlCommand cmd = new SqlCommand(queryStatement, con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //Line 2
            label8.Text = reader.GetString(0).ToString();
            label3.Text = reader.GetString(1).ToString();
            label6.Text = reader.GetString(2).ToString();

            con.Close();
        }
    }
}

