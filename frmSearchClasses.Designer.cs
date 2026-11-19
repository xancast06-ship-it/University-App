namespace University_App
{
    partial class frmSearchClasses
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
            label1 = new Label();
            dgvClasses = new DataGridView();
            btnRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 103);
            label1.Name = "label1";
            label1.Size = new Size(276, 37);
            label1.TabIndex = 0;
            label1.Text = "AVAILABLE CLASSES";
            // 
            // dgvClasses
            // 
            dgvClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasses.Location = new Point(24, 143);
            dgvClasses.MultiSelect = false;
            dgvClasses.Name = "dgvClasses";
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClasses.Size = new Size(753, 217);
            dgvClasses.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(38, 377);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(151, 23);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register Selected Class";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // frmSearchClasses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(dgvClasses);
            Controls.Add(label1);
            Controls.Add(pnlHeader);
            Name = "frmSearchClasses";
            Text = "Search Classes";
            Load += frmSearchClasses_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private DataGridView dgvClasses;
        private Button btnRegister;
    }
}