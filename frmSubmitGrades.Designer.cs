namespace University_App
{
    partial class frmSubmitGrades
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
            cmbSections = new ComboBox();
            label1 = new Label();
            dgvStudents = new DataGridView();
            txtGrade = new TextBox();
            btnSubmitGrade = new Button();
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
            pnlHeader.TabIndex = 3;
            // 
            // cmbSections
            // 
            cmbSections.FormattingEnabled = true;
            cmbSections.Location = new Point(12, 148);
            cmbSections.Name = "cmbSections";
            cmbSections.Size = new Size(121, 23);
            cmbSections.TabIndex = 4;
            cmbSections.Text = "Select Section";
            cmbSections.SelectedIndexChanged += cmbSections_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(298, 103);
            label1.Name = "label1";
            label1.Size = new Size(205, 37);
            label1.TabIndex = 5;
            label1.Text = "Submit Grades";
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 177);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(776, 156);
            dgvStudents.TabIndex = 6;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(12, 339);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(100, 23);
            txtGrade.TabIndex = 7;
            // 
            // btnSubmitGrade
            // 
            btnSubmitGrade.Location = new Point(12, 368);
            btnSubmitGrade.Name = "btnSubmitGrade";
            btnSubmitGrade.Size = new Size(100, 23);
            btnSubmitGrade.TabIndex = 8;
            btnSubmitGrade.Text = "Submit Grade";
            btnSubmitGrade.UseVisualStyleBackColor = true;
            btnSubmitGrade.Click += btnSubmitGrade_Click;
            // 
            // frmSubmitGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 430);
            Controls.Add(btnSubmitGrade);
            Controls.Add(txtGrade);
            Controls.Add(dgvStudents);
            Controls.Add(label1);
            Controls.Add(cmbSections);
            Controls.Add(pnlHeader);
            Name = "frmSubmitGrades";
            Text = "frmSubmitGrades";
            Load += frmSubmitGrades_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private ComboBox cmbSections;
        private Label label1;
        private DataGridView dgvStudents;
        private TextBox txtGrade;
        private Button btnSubmitGrade;
    }
}