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
    public partial class Formcours : Form
    {
        public Formcours()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"data source=DESKTOP-MQGQHM6\ASD;Initial Catalog=tech;integrated Security=true;";
            SqlConnection con = new SqlConnection(connectionString);

            //Line 1
            string queryStatement = $"SELECT technology , career  FROM courses  where name  = '{comboBox1.Text}'";
            SqlCommand cmd = new SqlCommand(queryStatement, con);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //Line 2
            {

                label4.Text = reader.GetString(0).ToString();
                label2.Text = reader.GetString(1).ToString();



                con.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Formcours_Load(object sender, EventArgs e)
        {
            string connectionString = @"data source=DESKTOP-MQGQHM6\ASD;Initial Catalog=tech;integrated Security=true;";
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from courses";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
