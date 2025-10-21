namespace EmployeeExamSystem_.PL.AdminDahboard
{
    partial class FrmAdminDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewResults = new System.Windows.Forms.Button();
            this.btnManageQuetions = new System.Windows.Forms.Button();
            this.btnMnageExams = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(331, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = ": لوحة التحكم";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnViewResults);
            this.groupBox1.Controls.Add(this.btnManageQuetions);
            this.groupBox1.Controls.Add(this.btnMnageExams);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(169, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(472, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العمليات المتاحة :";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(40, 261);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewResults
            // 
            this.btnViewResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(166)))), ((int)(((byte)(35)))));
            this.btnViewResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewResults.Location = new System.Drawing.Point(150, 194);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(188, 33);
            this.btnViewResults.TabIndex = 2;
            this.btnViewResults.Text = "عرض النتائج  ";
            this.btnViewResults.UseVisualStyleBackColor = false;
            this.btnViewResults.Click += new System.EventHandler(this.btnViewResults_Click);
            // 
            // btnManageQuetions
            // 
            this.btnManageQuetions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnManageQuetions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageQuetions.Location = new System.Drawing.Point(150, 129);
            this.btnManageQuetions.Name = "btnManageQuetions";
            this.btnManageQuetions.Size = new System.Drawing.Size(188, 33);
            this.btnManageQuetions.TabIndex = 1;
            this.btnManageQuetions.Text = "إدارة الأسئلة";
            this.btnManageQuetions.UseVisualStyleBackColor = false;
            // 
            // btnMnageExams
            // 
            this.btnMnageExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnMnageExams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMnageExams.Location = new System.Drawing.Point(150, 66);
            this.btnMnageExams.Name = "btnMnageExams";
            this.btnMnageExams.Size = new System.Drawing.Size(188, 33);
            this.btnMnageExams.TabIndex = 0;
            this.btnMnageExams.Text = "إدارة الامتحانات";
            this.btnMnageExams.UseVisualStyleBackColor = false;
            // 
            // FrmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAdminDashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة تحكم المسؤول :";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMnageExams;
        private System.Windows.Forms.Button btnViewResults;
        private System.Windows.Forms.Button btnManageQuetions;
        private System.Windows.Forms.Button btnExit;
    }
}