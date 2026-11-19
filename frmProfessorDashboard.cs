using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University_App
{
    public partial class frmProfessorDashboard : Form
    {
        public frmProfessorDashboard()
        {
            InitializeComponent();
        }

        private void frmProfessorDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCreateSection section = new frmCreateSection();

            section.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMySections sections = new frmMySections();

            sections.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmViewRosters roster = new frmViewRosters();

            roster.ShowDialog();
        }

        private void btnCourseRequests_Click(object sender, EventArgs e)
        {
            frmCourseRequest request = new frmCourseRequest();

            request.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSubmitGrades grades = new frmSubmitGrades();

            grades.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormMain loginForm = new FormMain();

            loginForm.Show();

            this.Close();
        }
    }
}
