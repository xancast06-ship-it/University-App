using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace University_App
{
    public partial class frmManageStudents : Form
    {
        public frmManageStudents()
        {
            InitializeComponent();
        }

        private void frmManageStudents_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
        private void LoadStudents()
        {
            string connectionString =
                @"Server=XanderLaptop;
                  Database=StudentDB;
                  Trusted_Connection=True;
                  TrustServerCertificate=True;";

            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string sql =
                @"SELECT *
                  FROM Student
                  ORDER BY Student_ID";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvStudents.DataSource = table;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(txtStudentID.Text);

                string firstName = txtFirstName.Text.Trim();

                string lastName = txtLastName.Text.Trim();

                string email = txtEmail.Text.Trim();

                string major = txtMajor.Text.Trim();

                string connectionString =
                    @"Server=XanderLaptop;
                      Database=StudentDB;
                      Trusted_Connection=True;
                      TrustServerCertificate=True;";

                using SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                string checkSql =
                @"SELECT COUNT(*)
                  FROM Student
                  WHERE Student_ID = @StudentID";

                SqlCommand checkCommand = new SqlCommand(checkSql, connection);

                checkCommand.Parameters.AddWithValue("@StudentID", studentID);

                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Student ID already exists.");

                    return;
                }

                string sql =
                @"INSERT INTO Student
                    (
                        Student_ID,
                        FirstName,
                        LastName,
                        Email,
                        Major
                    )
                  VALUES
                    (
                        @StudentID,
                        @FirstName,
                        @LastName,
                        @Email,
                        @Major
                    )";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@StudentID", studentID);

                command.Parameters.AddWithValue("@FirstName", firstName);

                command.Parameters.AddWithValue("@LastName", lastName);

                command.Parameters.AddWithValue("@Email", email);

                command.Parameters.AddWithValue("@Major", major);

                command.ExecuteNonQuery();

                MessageBox.Show("Student added successfully.");

                LoadStudents();

                txtStudentID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtEmail.Clear();
                txtMajor.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a student.");

                    return;
                }

                int studentID = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["Student_ID"].Value);

                string connectionString =
                    @"Server=XanderLaptop;
                      Database=StudentDB;
                      Trusted_Connection=True;
                      TrustServerCertificate=True;";

                using SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                string checkSql =
                @"SELECT COUNT(*)
                  FROM Enrollment
                  WHERE Student_ID = @StudentID";

                SqlCommand checkCommand = new SqlCommand(checkSql, connection);

                checkCommand.Parameters.AddWithValue("@StudentID", studentID);

                int enrollmentCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (enrollmentCount > 0)
                {
                    MessageBox.Show("This student cannot be deleted because they have enrolled classes.");

                    return;
                }

                string deleteSql =
                @"DELETE FROM Student
                WHERE Student_ID = @StudentID";

                SqlCommand deleteCommand = new SqlCommand(deleteSql, connection);

                deleteCommand.Parameters.AddWithValue("@StudentID", studentID);

                deleteCommand.ExecuteNonQuery();

                MessageBox.Show("Student deleted successfully.");

                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
