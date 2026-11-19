namespace University_App
{
    partial class frmManageStudents
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
            dgvStudents = new DataGridView();
            txtStudentID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtMajor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAddStudent = new Button();
            btnDeleteStudent = new Button();
            btnRefresh = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
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
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(22, 159);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(544, 221);
            dgvStudents.TabIndex = 5;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(587, 178);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(201, 23);
            txtStudentID.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(586, 222);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(202, 23);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(584, 265);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(204, 23);
            txtLastName.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(588, 310);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtMajor
            // 
            txtMajor.Location = new Point(586, 357);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(202, 23);
            txtMajor.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(589, 159);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 11;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(589, 207);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 12;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(585, 248);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 13;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(586, 294);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 14;
            label4.Text = "Email: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(590, 343);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 15;
            label5.Text = "Major:";
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(22, 387);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(75, 23);
            btnAddStudent.TabIndex = 16;
            btnAddStudent.Text = "Add";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(103, 386);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(75, 23);
            btnDeleteStudent.TabIndex = 17;
            btnDeleteStudent.Text = "Delete";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(187, 386);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(292, 103);
            label6.Name = "label6";
            label6.Size = new Size(240, 37);
            label6.TabIndex = 19;
            label6.Text = "Manage Students";
            // 
            // frmManageStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMajor);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtStudentID);
            Controls.Add(dgvStudents);
            Controls.Add(pnlHeader);
            Name = "frmManageStudents";
            Text = "Manage Students";
            Load += frmManageStudents_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private DataGridView dgvStudents;
        private TextBox txtStudentID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtMajor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAddStudent;
        private Button btnDeleteStudent;
        private Button btnRefresh;
        private Label label6;
    }
}