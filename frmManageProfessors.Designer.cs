namespace University_App
{
    partial class frmManageProfessors
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
            dgvProfessors = new DataGridView();
            txtProfessorID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtDepartment = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAddProfessor = new Button();
            btnDeleteProfessor = new Button();
            btnRefresh = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProfessors).BeginInit();
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
            // dgvProfessors
            // 
            dgvProfessors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfessors.Location = new Point(12, 143);
            dgvProfessors.MultiSelect = false;
            dgvProfessors.Name = "dgvProfessors";
            dgvProfessors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProfessors.Size = new Size(555, 213);
            dgvProfessors.TabIndex = 5;
            // 
            // txtProfessorID
            // 
            txtProfessorID.Location = new Point(574, 162);
            txtProfessorID.Name = "txtProfessorID";
            txtProfessorID.Size = new Size(194, 23);
            txtProfessorID.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(573, 199);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(194, 23);
            txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(573, 243);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(194, 23);
            txtLastName.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(574, 287);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(573, 331);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(194, 23);
            txtDepartment.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(576, 143);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 12;
            label1.Text = "Professor ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(578, 188);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 13;
            label2.Text = "First Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(578, 225);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 14;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(576, 269);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 15;
            label4.Text = "Email: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(573, 313);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 16;
            label5.Text = "Department:";
            // 
            // btnAddProfessor
            // 
            btnAddProfessor.Location = new Point(12, 362);
            btnAddProfessor.Name = "btnAddProfessor";
            btnAddProfessor.Size = new Size(75, 23);
            btnAddProfessor.TabIndex = 17;
            btnAddProfessor.Text = "Add";
            btnAddProfessor.UseVisualStyleBackColor = true;
            btnAddProfessor.Click += btnAddProfessor_Click;
            // 
            // btnDeleteProfessor
            // 
            btnDeleteProfessor.Location = new Point(93, 362);
            btnDeleteProfessor.Name = "btnDeleteProfessor";
            btnDeleteProfessor.Size = new Size(75, 23);
            btnDeleteProfessor.TabIndex = 18;
            btnDeleteProfessor.Text = "Delete";
            btnDeleteProfessor.UseVisualStyleBackColor = true;
            btnDeleteProfessor.Click += btnDeleteProfessor_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(174, 362);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 19;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(291, 103);
            label6.Name = "label6";
            label6.Size = new Size(262, 37);
            label6.TabIndex = 20;
            label6.Text = "Manage Professors";
            // 
            // frmManageProfessors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeleteProfessor);
            Controls.Add(btnAddProfessor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDepartment);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtProfessorID);
            Controls.Add(dgvProfessors);
            Controls.Add(pnlHeader);
            Name = "frmManageProfessors";
            Text = "frmManageProfessors";
            Load += frmManageProfessors_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProfessors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private DataGridView dgvProfessors;
        private TextBox txtProfessorID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtDepartment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAddProfessor;
        private Button btnDeleteProfessor;
        private Button btnRefresh;
        private Label label6;
    }
}