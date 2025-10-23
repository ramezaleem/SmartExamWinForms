namespace EmployeeExamSystem_.PL.AdminDahboard.Results
{
    partial class FrmViewResultOfExam
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
            this.lblNameOfExam = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvExamsResults = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamsResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameOfExam
            // 
            this.lblNameOfExam.AutoSize = true;
            this.lblNameOfExam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfExam.Location = new System.Drawing.Point(12, 15);
            this.lblNameOfExam.Name = "lblNameOfExam";
            this.lblNameOfExam.Size = new System.Drawing.Size(119, 19);
            this.lblNameOfExam.TabIndex = 0;
            this.lblNameOfExam.Text = "نتائج الامتحان :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvExamsResults);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "النتيجة :";
            // 
            // dgvExamsResults
            // 
            this.dgvExamsResults.AllowUserToAddRows = false;
            this.dgvExamsResults.AllowUserToDeleteRows = false;
            this.dgvExamsResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExamsResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamsResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExamsResults.Location = new System.Drawing.Point(3, 23);
            this.dgvExamsResults.Name = "dgvExamsResults";
            this.dgvExamsResults.ReadOnly = true;
            this.dgvExamsResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExamsResults.Size = new System.Drawing.Size(948, 274);
            this.dgvExamsResults.TabIndex = 1;
            // 
            // FrmViewResultOfExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNameOfExam);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmViewResultOfExam";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نتيجة الامتحان :";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamsResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameOfExam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvExamsResults;
    }
}