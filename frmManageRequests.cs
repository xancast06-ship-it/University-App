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
    public partial class frmManageRequests : Form
    {
        public frmManageRequests()
        {
            InitializeComponent();
        }

        private void frmManageRequests_Load(object sender, EventArgs e)
        {
            LoadRequests();
        }
        private void LoadRequests()
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
                Request_ID,
                Professor_ID,
                Course_Name,
                Credits,
                Reason,
                Status
              FROM Course_Request
              ORDER BY Request_ID";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

            DataTable table = new DataTable();

            adapter.Fill(table);

            dgvRequests.DataSource = table;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRequests.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a request.");

                    return;
                }

                int requestID = Convert.ToInt32(dgvRequests.SelectedRows[0].Cells["Request_ID"].Value);

                string connectionString =
                    @"Server=XanderLaptop;
                      Database=StudentDB;
                      Trusted_Connection=True;
                      TrustServerCertificate=True;";

                using SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                string sql =
                @"UPDATE Course_Request
                SET Status = 'Approved'
                WHERE Request_ID = @RequestID";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@RequestID", requestID);

                command.ExecuteNonQuery();

                MessageBox.Show("Request Approved.");

                LoadRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRequests.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a request.");

                    return;
                }

                int requestID = Convert.ToInt32(dgvRequests.SelectedRows[0].Cells["Request_ID"].Value);

                string connectionString =
                    @"Server=XanderLaptop;
                      Database=StudentDB;
                      Trusted_Connection=True;
                      TrustServerCertificate=True;";

                using SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                string sql =
                @"UPDATE Course_Request
                  SET Status = 'Denied'
                  WHERE Request_ID = @RequestID";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@RequestID", requestID);

                command.ExecuteNonQuery();

                MessageBox.Show("Request Denied.");

                LoadRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
