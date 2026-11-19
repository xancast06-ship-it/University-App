namespace University_App
{
    partial class frmCourseRequest
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
            txtCourseName = new MaskedTextBox();
            txtCredits = new TextBox();
            txtReason = new TextBox();
            btnSubmitRequest = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
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
            // txtCourseName
            // 
            txtCourseName.Location = new Point(342, 192);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(100, 23);
            txtCourseName.TabIndex = 4;
            // 
            // txtCredits
            // 
            txtCredits.Location = new Point(342, 250);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(100, 23);
            txtCredits.TabIndex = 5;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(342, 313);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(100, 23);
            txtReason.TabIndex = 6;
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.Location = new Point(348, 361);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(75, 23);
            btnSubmitRequest.TabIndex = 7;
            btnSubmitRequest.Text = "Submit";
            btnSubmitRequest.UseVisualStyleBackColor = true;
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 103);
            label1.Name = "label1";
            label1.Size = new Size(215, 37);
            label1.TabIndex = 8;
            label1.Text = "Course Request";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 174);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 9;
            label2.Text = "Course Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 232);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 10;
            label3.Text = "Credits:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 295);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 11;
            label4.Text = "Reason:";
            // 
            // frmCourseRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSubmitRequest);
            Controls.Add(txtReason);
            Controls.Add(txtCredits);
            Controls.Add(txtCourseName);
            Controls.Add(pnlHeader);
            Name = "frmCourseRequest";
            Text = "Course Request";
            Load += frmCourseRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private MaskedTextBox txtCourseName;
        private TextBox txtCredits;
        private TextBox txtReason;
        private Button btnSubmitRequest;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}