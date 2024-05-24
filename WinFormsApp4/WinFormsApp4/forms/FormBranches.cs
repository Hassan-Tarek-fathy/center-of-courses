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
    public partial class FormBranches : Form
    {
        public FormBranches()
        {
            InitializeComponent();
        }

        private void FormBranches_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"data source=DESKTOP-MQGQHM6\ASD;Initial Catalog=tech;integrated Security=true;";
            SqlConnection con = new SqlConnection(connectionString);

            //Line 1
            string queryStatement = $"SELECT id , Eservice , street , city FROM branches where Fname = '{textBox2.Text}'";
            SqlCommand cmd = new SqlCommand(queryStatement, con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //Line 2
            label6.Text = reader.GetInt32(0).ToString();
            label4.Text = reader.GetString(1).ToString();
            label8.Text = reader.GetString(2).ToString();
            label1.Text = reader.GetString(3).ToString();

            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
