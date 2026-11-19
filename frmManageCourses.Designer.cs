namespace University_App
{
    partial class frmManageCourses
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
            dgvCourses = new DataGridView();
            btnAddCourse = new Button();
            btnDeleteCourse = new Button();
            txtCourseNumber = new TextBox();
            txtCourseName = new TextBox();
            txtCredits = new TextBox();
            txtDepartment = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
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
            // dgvCourses
            // 
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(21, 165);
            dgvCourses.MultiSelect = false;
            dgvCourses.Name = "dgvCourses";
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.Size = new Size(492, 194);
            dgvCourses.TabIndex = 5;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(21, 365);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(75, 23);
            btnAddCourse.TabIndex = 6;
            btnAddCourse.Text = "Add";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // btnDeleteCourse
            // 
            btnDeleteCourse.Location = new Point(102, 365);
            btnDeleteCourse.Name = "btnDeleteCourse";
            btnDeleteCourse.Size = new Size(75, 23);
            btnDeleteCourse.TabIndex = 7;
            btnDeleteCourse.Text = "Delete";
            btnDeleteCourse.UseVisualStyleBackColor = true;
            btnDeleteCourse.Click += btnDeleteCourse_Click;
            // 
            // txtCourseNumber
            // 
            txtCourseNumber.Location = new Point(546, 180);
            txtCourseNumber.Name = "txtCourseNumber";
            txtCourseNumber.Size = new Size(222, 23);
            txtCourseNumber.TabIndex = 8;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(546, 233);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(222, 23);
            txtCourseName.TabIndex = 9;
            // 
            // txtCredits
            // 
            txtCredits.Location = new Point(546, 287);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(222, 23);
            txtCredits.TabIndex = 10;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(546, 340);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(222, 23);
            txtDepartment.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(549, 162);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 12;
            label1.Text = "Course Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(549, 215);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 13;
            label2.Text = "Course Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(569, 269);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 14;
            label3.Text = "Credits:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(555, 322);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 15;
            label4.Text = "Department:";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(183, 365);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // frmManageCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDepartment);
            Controls.Add(txtCredits);
            Controls.Add(txtCourseName);
            Controls.Add(txtCourseNumber);
            Controls.Add(btnDeleteCourse);
            Controls.Add(btnAddCourse);
            Controls.Add(dgvCourses);
            Controls.Add(pnlHeader);
            Name = "frmManageCourses";
            Text = "Manage Courses";
            Load += frmManageCourses_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private DataGridView dgvCourses;
        private Button btnAddCourse;
        private Button btnDeleteCourse;
        private TextBox txtCourseNumber;
        private TextBox txtCourseName;
        private TextBox txtCredits;
        private TextBox txtDepartment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRefresh;
    }
}