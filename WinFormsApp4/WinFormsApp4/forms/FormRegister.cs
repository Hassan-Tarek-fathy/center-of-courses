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
    public partial class FormRegister : Form
    {
        private object textBox3;
        private object textBox5;

        public FormRegister()
        {
            InitializeComponent();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormDepartments_Load(object sender, EventArgs e)
        {
            string connectionString = @"data source=DESKTOP-MQGQHM6\ASD;Initial Catalog=tech;integrated Security=true;";
            SqlConnection con = new SqlConnection(connectionString);
            string sql = "select * from student";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt; ;
            comboBox1.DisplayMember = "specialization";
            comboBox1.ValueMember = "specialization";


            string dql = "select * from courses";
            SqlDataAdapter fa = new SqlDataAdapter(dql, con);
            DataTable ft = new DataTable();
            fa.Fill(ft);
            comboBox2.DataSource = ft; ;
            comboBox2.DisplayMember = "tecnology";
            comboBox2.ValueMember = "name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"data source=DESKTOP-MQGQHM6\ASD;Initial Catalog=tech;integrated Security=true;";
            SqlConnection con = new SqlConnection(connectionString);

            //Line 1
            string queryStatement = $"INSERT INTO student values (@id,@name,@address,@college,@specialization)";
            SqlCommand cmd = new SqlCommand(queryStatement, con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@address", textBox4.Text);
            cmd.Parameters.AddWithValue("@college", textBox6.Text);
            cmd.Parameters.AddWithValue("@specialization", comboBox1.SelectedValue.ToString());
           // cmd.Parameters.AddWithValue("@course", comboBox2.SelectedValue.ToString());

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Add is complete");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
