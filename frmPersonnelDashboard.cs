using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University_App
{
    public partial class frmPersonnelDashboard : Form
    {
        public frmPersonnelDashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmPersonnelDashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "WELCOME " + Session.FirstName.ToUpper() +
                " " + Session.LastName.ToUpper();
        }

        private void btnCourseRequests_Click(object sender, EventArgs e)
        {
            frmManageRequests requests = new frmManageRequests();

            requests.ShowDialog();
        }

        private void btnManageCourses_Click(object sender, EventArgs e)
        {
            frmManageCourses courses = new frmManageCourses();

            courses.ShowDialog();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            frmManageStudents students = new frmManageStudents();

            students.ShowDialog();
        }

        private void btnManageProfessors_Click(object sender, EventArgs e)
        {
            frmManageProfessors professors = new frmManageProfessors();

            professors.ShowDialog();
        }

        private void btnManageSections_Click(object sender, EventArgs e)
        {
            frmManageSections sections = new frmManageSections();

            sections.ShowDialog();
        }

        private void btnManageEnrollment_Click(object sender, EventArgs e)
        {
            frmManageEnrollment enrollment = new frmManageEnrollment();

            enrollment.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports reports = new frmReports();

            reports.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormMain loginForm = new FormMain();

            loginForm.Show();

            this.Close();
        }
    }
}
