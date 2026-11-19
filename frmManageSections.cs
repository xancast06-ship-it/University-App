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
    public partial class frmManageSections : Form
    {
        public frmManageSections()
        {
            InitializeComponent();
        }

        private void frmManageSections_Load(object sender, EventArgs e)
        {
            LoadSections();
            LoadCourses();
            LoadProfessors();
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
                c.Course_Number,
                c.Course_Name,
                p.FirstName + ' ' + p.LastName AS Professor,
                cs.Room,
                cs.Semester,
                cs.Year,
                cs.Capacity
              FROM Course_Section cs
              INNER JOIN Course c
                ON cs.Course_ID = c.Course_ID
              INNER JOIN Professor p
                ON cs.Professor_ID = p.Professor_ID
              ORDER BY cs.Section_ID";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvSections.DataSource = table;
        }

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

        private void LoadCourses()
        {
            string connectionString =
                @"Server=XanderLaptop;
                  Database=StudentDB;
                  Trusted_Connection=True;
                  TrustServerCertificate=True;";

            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string sql =
                @"SELECT Course_ID,
                         Course_Name
                  FROM Course";

            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            cmbCourse.Items.Clear();

            while (reader.Read())
            {
                cmbCourse.Items.Add(new ComboBoxItem(reader["Course_Name"].ToString(),
                        Convert.ToInt32(reader["Course_ID"])));
            }
        }

        private void LoadProfessors()
        {
            string connectionString =
                @"Server=XanderLaptop;
                  Database=StudentDB;
                  Trusted_Connection=True;
                  TrustServerCertificate=True;";

            using SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            string sql =
                @"SELECT Professor_ID,
                         FirstName,
                         LastName
                  FROM Professor";

            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            cmbProfessor.Items.Clear();

            while (reader.Read())
            {
                cmbProfessor.Items.Add(new ComboBoxItem(reader["FirstName"] + " " +
                        reader["LastName"], Convert.ToInt32(reader["Professor_ID"])));
            }
        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem course = (ComboBoxItem)cmbCourse.SelectedItem;

                ComboBoxItem professor = (ComboBoxItem)cmbProfessor.SelectedItem;

                string connectionString =
                    @"Server=XanderLaptop;
                      Database=StudentDB;
                      Trusted_Connection=True;
                      TrustServerCertificate=True;";

                using SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                string sql =
                @"INSERT INTO Course_Section
                    (
                        Course_ID,
                        Professor_ID,
                        Room,
                        Semester,
                        Year,
                        Capacity
                    )
                  VALUES
                    (
                        @CourseID,
                        @ProfessorID,
                        @Room,
                        @Semester,
                        @Year,
                        @Capacity
                    )";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@CourseID", course.Value);

                command.Parameters.AddWithValue("@ProfessorID", professor.Value);

                command.Parameters.AddWithValue("@Room", txtRoom.Text);

                command.Parameters.AddWithValue("@Semester", txtSemester.Text);

                command.Parameters.AddWithValue("@Year", Convert.ToInt32(txtYear.Text));

                command.Parameters.AddWithValue("@Capacity", Convert.ToInt32(txtCapacity.Text));

                command.ExecuteNonQuery();

                MessageBox.Show("Section created successfully.");

                LoadSections();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteSection_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSections.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a section.");

                    return;
                }

                int sectionID = Convert.ToInt32(dgvSections.SelectedRows[0].Cells["Section_ID"].Value);

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
                  WHERE Section_ID = @SectionID";

                SqlCommand checkCommand = new SqlCommand(checkSql, connection);

                checkCommand.Parameters.AddWithValue("@SectionID", sectionID);

                int enrollmentCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (enrollmentCount > 0)
                {
                    MessageBox.Show("This section cannot be deleted because students are enrolled.");

                    return;
                }

                string deleteSql =
                @"DELETE FROM Course_Section
                WHERE Section_ID = @SectionID";

                SqlCommand deleteCommand = new SqlCommand(deleteSql, connection);

                deleteCommand.Parameters.AddWithValue("@SectionID", sectionID);

                deleteCommand.ExecuteNonQuery();

                MessageBox.Show("Section deleted successfully.");

                LoadSections();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
