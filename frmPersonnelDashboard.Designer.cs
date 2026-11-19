namespace University_App
{
    partial class frmPersonnelDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblWelcome = new Label();
            btnManageSections = new Button();
            btnManageEnrollment = new Button();
            btnManageCourses = new Button();
            button3 = new Button();
            btnManageProfessors = new Button();
            btnManageStudents = new Button();
            button7 = new Button();
            btnCourseRequests = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DarkBlue;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 100);
            pnlHeader.TabIndex = 3;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(252, 103);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(155, 37);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "WELCOME ";
            // 
            // btnManageSections
            // 
            btnManageSections.Location = new Point(252, 250);
            btnManageSections.Name = "btnManageSections";
            btnManageSections.Size = new Size(152, 23);
            btnManageSections.TabIndex = 19;
            btnManageSections.Text = "Manage Sections";
            btnManageSections.UseVisualStyleBackColor = true;
            btnManageSections.Click += btnManageSections_Click;
            // 
            // btnManageEnrollment
            // 
            btnManageEnrollment.Location = new Point(423, 250);
            btnManageEnrollment.Name = "btnManageEnrollment";
            btnManageEnrollment.Size = new Size(162, 23);
            btnManageEnrollment.TabIndex = 18;
            btnManageEnrollment.Text = "Manage Enrollment";
            btnManageEnrollment.UseVisualStyleBackColor = true;
            btnManageEnrollment.Click += btnManageEnrollment_Click;
            // 
            // btnManageCourses
            // 
            btnManageCourses.Location = new Point(423, 207);
            btnManageCourses.Name = "btnManageCourses";
            btnManageCourses.Size = new Size(162, 23);
            btnManageCourses.TabIndex = 17;
            btnManageCourses.Text = "Manage Courses";
            btnManageCourses.UseVisualStyleBackColor = true;
            btnManageCourses.Click += btnManageCourses_Click;
            // 
            // button3
            // 
            button3.Location = new Point(252, 207);
            button3.Name = "button3";
            button3.Size = new Size(152, 23);
            button3.TabIndex = 16;
            button3.Text = "Manage Personnel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnManageProfessors
            // 
            btnManageProfessors.Location = new Point(423, 166);
            btnManageProfessors.Name = "btnManageProfessors";
            btnManageProfessors.Size = new Size(162, 23);
            btnManageProfessors.TabIndex = 15;
            btnManageProfessors.Text = "Manage Professors";
            btnManageProfessors.UseVisualStyleBackColor = true;
            btnManageProfessors.Click += btnManageProfessors_Click;
            // 
            // btnManageStudents
            // 
            btnManageStudents.Location = new Point(252, 166);
            btnManageStudents.Name = "btnManageStudents";
            btnManageStudents.Size = new Size(152, 23);
            btnManageStudents.TabIndex = 14;
            btnManageStudents.Text = "Manage Students";
            btnManageStudents.UseVisualStyleBackColor = true;
            btnManageStudents.Click += btnManageStudents_Click;
            // 
            // button7
            // 
            button7.Location = new Point(252, 295);
            button7.Name = "button7";
            button7.Size = new Size(152, 23);
            button7.TabIndex = 20;
            button7.Text = "Manage Grades";
            button7.UseVisualStyleBackColor = true;
            // 
            // btnCourseRequests
            // 
            btnCourseRequests.Location = new Point(423, 295);
            btnCourseRequests.Name = "btnCourseRequests";
            btnCourseRequests.Size = new Size(162, 23);
            btnCourseRequests.TabIndex = 21;
            btnCourseRequests.Text = "Course Requests";
            btnCourseRequests.UseVisualStyleBackColor = true;
            btnCourseRequests.Click += btnCourseRequests_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(252, 339);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(152, 23);
            btnReports.TabIndex = 22;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(423, 339);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(162, 23);
            btnLogout.TabIndex = 23;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmPersonnelDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnReports);
            Controls.Add(btnCourseRequests);
            Controls.Add(button7);
            Controls.Add(btnManageSections);
            Controls.Add(btnManageEnrollment);
            Controls.Add(btnManageCourses);
            Controls.Add(button3);
            Controls.Add(btnManageProfessors);
            Controls.Add(btnManageStudents);
            Controls.Add(lblWelcome);
            Controls.Add(pnlHeader);
            Name = "frmPersonnelDashboard";
            Text = "Personnel Dashboard";
            Load += frmPersonnelDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblWelcome;
        private Button btnManageSections;
        private Button btnManageEnrollment;
        private Button btnManageCourses;
        private Button button3;
        private Button btnManageProfessors;
        private Button btnManageStudents;
        private Button button7;
        private Button btnCourseRequests;
        private Button btnReports;
        private Button btnLogout;
    }
}