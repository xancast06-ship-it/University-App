namespace University_App
{
    partial class frmMySections
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
            label1 = new Label();
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
            pnlHeader.TabIndex = 3;
            // 
            // dgvSections
            // 
            dgvSections.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSections.Location = new Point(12, 140);
            dgvSections.Name = "dgvSections";
            dgvSections.Size = new Size(776, 254);
            dgvSections.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 103);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 4;
            label1.Text = "My Sections";
            // 
            // frmMySections
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvSections);
            Controls.Add(pnlHeader);
            Name = "frmMySections";
            Text = "frmMySections";
            Load += frmMySections_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSections).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private DataGridView dgvSections;
        private Label label1;
    }
}