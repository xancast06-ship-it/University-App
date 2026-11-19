using Microsoft.Data.SqlClient;

namespace University_App
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("Student");
            cmbRole.Items.Add("Professor");
            cmbRole.Items.Add("Personnel");

            cmbRole.SelectedIndex = 0;

            label7.Visible = false;
            txtEmail.Visible = false;
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.Text == "Professor")
            {
                label7.Visible = true;
                txtEmail.Visible = true;
            }
            else
            {
                label7.Visible = false;
                txtEmail.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Login button clicked!");

                string connectionString =
                    @"Server=XanderLaptop;
                        Database=StudentDB;
                        Trusted_Connection=True;
                        TrustServerCertificate=True;";

                if (cmbRole.Text == "Student")
                {
                    using SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();

                    MessageBox.Show("Database connected!");

                    string sql =
                        @"SELECT *
                        FROM Student
                        WHERE Student_ID = @ID
                        AND FirstName = @FirstName
                        AND LastName = @LastName";

                    SqlCommand command = new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@ID", txtID.Text);
                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", txtLastName.Text);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Student Found!");

                        Session.StudentID = Convert.ToInt32(reader["Student_ID"]);

                        Session.FirstName = reader["FirstName"].ToString();

                        Session.LastName = reader["LastName"].ToString();

                        Session.Role = "Student";

                        frmStudentDashboard dashboard = new frmStudentDashboard();

                        dashboard.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Student not found.");
                    }
                }

                else if (cmbRole.Text == "Professor")
                {
                    using SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();

                    string sql =
                    @"SELECT *
                      FROM Professor
                      WHERE Professor_ID = @ID
                      AND FirstName = @FirstName
                      AND LastName = @LastName
                      AND Email = @Email";

                    SqlCommand command = new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@ID", txtID.Text);

                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);

                    command.Parameters.AddWithValue("@LastName", txtLastName.Text);

                    command.Parameters.AddWithValue("@Email", txtEmail.Text);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Session.ProfessorID = Convert.ToInt32(reader["Professor_ID"]);

                        Session.FirstName = reader["FirstName"].ToString();

                        Session.LastName = reader["LastName"].ToString();

                        Session.Role = "Professor";

                        frmProfessorDashboard dashboard = new frmProfessorDashboard();

                        dashboard.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Professor not found.");
                    }
                }

                else if (cmbRole.Text == "Personnel")
                {
                    using SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();

                    string sql =
                    @"SELECT *
                    FROM Personnel
                    WHERE Personnel_ID = @ID
                    AND FirstName = @FirstName
                    AND LastName = @LastName";

                    SqlCommand command = new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@ID", txtID.Text);

                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);

                    command.Parameters.AddWithValue("@LastName", txtLastName.Text);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Session.PersonnelID = Convert.ToInt32(reader["Personnel_ID"]);

                        Session.FirstName = reader["FirstName"].ToString();

                        Session.LastName = reader["LastName"].ToString();

                        Session.Role = "Personnel";

                        frmPersonnelDashboard dashboard = new frmPersonnelDashboard();

                        dashboard.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Personnel record not found.");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}