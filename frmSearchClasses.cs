using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_App
{
    public partial class frmSearchClasses : Form
    {
        public frmSearchClasses()
        {
            InitializeComponent();
        }

        private void frmSearchClasses_Load(object sender, EventArgs e)
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
                p.FirstName + ' ' + p.LastName AS Professor,
                cs.Room,
                cs.Capacity
            FROM Course_Section cs
            JOIN Course c
                ON cs.Course_ID = c.Course_ID
            JOIN Professor p
                ON cs.Professor_ID = p.Professor_ID";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvClasses.DataSource = table;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClasses.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a class.");

                    return;
                }

                int sectionID = Convert.ToInt32(dgvClasses.SelectedRows[0].Cells["Section_ID"].Value);

                string connectionString =
                    @"Server=XanderLaptop;
                      Database=StudentDB;
                      Trusted_Connection=True;
                      TrustServerCertificate=True;";

                using SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                // Check for duplicate enrollment
                string checkSql =
                @"SELECT COUNT(*)
                  FROM Enrollment
                  WHERE Student_ID = @StudentID
                  AND Section_ID = @SectionID";

                SqlCommand checkCommand = new SqlCommand(checkSql, connection);

                checkCommand.Parameters.AddWithValue("@StudentID", Session.StudentID);

                checkCommand.Parameters.AddWithValue("@SectionID", sectionID);

                int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (existingCount > 0)
                {
                    MessageBox.Show("You are already enrolled in this class.");

                    return;
                }

                string sql =
                @"INSERT INTO Enrollment
                (
                    Enrollment_ID,
                    Student_ID,
                    Section_ID,
                    Enrollment_Date,
                    Status
                )
                VALUES
                (
                    (SELECT ISNULL(MAX(Enrollment_ID),0)+1
                     FROM Enrollment),
                    @StudentID,
                    @SectionID,
                    '2026-11-16',
                    'Active'
                )";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@StudentID", Session.StudentID);

                command.Parameters.AddWithValue("@SectionID", sectionID);

                command.ExecuteNonQuery();

                MessageBox.Show("Registration Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvClasses.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a class.");

                    return;
                }

                int sectionID = Convert.ToInt32(dgvClasses.SelectedRows[0].Cells["Section_ID"].Value);

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
                  WHERE Student_ID = @StudentID
                  AND Section_ID = @SectionID";

                SqlCommand checkCommand = new SqlCommand(checkSql, connection);

                checkCommand.Parameters.AddWithValue("@StudentID", Session.StudentID);

                checkCommand.Parameters.AddWithValue("@SectionID", sectionID);

                int existingCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (existingCount > 0)
                {
                    MessageBox.Show("You are already enrolled in this class.");

                    return;
                }

                string insertSql =
                @"INSERT INTO Enrollment
                (
                    Enrollment_ID,
                    Student_ID,
                    Section_ID,
                    Enrollment_Date,
                    Status
                )
                VALUES
                (
                    (SELECT ISNULL(MAX(Enrollment_ID),0)+1
                        FROM Enrollment),
                    @StudentID,
                    @SectionID,
                    GETDATE(),
                    'Active'
                )";

                SqlCommand insertCommand = new SqlCommand(insertSql, connection);

                insertCommand.Parameters.AddWithValue("@StudentID", Session.StudentID);

                insertCommand.Parameters.AddWithValue("@SectionID", sectionID);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Registration Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
