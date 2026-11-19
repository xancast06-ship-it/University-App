namespace University_App
{
    partial class frmMySchedule
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
            dgvSchedule = new DataGridView();
            btnDropClass = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DarkBlue;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 100);
            pnlHeader.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(298, 103);
            label1.Name = "label1";
            label1.Size = new Size(201, 37);
            label1.TabIndex = 3;
            label1.Text = "MY SCHEDULE";
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(12, 143);
            dgvSchedule.MultiSelect = false;
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedule.Size = new Size(776, 220);
            dgvSchedule.TabIndex = 4;
            // 
            // btnDropClass
            // 
            btnDropClass.Location = new Point(29, 369);
            btnDropClass.Name = "btnDropClass";
            btnDropClass.Size = new Size(122, 23);
            btnDropClass.TabIndex = 5;
            btnDropClass.Text = "Drop Selected Class";
            btnDropClass.UseVisualStyleBackColor = true;
            btnDropClass.Click += btnDropClass_Click;
            // 
            // frmMySchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDropClass);
            Controls.Add(dgvSchedule);
            Controls.Add(label1);
            Controls.Add(pnlHeader);
            Name = "frmMySchedule";
            Text = "My Schedule";
            Load += frmMySchedule_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private DataGridView dgvSchedule;
        private Button btnDropClass;
    }
}