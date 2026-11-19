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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            string connectionString =
                @"Server=XanderLaptop;
                  Database=StudentDB;
                  Trusted_Connection=True;
                  TrustServerCertificate=True;";

            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            lblStudents.Text = "Students: " + GetCount(connection,"SELECT COUNT(*) FROM Student");

            lblProfessors.Text = "Professors: " + GetCount(connection, "SELECT COUNT(*) FROM Professor");

            lblPersonnel.Text = "Personnel: " + GetCount(connection, "SELECT COUNT(*) FROM Personnel");

            lblCourses.Text ="Courses: " +GetCount(connection,"SELECT COUNT(*) FROM Course");

            lblSections.Text = "Sections: " + GetCount(connection, "SELECT COUNT(*) FROM Course_Section");

            lblEnrollments.Text ="Enrollments: " +GetCount(connection, "SELECT COUNT(*) FROM Enrollment");

            lblGrades.Text ="Grades: " +GetCount(connection,"SELECT COUNT(*) FROM Grade");

            lblPending.Text = "Pending Requests: " + GetCount(connection,
                @"SELECT COUNT(*)
                  FROM Course_Request
                  WHERE Status = 'Pending'");

            lblApproved.Text ="Approved Requests: " + GetCount(connection,
                @"SELECT COUNT(*)
                  FROM Course_Request
                  WHERE Status = 'Approved'");

            lblDenied.Text ="Denied Requests: " + GetCount(connection,
                @"SELECT COUNT(*)
                  FROM Course_Request
                  WHERE Status = 'Denied'");
        }
        private int GetCount(SqlConnection connection, string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);

            return Convert.ToInt32(command.ExecuteScalar());
        }


    }
}
