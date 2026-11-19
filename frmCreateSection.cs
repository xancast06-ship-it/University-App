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
    public partial class frmCreateSection : Form
    {
        public frmCreateSection()
        {
            InitializeComponent();
        }

        private void frmCreateSection_Load(object sender, EventArgs e)
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

            while (reader.Read())
            {
                cmbCourse.Items.Add(new ComboBoxItem(reader["Course_Name"].ToString(),
                        Convert.ToInt32(reader["Course_ID"])));
            }
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

        private void btnCreateSection_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBoxItem course = (ComboBoxItem)cmbCourse.SelectedItem;

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

                command.Parameters.AddWithValue("@ProfessorID", Session.ProfessorID);

                command.Parameters.AddWithValue("@Room", txtRoom.Text);

                command.Parameters.AddWithValue("@Semester", txtSemester.Text);

                command.Parameters.AddWithValue("@Year", Convert.ToInt32(txtYear.Text));

                command.Parameters.AddWithValue("@Capacity", Convert.ToInt32(txtCapacity.Text));

                command.ExecuteNonQuery();

                MessageBox.Show("Section created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
