namespace University_App
{
    partial class frmManageRequests
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
            dgvRequests = new DataGridView();
            btnApprove = new Button();
            btnDeny = new Button();
            btnRefresh = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
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
            // dgvRequests
            // 
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new Point(12, 156);
            dgvRequests.MultiSelect = false;
            dgvRequests.Name = "dgvRequests";
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequests.Size = new Size(766, 198);
            dgvRequests.TabIndex = 5;
            // 
            // btnApprove
            // 
            btnApprove.Location = new Point(12, 371);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(75, 23);
            btnApprove.TabIndex = 6;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnDeny
            // 
            btnDeny.Location = new Point(93, 371);
            btnDeny.Name = "btnDeny";
            btnDeny.Size = new Size(75, 23);
            btnDeny.TabIndex = 7;
            btnDeny.Text = "Deny";
            btnDeny.UseVisualStyleBackColor = true;
            btnDeny.Click += btnDeny_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(174, 371);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 103);
            label1.Name = "label1";
            label1.Size = new Size(243, 37);
            label1.TabIndex = 9;
            label1.Text = "Manage Requests";
            // 
            // frmManageRequests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeny);
            Controls.Add(btnApprove);
            Controls.Add(dgvRequests);
            Controls.Add(pnlHeader);
            Name = "frmManageRequests";
            Text = "Manage Requests";
            Load += frmManageRequests_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private DataGridView dgvRequests;
        private Button btnApprove;
        private Button btnDeny;
        private Button btnRefresh;
        private Label label1;
    }
}