using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University_App
{
    public partial class frmSubmitGrades : Form
    {
        public frmSubmitGrades()
        {
            InitializeComponent();
        }

        private void frmSubmitGrades_Load(object sender, EventArgs e)
        {
            string connectionString =
                @"Server=XanderLaptop;
                  Database=StudentDB;
                  Trusted_Connection=True;
                  TrustServerCertificate=True;";

            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string sql =
            @"SELECT Section_ID
              FROM Course_Section
              WHERE Professor_ID = @ProfessorID";

            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@ProfessorID", Session.ProfessorID);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                cmbSections.Items.Add(reader["Section_ID"].ToString());
            }
        }

        private void cmbSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString =
                @"Server=XanderLaptop;
                  Database=StudentDB;
                  Trusted_Connection=True;
                  TrustServerCertificate=True;";

            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string sql =
            @"SELECT
                e.Enrollment_ID,
                s.Student_ID,
                s.FirstName,
                s.LastName
              FROM Enrollment e
              INNER JOIN Student s
                ON e.Student_ID = s.Student_ID
              WHERE e.Section_ID = @SectionID";

            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@SectionID", cmbSections.SelectedItem);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvStudents.DataSource = table;
        }

        private void btnSubmitGrade_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvStudents.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a student.");

                    return;
                }

                if (txtGrade.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter a grade.");

                    return;
                }

                int enrollmentID = Convert.ToInt32(dgvStudents.SelectedRows[0].Cells["Enrollment_ID"].Value);

                string grade = txtGrade.Text.Trim();

                string connectionString =
                    @"Server=XanderLaptop;
                      Database=StudentDB;
                      Trusted_Connection=True;
                      TrustServerCertificate=True;";

                using SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                string checkSql =
                @"SELECT COUNT(*)
                  FROM Grade
                  WHERE Enroll_ID = @EnrollID";

                SqlCommand checkCommand = new SqlCommand(checkSql, connection);

                checkCommand.Parameters.AddWithValue("@EnrollID", enrollmentID);

                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count > 0)
                {
                    string updateSql =
                    @"UPDATE Grade
                      SET Grade = @Grade
                      WHERE Enroll_ID = @EnrollID";

                    SqlCommand updateCommand = new SqlCommand(updateSql, connection);

                    updateCommand.Parameters.AddWithValue("@EnrollID", enrollmentID);

                    updateCommand.Parameters.AddWithValue("@Grade", grade);

                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show("Grade updated successfully.");
                }
                else
                {
                    string insertSql =
                    @"INSERT INTO Grade
                        (Enroll_ID, Grade)
                      VALUES
                        (@EnrollID, @Grade)";

                    SqlCommand insertCommand = new SqlCommand(insertSql, connection);

                    insertCommand.Parameters.AddWithValue("@EnrollID", enrollmentID);

                    insertCommand.Parameters.AddWithValue("@Grade", grade);

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Grade submitted successfully.");
                }

                txtGrade.Clear();

                cmbSections_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
