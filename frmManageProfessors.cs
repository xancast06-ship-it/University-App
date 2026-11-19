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
    public partial class frmManageProfessors : Form
    {
        public frmManageProfessors()
        {
            InitializeComponent();
        }

        private void frmManageProfessors_Load(object sender, EventArgs e)
        {
            LoadProfessors();
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
                @"SELECT *
                  FROM Professor
                  ORDER BY Professor_ID";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvProfessors.DataSource = table;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProfessors();
        }

        private void btnAddProfessor_Click(object sender, EventArgs e)
        {
            try
            {
                int professorID = Convert.ToInt32(txtProfessorID.Text);

                string firstName = txtFirstName.Text.Trim();

                string lastName = txtLastName.Text.Trim();

                string email = txtEmail.Text.Trim();

                string department = txtDepartment.Text.Trim();

                string connectionString =
                    @"Server=XanderLaptop;
                      Database=StudentDB;
                      Trusted_Connection=True;
                      TrustServerCertificate=True;";

                using SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                string checkSql =
                @"SELECT COUNT(*)
                  FROM Professor
                  WHERE Professor_ID = @ProfessorID";

                SqlCommand checkCommand = new SqlCommand(checkSql, connection);

                checkCommand.Parameters.AddWithValue("@ProfessorID", professorID);

                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Professor ID already exists.");

                    return;
                }

                string insertSql =
                @"INSERT INTO Professor
                    (
                        Professor_ID,
                        FirstName,
                        LastName,
                        Email,
                        Department
                    )
                  VALUES
                    (
                        @ProfessorID,
                        @FirstName,
                        @LastName,
                        @Email,
                        @Department
                    )";

                SqlCommand insertCommand = new SqlCommand(insertSql, connection);

                insertCommand.Parameters.AddWithValue("@ProfessorID", professorID);

                insertCommand.Parameters.AddWithValue("@FirstName", firstName);

                insertCommand.Parameters.AddWithValue("@LastName", lastName);

                insertCommand.Parameters.AddWithValue("@Email", email);

                insertCommand.Parameters.AddWithValue("@Department", department);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Professor added successfully.");

                LoadProfessors();

                txtProfessorID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtEmail.Clear();
                txtDepartment.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteProfessor_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProfessors.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a professor.");

                    return;
                }

                int professorID = Convert.ToInt32(dgvProfessors.SelectedRows[0].Cells["Professor_ID"].Value);

                string connectionString =
                    @"Server=XanderLaptop;
                      Database=StudentDB;
                      Trusted_Connection=True;
                      TrustServerCertificate=True;";

                using SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                string checkSql =
                @"SELECT COUNT(*)
                  FROM Course_Section
                  WHERE Professor_ID = @ProfessorID";

                SqlCommand checkCommand = new SqlCommand(checkSql, connection);

                checkCommand.Parameters.AddWithValue("@ProfessorID", professorID);

                int sectionCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (sectionCount > 0)
                {
                    MessageBox.Show("This professor cannot be deleted because sections are assigned to them.");

                    return;
                }

                string deleteSql =
                @"DELETE FROM Professor
                WHERE Professor_ID = @ProfessorID";

                SqlCommand deleteCommand = new SqlCommand(deleteSql, connection);

                deleteCommand.Parameters.AddWithValue("@ProfessorID", professorID);

                deleteCommand.ExecuteNonQuery();

                MessageBox.Show("Professor deleted successfully.");

                LoadProfessors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
