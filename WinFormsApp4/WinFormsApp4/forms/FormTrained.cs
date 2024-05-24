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
    public partial class FormTrained : Form
    {
        public FormTrained()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"data source=DESKTOP-MQGQHM6\ASD;Initial Catalog=tech;integrated Security=true;";
            SqlConnection con = new SqlConnection(connectionString);

            //Line 1
            string queryStatement = $"SELECT age , address , specialization FROM trained where name = '{textBox2.Text}'";
            SqlCommand cmd = new SqlCommand(queryStatement, con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //Line 2
            label8.Text = reader.GetInt32(0).ToString();
            label3.Text = reader.GetString(1).ToString();
            label6.Text = reader.GetString(2).ToString();

            con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
