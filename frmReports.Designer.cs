namespace University_App
{
    partial class frmReports
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
            this.lblStudents = new Label();
            this.lblProfessors = new Label();
            this.lblPersonnel = new Label();
            this.lblCourses = new Label();
            this.lblSections = new Label();
            this.lblEnrollments = new Label();
            this.lblGrades = new Label();
            this.lblPending = new Label();
            this.lblApproved = new Label();
            lblDenied = new Label();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DarkBlue;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 100);
            pnlHeader.TabIndex = 4;
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new Point(43, 131);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new Size(56, 15);
            this.lblStudents.TabIndex = 5;
            this.lblStudents.Text = "Students:";
            // 
            // lblProfessors
            // 
            this.lblProfessors.AutoSize = true;
            this.lblProfessors.Location = new Point(43, 156);
            this.lblProfessors.Name = "lblProfessors";
            this.lblProfessors.Size = new Size(64, 15);
            this.lblProfessors.TabIndex = 6;
            this.lblProfessors.Text = "Professors:";
            // 
            // lblPersonnel
            // 
            this.lblPersonnel.AutoSize = true;
            this.lblPersonnel.Location = new Point(43, 181);
            this.lblPersonnel.Name = "lblPersonnel";
            this.lblPersonnel.Size = new Size(65, 15);
            this.lblPersonnel.TabIndex = 7;
            this.lblPersonnel.Text = "Personnel: ";
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new Point(43, 208);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new Size(55, 15);
            this.lblCourses.TabIndex = 8;
            this.lblCourses.Text = "Courses: ";
            // 
            // lblSections
            // 
            this.lblSections.AutoSize = true;
            this.lblSections.Location = new Point(43, 236);
            this.lblSections.Name = "lblSections";
            this.lblSections.Size = new Size(57, 15);
            this.lblSections.TabIndex = 9;
            this.lblSections.Text = "Sections: ";
            // 
            // lblEnrollments
            // 
            this.lblEnrollments.AutoSize = true;
            this.lblEnrollments.Location = new Point(43, 261);
            this.lblEnrollments.Name = "lblEnrollments";
            this.lblEnrollments.Size = new Size(76, 15);
            this.lblEnrollments.TabIndex = 10;
            this.lblEnrollments.Text = "Enrollments: ";
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.Location = new Point(43, 287);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new Size(46, 15);
            this.lblGrades.TabIndex = 11;
            this.lblGrades.Text = "Grades:";
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Location = new Point(43, 312);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new Size(107, 15);
            this.lblPending.TabIndex = 12;
            this.lblPending.Text = "Pending Requests: ";
            // 
            // lblApproved
            // 
            this.lblApproved.AutoSize = true;
            this.lblApproved.Location = new Point(43, 337);
            this.lblApproved.Name = "lblApproved";
            this.lblApproved.Size = new Size(115, 15);
            this.lblApproved.TabIndex = 13;
            this.lblApproved.Text = "Approved Requests: ";
            // 
            // lblDenied
            // 
            lblDenied.AutoSize = true;
            lblDenied.Location = new Point(43, 362);
            lblDenied.Name = "lblDenied";
            lblDenied.Size = new Size(100, 15);
            lblDenied.TabIndex = 14;
            lblDenied.Text = "Denied Requests: ";
            // 
            // frmReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDenied);
            Controls.Add(this.lblApproved);
            Controls.Add(this.lblPending);
            Controls.Add(this.lblGrades);
            Controls.Add(this.lblEnrollments);
            Controls.Add(this.lblSections);
            Controls.Add(this.lblCourses);
            Controls.Add(this.lblPersonnel);
            Controls.Add(this.lblProfessors);
            Controls.Add(this.lblStudents);
            Controls.Add(pnlHeader);
            Name = "frmReports";
            Text = "frmReports";
            Load += frmReports_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblStudents;
        private Label lblProfessors;
        private Label lblPersonnel;
        private Label lblCourses;
        private Label lblSections;
        private Label lblEnrollments;
        private Label lblGrades;
        private Label lblPending;
        private Label lblApproved;
        private Label lblDenied;
    }
}