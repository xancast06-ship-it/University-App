namespace University_App
{
    partial class frmViewRosters
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
            dgvRoster = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRoster).BeginInit();
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
            // dgvRoster
            // 
            dgvRoster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoster.Location = new Point(12, 156);
            dgvRoster.Name = "dgvRoster";
            dgvRoster.Size = new Size(776, 199);
            dgvRoster.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 103);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 5;
            label1.Text = "My Roster";
            // 
            // frmViewRosters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvRoster);
            Controls.Add(pnlHeader);
            Name = "frmViewRosters";
            Text = "frmViewRosters";
            Load += frmViewRosters_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private DataGridView dgvRoster;
        private Label label1;
    }
}