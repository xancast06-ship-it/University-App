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
    public partial class frmManageCourses : Form
    {
        public frmManageCourses()
        {
            InitializeComponent();
        }

        private void frmManageCourses_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }
        private void LoadCourses()
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
                  FROM Course
                  ORDER BY Course_ID";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvCourses.DataSource = table;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                string courseNumber = txtCourseNumber.Text.Trim();

                string courseName = txtCourseName.Text.Trim();

                int credits = Convert.ToInt32(txtCredits.Text);

                string department = txtDepartment.Text.Trim();

                string connectionString =
                    @"Server=XanderLaptop;
                      Database=StudentDB;
                      Trusted_Connection=True;
                      TrustServerCertificate=True;";

                using SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                string checkSql =
                    @"SELECT COUNT(*)
                      FROM Course
                      WHERE Course_Number = @CourseNumber";

                SqlCommand checkCommand = new SqlCommand(checkSql, connection);

                checkCommand.Parameters.AddWithValue("@CourseNumber", courseNumber);

                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("A course with this course number already exists.");

                    return;
                }

                string sql =
                @"INSERT INTO Course
                    (
                        Course_Number,
                        Course_Name,
                        Credits,
                        Department
                    )
                  VALUES
                    (
                        @CourseNumber,
                        @CourseName,
                        @Credits,
                        @Department
                    )";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@CourseNumber", courseNumber);

                command.Parameters.AddWithValue("@CourseName", courseName);

                command.Parameters.AddWithValue("@Credits", credits);

                command.Parameters.AddWithValue("@Department", department);

                command.ExecuteNonQuery();

                MessageBox.Show("Course added successfully.");

                LoadCourses();

                txtCourseNumber.Clear();
                txtCourseName.Clear();
                txtCredits.Clear();
                txtDepartment.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCourses.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a course.");

                    return;
                }

                int courseID = Convert.ToInt32(dgvCourses.SelectedRows[0].Cells["Course_ID"].Value);

                string connectionString =
                    @"Server=XanderLaptop;
                      Database=StudentDB;
                      Trusted_Connection=True;
                      TrustServerCertificate=True;";

                using SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                string checkSql =
                @"SELECT COUNT(*)
                  FROM Course_Section
                  WHERE Course_ID = @CourseID";

                SqlCommand checkCommand = new SqlCommand(checkSql, connection);

                checkCommand.Parameters.AddWithValue("@CourseID", courseID);

                int sectionCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (sectionCount > 0)
                {
                    MessageBox.Show("This course cannot be deleted because sections are currently assigned to it.");

                    return;
                }

                string deleteSql =
                @"DELETE FROM Course
                WHERE Course_ID = @CourseID";

                SqlCommand deleteCommand = new SqlCommand(deleteSql, connection);

                deleteCommand.Parameters.AddWithValue("@CourseID", courseID);

                deleteCommand.ExecuteNonQuery();

                MessageBox.Show("Course deleted successfully.");

                LoadCourses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
