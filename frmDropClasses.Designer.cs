namespace University_App
{
    partial class frmDropClasses
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
            dgvDropClasses = new DataGridView();
            btnDropClass = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDropClasses).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(319, 103);
            label1.Name = "label1";
            label1.Size = new Size(209, 37);
            label1.TabIndex = 4;
            label1.Text = "DROP CLASSES";
            // 
            // dgvDropClasses
            // 
            dgvDropClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDropClasses.Location = new Point(12, 141);
            dgvDropClasses.Name = "dgvDropClasses";
            dgvDropClasses.Size = new Size(776, 228);
            dgvDropClasses.TabIndex = 5;
            // 
            // btnDropClass
            // 
            btnDropClass.Location = new Point(422, 401);
            btnDropClass.Name = "btnDropClass";
            btnDropClass.Size = new Size(75, 23);
            btnDropClass.TabIndex = 6;
            btnDropClass.Text = "Drop Selected Class";
            btnDropClass.UseVisualStyleBackColor = true;
            btnDropClass.Click += btnDropClass_Click;
            // 
            // frmDropClasses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDropClass);
            Controls.Add(dgvDropClasses);
            Controls.Add(label1);
            Controls.Add(pnlHeader);
            Name = "frmDropClasses";
            Text = "frmDropClasses";
            ((System.ComponentModel.ISupportInitialize)dgvDropClasses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private DataGridView dgvDropClasses;
        private Button btnDropClass;
    }
}