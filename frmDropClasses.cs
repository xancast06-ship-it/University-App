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
    public partial class frmDropClasses : Form
    {
        private void frmDropClasses_Load(object sender, EventArgs e)
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
                c.Course_Name
            FROM Enrollment e
            INNER JOIN Course_Section cs
                ON e.Section_ID = cs.Section_ID
            INNER JOIN Course c
                ON cs.Course_ID = c.Course_ID
            WHERE e.Student_ID = @StudentID";

            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@StudentID", Session.StudentID);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvDropClasses.DataSource = table;
        }

        private void btnDropClass_Click(object sender, EventArgs e)
        {
            if (dgvDropClasses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a class first.");

                return;
            }

            int enrollmentID = Convert.ToInt32(dgvDropClasses.SelectedRows[0].Cells["Enrollment_ID"].Value);

            string connectionString =
                @"Server=XanderLaptop;
                  Database=StudentDB;
                  Trusted_Connection=True;
                  TrustServerCertificate=True;";

            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string sql =
                @"DELETE FROM Enrollment
                  WHERE Enrollment_ID = @EnrollmentID";

            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@EnrollmentID", enrollmentID);

            command.ExecuteNonQuery();

            MessageBox.Show("Class dropped successfully.");
        }
    }
}
