namespace University_App
{
    partial class frmManageEnrollment
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
            dgvEnrollment = new DataGridView();
            cmbStudents = new ComboBox();
            cmbSections = new ComboBox();
            btnAddEnrollment = new Button();
            btnDeleteEnrollment = new Button();
            btnRefresh = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEnrollment).BeginInit();
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
            // dgvEnrollment
            // 
            dgvEnrollment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnrollment.Location = new Point(12, 143);
            dgvEnrollment.MultiSelect = false;
            dgvEnrollment.Name = "dgvEnrollment";
            dgvEnrollment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEnrollment.Size = new Size(562, 239);
            dgvEnrollment.TabIndex = 5;
            // 
            // cmbStudents
            // 
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(592, 203);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(121, 23);
            cmbStudents.TabIndex = 6;
            // 
            // cmbSections
            // 
            cmbSections.FormattingEnabled = true;
            cmbSections.Location = new Point(592, 302);
            cmbSections.Name = "cmbSections";
            cmbSections.Size = new Size(121, 23);
            cmbSections.TabIndex = 7;
            // 
            // btnAddEnrollment
            // 
            btnAddEnrollment.Location = new Point(12, 388);
            btnAddEnrollment.Name = "btnAddEnrollment";
            btnAddEnrollment.Size = new Size(75, 23);
            btnAddEnrollment.TabIndex = 8;
            btnAddEnrollment.Text = "Add";
            btnAddEnrollment.UseVisualStyleBackColor = true;
            btnAddEnrollment.Click += btnAddEnrollment_Click;
            // 
            // btnDeleteEnrollment
            // 
            btnDeleteEnrollment.Location = new Point(93, 388);
            btnDeleteEnrollment.Name = "btnDeleteEnrollment";
            btnDeleteEnrollment.Size = new Size(75, 23);
            btnDeleteEnrollment.TabIndex = 9;
            btnDeleteEnrollment.Text = "Delete";
            btnDeleteEnrollment.UseVisualStyleBackColor = true;
            btnDeleteEnrollment.Click += btnDeleteEnrollment_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(177, 388);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 103);
            label1.Name = "label1";
            label1.Size = new Size(269, 37);
            label1.TabIndex = 11;
            label1.Text = "Manage Enrollment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(592, 185);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 12;
            label2.Text = "Students: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(594, 284);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 13;
            label3.Text = "Sections: ";
            // 
            // frmManageEnrollment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeleteEnrollment);
            Controls.Add(btnAddEnrollment);
            Controls.Add(cmbSections);
            Controls.Add(cmbStudents);
            Controls.Add(dgvEnrollment);
            Controls.Add(pnlHeader);
            Name = "frmManageEnrollment";
            Text = "Manage Enrollment";
            Load += frmManageEnrollment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEnrollment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private DataGridView dgvEnrollment;
        private ComboBox cmbStudents;
        private ComboBox cmbSections;
        private Button btnAddEnrollment;
        private Button btnDeleteEnrollment;
        private Button btnRefresh;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}