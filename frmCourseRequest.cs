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
    public partial class frmCourseRequest : Form
    {
        public frmCourseRequest()
        {
            InitializeComponent();
        }

        private void frmCourseRequest_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            try
            {
                string courseName = txtCourseName.Text.Trim();

                int credits = Convert.ToInt32(txtCredits.Text);

                string reason = txtReason.Text.Trim();

                string connectionString =
                    @"Server=XanderLaptop;
                      Database=StudentDB;
                      Trusted_Connection=True;
                      TrustServerCertificate=True;";

                using SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                string sql =
                @"INSERT INTO Course_Request
                    (
                        Professor_ID,
                        Course_Name,
                        Credits,
                        Reason,
                        Status
                    )
                  VALUES
                    (
                        @ProfessorID,
                        @CourseName,
                        @Credits,
                        @Reason,
                        'Pending'
                    )";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@ProfessorID", Session.ProfessorID);

                command.Parameters.AddWithValue("@CourseName", courseName);

                command.Parameters.AddWithValue("@Credits", credits);

                command.Parameters.AddWithValue("@Reason", reason);

                command.ExecuteNonQuery();

                MessageBox.Show("Request submitted successfully.");

                txtCourseName.Clear();
                txtCredits.Clear();
                txtReason.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
