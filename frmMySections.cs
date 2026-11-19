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
    public partial class frmMySections : Form
    {
        public frmMySections()
        {
            InitializeComponent();
        }

        private void frmMySections_Load(object sender, EventArgs e)
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
                cs.Section_ID,
                c.Course_Number,
                c.Course_Name,
                cs.Room,
                cs.Semester,
                cs.Year
              FROM Course_Section cs
              INNER JOIN Course c
                ON cs.Course_ID = c.Course_ID
              WHERE cs.Professor_ID = @ProfessorID";

            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@ProfessorID", Session.ProfessorID);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvSections.DataSource = table;
        }

    }
}
