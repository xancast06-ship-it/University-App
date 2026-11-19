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
    public partial class frmMySchedule : Form
    {
        public frmMySchedule()
        {
            InitializeComponent();
        }
        private void frmMySchedule_Load(object sender, EventArgs e)
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
                c.Course_Number,
                c.Course_Name,
                p.FirstName + ' ' + p.LastName AS Professor,
                cs.Room,
                cs.Semester,
                cs.Year
            FROM Enrollment e
            INNER JOIN Course_Section cs
                ON e.Section_ID = cs.Section_ID
            INNER JOIN Course c
                ON cs.Course_ID = c.Course_ID
            INNER JOIN Professor p
                ON cs.Professor_ID = p.Professor_ID
            WHERE e.Student_ID = @StudentID";

            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@StudentID", Session.StudentID);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvSchedule.DataSource = table;

            dgvSchedule.Columns["Enrollment_ID"].Visible = false;
        }

        private void btnDropClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSchedule.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a class.");

                    return;
                }

                int enrollmentID = Convert.ToInt32(dgvSchedule.SelectedRows[0].Cells["Enrollment_ID"].Value);

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
                  WHERE Enroll_ID = @EnrollmentID";

                SqlCommand checkCommand = new SqlCommand(checkSql, connection);

                checkCommand.Parameters.AddWithValue("@EnrollmentID", enrollmentID);

                int gradeCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (gradeCount > 0)
                {
                    MessageBox.Show("This class cannot be dropped because a grade has already been assigned.");

                    return;
                }

                string deleteSql =
                    @"DELETE FROM Enrollment
                      WHERE Enrollment_ID = @EnrollmentID";

                SqlCommand deleteCommand = new SqlCommand(deleteSql, connection);

                deleteCommand.Parameters.AddWithValue("@EnrollmentID", enrollmentID);

                deleteCommand.ExecuteNonQuery();

                MessageBox.Show("Class dropped successfully.");

                frmMySchedule_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
