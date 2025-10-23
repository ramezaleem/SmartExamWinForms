namespace EmployeeExamSystem_.PL.AdminDahboard
{
    partial class FrmViewResults
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
            this.btnViewExamResults = new System.Windows.Forms.Button();
            this.dgvExamsResults = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamsResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewExamResults
            // 
            this.btnViewExamResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnViewExamResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewExamResults.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewExamResults.Location = new System.Drawing.Point(252, 421);
            this.btnViewExamResults.Name = "btnViewExamResults";
            this.btnViewExamResults.Size = new System.Drawing.Size(177, 36);
            this.btnViewExamResults.TabIndex = 3;
            this.btnViewExamResults.Text = "عرض نتائج الامتحان";
            this.btnViewExamResults.UseVisualStyleBackColor = false;
            this.btnViewExamResults.Click += new System.EventHandler(this.btnViewExamResults_Click);
            // 
            // dgvExamsResults
            // 
            this.dgvExamsResults.AllowUserToAddRows = false;
            this.dgvExamsResults.AllowUserToDeleteRows = false;
            this.dgvExamsResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamsResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExamsResults.Location = new System.Drawing.Point(3, 23);
            this.dgvExamsResults.Name = "dgvExamsResults";
            this.dgvExamsResults.ReadOnly = true;
            this.dgvExamsResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExamsResults.Size = new System.Drawing.Size(647, 201);
            this.dgvExamsResults.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvExamsResults);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 227);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الامتحانات :";
            // 
            // FrmViewResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(677, 507);
            this.Controls.Add(this.btnViewExamResults);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmViewResults";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض نتائج الموظفين :";
            this.Load += new System.EventHandler(this.FrmViewResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamsResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewExamResults;
        private System.Windows.Forms.DataGridView dgvExamsResults;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}