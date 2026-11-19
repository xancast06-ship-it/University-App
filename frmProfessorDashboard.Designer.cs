namespace University_App
{
    partial class frmProfessorDashboard
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
            label1 = new Label();
            btnLogout = new Button();
            button4 = new Button();
            btnViewRosters = new Button();
            button2 = new Button();
            btnMySections = new Button();
            btnCourseRequests = new Button();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DarkBlue;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 100);
            pnlHeader.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 103);
            label1.Name = "label1";
            label1.Size = new Size(306, 37);
            label1.TabIndex = 3;
            label1.Text = "WELCOME PROFESSOR";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(394, 276);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(106, 23);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // button4
            // 
            button4.Location = new Point(394, 233);
            button4.Name = "button4";
            button4.Size = new Size(106, 23);
            button4.TabIndex = 11;
            button4.Text = "Submit Grades";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnViewRosters
            // 
            btnViewRosters.Location = new Point(269, 233);
            btnViewRosters.Name = "btnViewRosters";
            btnViewRosters.Size = new Size(106, 23);
            btnViewRosters.TabIndex = 10;
            btnViewRosters.Text = "View Rosters";
            btnViewRosters.UseVisualStyleBackColor = true;
            btnViewRosters.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(394, 192);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 9;
            button2.Text = "Create Section";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnMySections
            // 
            btnMySections.Location = new Point(269, 192);
            btnMySections.Name = "btnMySections";
            btnMySections.Size = new Size(106, 23);
            btnMySections.TabIndex = 8;
            btnMySections.Text = "My Sections";
            btnMySections.UseVisualStyleBackColor = true;
            btnMySections.Click += button1_Click;
            // 
            // btnCourseRequests
            // 
            btnCourseRequests.Location = new Point(269, 276);
            btnCourseRequests.Name = "btnCourseRequests";
            btnCourseRequests.Size = new Size(106, 23);
            btnCourseRequests.TabIndex = 13;
            btnCourseRequests.Text = "Course Requests";
            btnCourseRequests.UseVisualStyleBackColor = true;
            btnCourseRequests.Click += btnCourseRequests_Click;
            // 
            // frmProfessorDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCourseRequests);
            Controls.Add(btnLogout);
            Controls.Add(button4);
            Controls.Add(btnViewRosters);
            Controls.Add(button2);
            Controls.Add(btnMySections);
            Controls.Add(label1);
            Controls.Add(pnlHeader);
            Name = "frmProfessorDashboard";
            Text = "Professor Dashboard";
            Load += frmProfessorDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Button btnLogout;
        private Button button4;
        private Button btnViewRosters;
        private Button button2;
        private Button btnMySections;
        private Button btnCourseRequests;
    }
}