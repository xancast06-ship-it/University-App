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
    public partial class frmMyGrades : Form
    {
        public frmMyGrades()
        {
            InitializeComponent();
        }

        private void frmMyGrades_Load(object sender, EventArgs e)
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
                c.Course_Number,
                c.Course_Name,
                p.FirstName + ' ' + p.LastName AS Professor,
                g.Grade
            FROM Grade g
            INNER JOIN Enrollment e
                ON g.Enroll_ID = e.Enrollment_ID
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

            dgvGrades.DataSource = table;
        }
    }
}
