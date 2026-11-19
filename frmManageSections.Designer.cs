namespace University_App
{
    partial class frmManageSections
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
            dgvSections = new DataGridView();
            cmbCourse = new ComboBox();
            cmbProfessor = new ComboBox();
            txtRoom = new TextBox();
            txtSemester = new TextBox();
            txtYear = new TextBox();
            txtCapacity = new TextBox();
            btnAddSection = new Button();
            btnDeleteSection = new Button();
            btnRefresh = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSections).BeginInit();
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
            // dgvSections
            // 
            dgvSections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSections.Location = new Point(12, 149);
            dgvSections.MultiSelect = false;
            dgvSections.Name = "dgvSections";
            dgvSections.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSections.Size = new Size(576, 231);
            dgvSections.TabIndex = 5;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(594, 167);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(121, 23);
            cmbCourse.TabIndex = 6;
            // 
            // cmbProfessor
            // 
            cmbProfessor.FormattingEnabled = true;
            cmbProfessor.Location = new Point(594, 218);
            cmbProfessor.Name = "cmbProfessor";
            cmbProfessor.Size = new Size(121, 23);
            cmbProfessor.TabIndex = 7;
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(594, 272);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(194, 23);
            txtRoom.TabIndex = 8;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(594, 320);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(194, 23);
            txtSemester.TabIndex = 9;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(594, 366);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(194, 23);
            txtYear.TabIndex = 10;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(594, 415);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(194, 23);
            txtCapacity.TabIndex = 11;
            // 
            // btnAddSection
            // 
            btnAddSection.Location = new Point(12, 386);
            btnAddSection.Name = "btnAddSection";
            btnAddSection.Size = new Size(75, 23);
            btnAddSection.TabIndex = 12;
            btnAddSection.Text = "Add";
            btnAddSection.UseVisualStyleBackColor = true;
            btnAddSection.Click += btnAddSection_Click;
            // 
            // btnDeleteSection
            // 
            btnDeleteSection.Location = new Point(93, 386);
            btnDeleteSection.Name = "btnDeleteSection";
            btnDeleteSection.Size = new Size(75, 23);
            btnDeleteSection.TabIndex = 13;
            btnDeleteSection.Text = "Delete";
            btnDeleteSection.UseVisualStyleBackColor = true;
            btnDeleteSection.Click += btnDeleteSection_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(174, 386);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 103);
            label1.Name = "label1";
            label1.Size = new Size(235, 37);
            label1.TabIndex = 15;
            label1.Text = "Manage Sections";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(594, 149);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 16;
            label2.Text = "Course:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(594, 200);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 17;
            label3.Text = "Professor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(594, 254);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 18;
            label4.Text = "Room:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(598, 302);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 19;
            label5.Text = "Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(594, 348);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 20;
            label6.Text = "Year:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(594, 397);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 21;
            label7.Text = "Capacity";
            // 
            // frmManageSections
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeleteSection);
            Controls.Add(btnAddSection);
            Controls.Add(txtCapacity);
            Controls.Add(txtYear);
            Controls.Add(txtSemester);
            Controls.Add(txtRoom);
            Controls.Add(cmbProfessor);
            Controls.Add(cmbCourse);
            Controls.Add(dgvSections);
            Controls.Add(pnlHeader);
            Name = "frmManageSections";
            Text = "Manage Sections";
            Load += frmManageSections_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSections).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private DataGridView dgvSections;
        private ComboBox cmbCourse;
        private ComboBox cmbProfessor;
        private TextBox txtRoom;
        private TextBox txtSemester;
        private TextBox txtYear;
        private TextBox txtCapacity;
        private Button btnAddSection;
        private Button btnDeleteSection;
        private Button btnRefresh;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}