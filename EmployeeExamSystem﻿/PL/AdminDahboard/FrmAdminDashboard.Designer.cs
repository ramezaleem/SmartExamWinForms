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
            this.btnManageQuestions = new System.Windows.Forms.Button();
            this.btnManageExams = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(331, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = ": لوحة التحكم";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnViewResults);
            this.groupBox1.Controls.Add(this.btnManageQuestions);
            this.groupBox1.Controls.Add(this.btnManageExams);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(43)))), ((int)(((byte)(33)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
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
            this.btnViewResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(83)))));
            this.btnViewResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewResults.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(67)))));
            this.btnViewResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewResults.ForeColor = System.Drawing.Color.White;
            this.btnViewResults.Location = new System.Drawing.Point(150, 194);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(188, 33);
            this.btnViewResults.TabIndex = 2;
            this.btnViewResults.Text = "عرض النتائج  ";
            this.btnViewResults.UseVisualStyleBackColor = false;
            this.btnViewResults.Click += new System.EventHandler(this.btnViewResults_Click);
            // 
            // btnManageQuestions
            // 
            this.btnManageQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(126)))));
            this.btnManageQuestions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageQuestions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(88)))), ((int)(((byte)(99)))));
            this.btnManageQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageQuestions.ForeColor = System.Drawing.Color.White;
            this.btnManageQuestions.Location = new System.Drawing.Point(150, 129);
            this.btnManageQuestions.Name = "btnManageQuestions";
            this.btnManageQuestions.Size = new System.Drawing.Size(188, 33);
            this.btnManageQuestions.TabIndex = 1;
            this.btnManageQuestions.Text = "إدارة الأسئلة";
            this.btnManageQuestions.UseVisualStyleBackColor = false;
            // 
            // btnManageExams
            // 
            this.btnManageExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnManageExams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageExams.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.btnManageExams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageExams.ForeColor = System.Drawing.Color.White;
            this.btnManageExams.Location = new System.Drawing.Point(150, 66);
            this.btnManageExams.Name = "btnManageExams";
            this.btnManageExams.Size = new System.Drawing.Size(188, 33);
            this.btnManageExams.TabIndex = 0;
            this.btnManageExams.Text = "إدارة الامتحانات";
            this.btnManageExams.UseVisualStyleBackColor = false;
            this.btnManageExams.Click += new System.EventHandler(this.btnManageExams_Click);
            // 
            // FrmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAdminDashboard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة تحكم المسؤول :";
            this.Load += new System.EventHandler(this.FrmAdminDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnManageExams;
        private System.Windows.Forms.Button btnViewResults;
        private System.Windows.Forms.Button btnManageQuestions;
        private System.Windows.Forms.Button btnExit;
    }
}