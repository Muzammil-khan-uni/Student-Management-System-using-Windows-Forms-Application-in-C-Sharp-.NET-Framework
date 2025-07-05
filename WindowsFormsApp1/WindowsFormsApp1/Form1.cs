using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string Name = name.Text;
            string RollNo = rollno.Text;
            string Email = email.Text;
            string connectionString = ConfigurationManager.ConnectionStrings["Lab2"].ConnectionString;

            string query = "INSERT INTO STUDENTDB (Name,Roll_No,Email) VALUES (@Name,@Roll_No,@Email)";
            using (SqlConnection conn = new SqlConnection(connectionString))

            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Roll_No", RollNo);
                    cmd.Parameters.AddWithValue("@Email", Email);

                    int Result = cmd.ExecuteNonQuery();

                    if (Result > 0)
                    {
                        MessageBox.Show("Record inserted Sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("There some error");
                    }

                }


            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            name.Text = "";
            rollno.Text = "";
            email.Text = "";
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Lab2"].ConnectionString;
            string query = "SELECT * FROM STUDENTDB";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string Name = name.Text;
            string RollNo = rollno.Text;
            string Email = email.Text;
            string connectionString = ConfigurationManager.ConnectionStrings["Lab2"].ConnectionString;

            string query = "UPDATE STUDENTDB SET Name = @Name, Email = @Email WHERE Roll_No = @Roll_No";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Roll_No", RollNo);
                    cmd.Parameters.AddWithValue("@Email", Email);

                    int Result = cmd.ExecuteNonQuery();
                    if (Result > 0)
                    {
                        MessageBox.Show("Record updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given Roll No");
                    }
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string RollNo = rollno.Text;
    string connectionString = ConfigurationManager.ConnectionStrings["Lab2"].ConnectionString;

    string query = "DELETE FROM STUDENTDB WHERE Roll_No = @Roll_No";
    using (SqlConnection conn = new SqlConnection(connectionString))
    {
        conn.Open();
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@Roll_No", RollNo);

            int Result = cmd.ExecuteNonQuery();
            if (Result > 0)
            {
                MessageBox.Show("Record deleted successfully");
            }
            else
            {
                MessageBox.Show("No record found with the given Roll No");
            }
        }
    }
        }
    }
}
