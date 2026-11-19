namespace University_App
{
    partial class frmCreateSection
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
            cmbCourse = new ComboBox();
            txtRoom = new TextBox();
            txtSemester = new TextBox();
            txtYear = new TextBox();
            txtCapacity = new TextBox();
            btnCreateSection = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(227, 183);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(121, 23);
            cmbCourse.TabIndex = 4;
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(227, 250);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(100, 23);
            txtRoom.TabIndex = 5;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(227, 325);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(100, 23);
            txtSemester.TabIndex = 6;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(432, 183);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 7;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(432, 250);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(100, 23);
            txtCapacity.TabIndex = 8;
            // 
            // btnCreateSection
            // 
            btnCreateSection.Location = new Point(438, 325);
            btnCreateSection.Name = "btnCreateSection";
            btnCreateSection.Size = new Size(94, 23);
            btnCreateSection.TabIndex = 9;
            btnCreateSection.Text = "Create Section";
            btnCreateSection.UseVisualStyleBackColor = true;
            btnCreateSection.Click += btnCreateSection_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 107);
            label1.Name = "label1";
            label1.Size = new Size(203, 37);
            label1.TabIndex = 10;
            label1.Text = "Create Section";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 165);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 11;
            label2.Text = "Select Course:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 165);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 12;
            label3.Text = "Year: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 232);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 13;
            label4.Text = "Room:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(456, 232);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 14;
            label5.Text = "Capacity:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 307);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 15;
            label6.Text = "Semester:";
            // 
            // frmCreateSection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreateSection);
            Controls.Add(txtCapacity);
            Controls.Add(txtYear);
            Controls.Add(txtSemester);
            Controls.Add(txtRoom);
            Controls.Add(cmbCourse);
            Controls.Add(pnlHeader);
            Name = "frmCreateSection";
            Text = "frmCreateSection";
            Load += frmCreateSection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private ComboBox cmbCourse;
        private TextBox txtRoom;
        private TextBox txtSemester;
        private TextBox txtYear;
        private TextBox txtCapacity;
        private Button btnCreateSection;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}