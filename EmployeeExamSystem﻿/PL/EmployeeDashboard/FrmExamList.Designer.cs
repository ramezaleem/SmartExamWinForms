namespace EmployeeExamSystem_.PL.EmployeeDashboard
{
    partial class FrmExamList
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
            this.lblWelcomeEmployee = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvExamsList = new System.Windows.Forms.DataGridView();
            this.btnStartExam = new System.Windows.Forms.Button();
            this.btnShowExamsHistory = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamsList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeEmployee
            // 
            this.lblWelcomeEmployee.AutoSize = true;
            this.lblWelcomeEmployee.Location = new System.Drawing.Point(479, 52);
            this.lblWelcomeEmployee.Name = "lblWelcomeEmployee";
            this.lblWelcomeEmployee.Size = new System.Drawing.Size(66, 19);
            this.lblWelcomeEmployee.TabIndex = 0;
            this.lblWelcomeEmployee.Text = "أهلا بك!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvExamsList);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1153, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة الامتحانات :";
            // 
            // dgvExamsList
            // 
            this.dgvExamsList.AllowUserToAddRows = false;
            this.dgvExamsList.AllowUserToDeleteRows = false;
            this.dgvExamsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExamsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamsList.Location = new System.Drawing.Point(0, 26);
            this.dgvExamsList.MultiSelect = false;
            this.dgvExamsList.Name = "dgvExamsList";
            this.dgvExamsList.ReadOnly = true;
            this.dgvExamsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExamsList.Size = new System.Drawing.Size(1153, 224);
            this.dgvExamsList.TabIndex = 0;
            // 
            // btnStartExam
            // 
            this.btnStartExam.Location = new System.Drawing.Point(246, 439);
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Size = new System.Drawing.Size(181, 33);
            this.btnStartExam.TabIndex = 2;
            this.btnStartExam.Text = "بدء الامتحان";
            this.btnStartExam.UseVisualStyleBackColor = true;
            this.btnStartExam.Click += new System.EventHandler(this.btnStartExam_Click);
            // 
            // btnShowExamsHistory
            // 
            this.btnShowExamsHistory.Location = new System.Drawing.Point(755, 439);
            this.btnShowExamsHistory.Name = "btnShowExamsHistory";
            this.btnShowExamsHistory.Size = new System.Drawing.Size(181, 33);
            this.btnShowExamsHistory.TabIndex = 3;
            this.btnShowExamsHistory.Text = "نتائج امتحاناتك";
            this.btnShowExamsHistory.UseVisualStyleBackColor = true;
            this.btnShowExamsHistory.Click += new System.EventHandler(this.btnShowExamsHistory_Click);

            // 
            // FrmExamList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1177, 503);
            this.Controls.Add(this.btnShowExamsHistory);
            this.Controls.Add(this.btnStartExam);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWelcomeEmployee);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmExamList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة الامتحانات :";
            this.Load += new System.EventHandler(this.FrmExamList_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvExamsList;
        private System.Windows.Forms.Button btnStartExam;
        private System.Windows.Forms.Button btnShowExamsHistory;
    }
}