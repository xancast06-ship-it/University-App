namespace University_App
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            label3 = new Label();
            cmbRole = new ComboBox();
            label4 = new Label();
            txtFirstName = new TextBox();
            label5 = new Label();
            txtLastName = new TextBox();
            label6 = new Label();
            txtEmail = new MaskedTextBox();
            txtID = new TextBox();
            label7 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DarkBlue;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1184, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(278, 103);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(572, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "UNIVERSITY REGISTRATION SYSTEM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(488, 182);
            label3.Name = "label3";
            label3.Size = new Size(151, 21);
            label3.TabIndex = 4;
            label3.Text = "I am signing in as: ";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(500, 206);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 5;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(530, 257);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "First Name: ";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(470, 275);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(530, 320);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 8;
            label5.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(470, 338);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(528, 386);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 10;
            label6.Text = "ID Number";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(470, 464);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtID
            // 
            txtID.Location = new Point(470, 404);
            txtID.Name = "txtID";
            txtID.Size = new Size(200, 23);
            txtID.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(530, 446);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 13;
            label7.Text = "Email";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Khaki;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(470, 493);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 60);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1184, 761);
            Controls.Add(btnLogin);
            Controls.Add(label7);
            Controls.Add(txtID);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtLastName);
            Controls.Add(label5);
            Controls.Add(txtFirstName);
            Controls.Add(label4);
            Controls.Add(cmbRole);
            Controls.Add(label3);
            Controls.Add(lblTitle);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "University Registeration System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label label3;
        private ComboBox cmbRole;
        private Label label4;
        private TextBox txtFirstName;
        private Label label5;
        private TextBox txtLastName;
        private Label label6;
        private MaskedTextBox txtEmail;
        private TextBox txtID;
        private Label label7;
        private Button btnLogin;
    }
}
