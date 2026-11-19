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
    public partial class frmViewRosters : Form
    {
        public frmViewRosters()
        {
            InitializeComponent();
        }

        private void frmViewRosters_Load(object sender, EventArgs e)
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
                s.Student_ID,
                s.FirstName,
                s.LastName,
                s.Email,
                c.Course_Number,
                c.Course_Name,
                cs.Section_ID
              FROM Enrollment e
              INNER JOIN Student s
                ON e.Student_ID = s.Student_ID
              INNER JOIN Course_Section cs
                ON e.Section_ID = cs.Section_ID
              INNER JOIN Course c
                ON cs.Course_ID = c.Course_ID
              WHERE cs.Professor_ID = @ProfessorID";

            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@ProfessorID", Session.ProfessorID);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvRoster.DataSource = table;
        }
    }
}
