namespace University_App
{
    partial class frmStudentDashboard
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
            btnSearchClasses = new Button();
            btnMySchedule = new Button();
            btnMyGrades = new Button();
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
            pnlHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(263, 103);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(148, 37);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "WELCOME";
            lblWelcome.Click += label1_Click;
            // 
            // btnSearchClasses
            // 
            btnSearchClasses.Location = new Point(350, 160);
            btnSearchClasses.Name = "btnSearchClasses";
            btnSearchClasses.Size = new Size(106, 23);
            btnSearchClasses.TabIndex = 3;
            btnSearchClasses.Text = "Search Classes";
            btnSearchClasses.UseVisualStyleBackColor = true;
            btnSearchClasses.Click += btnSearchClasses_Click;
            // 
            // btnMySchedule
            // 
            btnMySchedule.Location = new Point(350, 212);
            btnMySchedule.Name = "btnMySchedule";
            btnMySchedule.Size = new Size(106, 23);
            btnMySchedule.TabIndex = 5;
            btnMySchedule.Text = "My Schedule";
            btnMySchedule.UseVisualStyleBackColor = true;
            btnMySchedule.Click += btnMySchedule_Click;
            // 
            // btnMyGrades
            // 
            btnMyGrades.Location = new Point(350, 267);
            btnMyGrades.Name = "btnMyGrades";
            btnMyGrades.Size = new Size(106, 23);
            btnMyGrades.TabIndex = 6;
            btnMyGrades.Text = "My Grades";
            btnMyGrades.UseVisualStyleBackColor = true;
            btnMyGrades.Click += btnMyGrades_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(350, 320);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(106, 23);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmStudentDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnMyGrades);
            Controls.Add(btnMySchedule);
            Controls.Add(btnSearchClasses);
            Controls.Add(lblWelcome);
            Controls.Add(pnlHeader);
            Name = "frmStudentDashboard";
            Text = "Student Dashboard";
            Load += frmStudentDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblWelcome;
        private Button btnSearchClasses;
        private Button btnMySchedule;
        private Button btnMyGrades;
        private Button btnLogout;
    }
}