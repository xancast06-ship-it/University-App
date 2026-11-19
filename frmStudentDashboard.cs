using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University_App
{
    public partial class frmStudentDashboard : Form
    {
        public frmStudentDashboard()
        {
            InitializeComponent();
        }

        private void frmStudentDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "WELCOME " +
               Session.FirstName + " " +
               Session.LastName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchClasses_Click(object sender, EventArgs e)
        {
            frmSearchClasses searchForm = new frmSearchClasses();

            searchForm.ShowDialog();
        }

        private void btnMySchedule_Click(object sender, EventArgs e)
        {
            frmMySchedule schedule = new frmMySchedule();

            schedule.ShowDialog();
        }

        private void btnMyGrades_Click(object sender, EventArgs e)
        {
            frmMyGrades grades = new frmMyGrades();

            grades.ShowDialog();
        }

        private void btnRegisterClasses_Click(object sender, EventArgs e)
        {
            frmSearchClasses searchForm = new frmSearchClasses();

            searchForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormMain loginForm = new FormMain();

            loginForm.Show();

            this.Close();
        }
    }
}