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
    public partial class frmManageEnrollment : Form
    {
        public frmManageEnrollment()
        {
            InitializeComponent();
        }

        private void frmManageEnrollment_Load(object sender, EventArgs e)
        {
            LoadEnrollment();
            LoadStudents();
            LoadSections();
        }

        private void LoadEnrollment()
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
                s.FirstName + ' ' + s.LastName AS Student,
                c.Course_Name,
                e.Enrollment_Date,
                e.Status
              FROM Enrollment e
              INNER JOIN Student s
                ON e.Student_ID = s.Student_ID
              INNER JOIN Course_Section cs
                ON e.Section_ID = cs.Section_ID
              INNER JOIN Course c
                ON cs.Course_ID = c.Course_ID
              ORDER BY e.Enrollment_ID";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvEnrollment.DataSource = table;
        }

        private void LoadStudents()
        {
            string connectionString =
                @"Server=XanderLaptop;
                  Database=StudentDB;
                  Trusted_Connection=True;
                  TrustServerCertificate=True;";

            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string sql =
                @"SELECT Student_ID,
                         FirstName,
                         LastName
                  FROM Student";

            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            cmbStudents.Items.Clear();

            while (reader.Read())
            {
                cmbStudents.Items.Add(new ComboBoxItem(reader["FirstName"] + " " +
                        reader["LastName"], Convert.ToInt32(reader["Student_ID"])));
            }
        }

        private void LoadSections()
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
                c.Course_Name
              FROM Course_Section cs
              INNER JOIN Course c
                ON cs.Course_ID = c.Course_ID";

            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            cmbSections.Items.Clear();

            while (reader.Read())
            {
                cmbSections.Items.Add(new ComboBoxItem(reader["Course_Name"].ToString(),
                        Convert.ToInt32(reader["Section_ID"])));
            }
        }

    private void btnAddEnrollment_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbStudents.SelectedItem == null)
                {
                    MessageBox.Show("Please select a student.");

                    return;
                }

                if (cmbSections.SelectedItem == null)
                {
                    MessageBox.Show("Please select a section.");

                    return;
                }

                ComboBoxItem student = (ComboBoxItem)cmbStudents.SelectedItem;

                ComboBoxItem section = (ComboBoxItem)cmbSections.SelectedItem;

                string connectionString =
                    @"Server=XanderLaptop;
                      Database=StudentDB;
                      Trusted_Connection=True;
                      TrustServerCertificate=True;";

                using SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                // Duplicate check

                string duplicateSql =
                @"SELECT COUNT(*)
                  FROM Enrollment
                  WHERE Student_ID = @StudentID
                  AND Section_ID = @SectionID";

                SqlCommand duplicateCommand = new SqlCommand(duplicateSql, connection);

                duplicateCommand.Parameters.AddWithValue("@StudentID", student.Value);

                duplicateCommand.Parameters.AddWithValue("@SectionID", section.Value);

                int duplicateCount = Convert.ToInt32(duplicateCommand.ExecuteScalar());

                if (duplicateCount > 0)
                {
                    MessageBox.Show("Student is already enrolled in this section.");

                    return;
                }

                // Capacity Check

                string capacitySql =
                @"SELECT Capacity
                  FROM Course_Section
                  WHERE Section_ID = @SectionID";

                SqlCommand capacityCommand = new SqlCommand(capacitySql, connection);

                capacityCommand.Parameters.AddWithValue("@SectionID", section.Value);

                int capacity = Convert.ToInt32(capacityCommand.ExecuteScalar());

                string countSql =
                @"SELECT COUNT(*)
                  FROM Enrollment
                  WHERE Section_ID = @SectionID";

                SqlCommand countCommand = new SqlCommand(countSql, connection);

                countCommand.Parameters.AddWithValue("@SectionID", section.Value);

                int currentEnrollment = Convert.ToInt32(countCommand.ExecuteScalar());

                if (currentEnrollment >= capacity)
                {
                    MessageBox.Show("This section is already full.");

                    return;
                }

                // Insert Enrollment

                string insertSql =
                @"INSERT INTO Enrollment
                    (
                        Student_ID,
                        Section_ID,
                        Enrollment_Date,
                        Status
                    )
                    VALUES
                    (
                        @StudentID,
                        @SectionID,
                        GETDATE(),
                        'Active'
                    )";

                SqlCommand insertCommand = new SqlCommand(insertSql, connection);

                insertCommand.Parameters.AddWithValue("@StudentID", student.Value);

                insertCommand.Parameters.AddWithValue("@SectionID", section.Value);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Enrollment added successfully.");

                LoadEnrollment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message);
            }
        }

        private void btnDeleteEnrollment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEnrollment.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an enrollment.");

                    return;
                }

                int enrollmentID = Convert.ToInt32(dgvEnrollment.SelectedRows[0].Cells["Enrollment_ID"].Value);

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
                    MessageBox.Show("This enrollment cannot be deleted because grades are assigned.");

                    return;
                }

                string deleteSql =
                @"DELETE FROM Enrollment
                WHERE Enrollment_ID = @EnrollmentID";

                SqlCommand deleteCommand = new SqlCommand(deleteSql, connection);

                deleteCommand.Parameters.AddWithValue("@EnrollmentID", enrollmentID);

                deleteCommand.ExecuteNonQuery();

                MessageBox.Show("Enrollment deleted successfully.");

                LoadEnrollment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

namespace University_App
{
    public class ComboBoxItem
    {
        public string Text { get; set; }

        public int Value { get; set; }

        public ComboBoxItem(
            string text,
            int value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
