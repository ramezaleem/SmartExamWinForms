namespace EmployeeExamSystem_.PL.AdminDahboard
{
    partial class FrmManageExams
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
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.nudPeriodTime = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExamName = new System.Windows.Forms.TextBox();
            this.btnAddNewExam = new System.Windows.Forms.Button();
            this.btnEditExam = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnManageQuestions = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnNotActive = new System.Windows.Forms.RadioButton();
            this.rdBtnActive = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.btnInsertExam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriodTime)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteExam.Location = new System.Drawing.Point(610, 50);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(75, 33);
            this.btnDeleteExam.TabIndex = 0;
            this.btnDeleteExam.Text = "حذف";
            this.btnDeleteExam.UseVisualStyleBackColor = false;
            this.btnDeleteExam.Click += new System.EventHandler(this.btnDeleteExam_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(329, 133);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(267, 27);
            this.dtpStartDate.TabIndex = 9;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(327, 166);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(267, 27);
            this.dtpEndDate.TabIndex = 8;
            // 
            // nudPeriodTime
            // 
            this.nudPeriodTime.Location = new System.Drawing.Point(327, 100);
            this.nudPeriodTime.Name = "nudPeriodTime";
            this.nudPeriodTime.Size = new System.Drawing.Size(267, 27);
            this.nudPeriodTime.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(684, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "حالة التفعيل :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 4;
            // 
            // txtExamName
            // 
            this.txtExamName.Location = new System.Drawing.Point(327, 66);
            this.txtExamName.Name = "txtExamName";
            this.txtExamName.Size = new System.Drawing.Size(267, 27);
            this.txtExamName.TabIndex = 6;
            // 
            // btnAddNewExam
            // 
            this.btnAddNewExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddNewExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewExam.Location = new System.Drawing.Point(842, 50);
            this.btnAddNewExam.Name = "btnAddNewExam";
            this.btnAddNewExam.Size = new System.Drawing.Size(154, 33);
            this.btnAddNewExam.TabIndex = 4;
            this.btnAddNewExam.Text = "إضافة امتحان جديد";
            this.btnAddNewExam.UseVisualStyleBackColor = false;
            this.btnAddNewExam.Click += new System.EventHandler(this.btnAddNewExam_Click);
            // 
            // btnEditExam
            // 
            this.btnEditExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditExam.Location = new System.Drawing.Point(726, 50);
            this.btnEditExam.Name = "btnEditExam";
            this.btnEditExam.Size = new System.Drawing.Size(75, 33);
            this.btnEditExam.TabIndex = 3;
            this.btnEditExam.Text = "تعديل";
            this.btnEditExam.UseVisualStyleBackColor = false;
            this.btnEditExam.Click += new System.EventHandler(this.btnEditExam_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInsertExam);
            this.groupBox2.Controls.Add(this.btnSaveEdit);
            this.groupBox2.Controls.Add(this.btnAddNewExam);
            this.groupBox2.Controls.Add(this.btnEditExam);
            this.groupBox2.Controls.Add(this.btnManageQuestions);
            this.groupBox2.Controls.Add(this.btnDeleteExam);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1203, 145);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة :";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEdit.Location = new System.Drawing.Point(110, 50);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(98, 33);
            this.btnSaveEdit.TabIndex = 5;
            this.btnSaveEdit.Text = "حفظ التعديل";
            this.btnSaveEdit.UseVisualStyleBackColor = false;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnManageQuestions
            // 
            this.btnManageQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnManageQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageQuestions.Location = new System.Drawing.Point(403, 50);
            this.btnManageQuestions.Name = "btnManageQuestions";
            this.btnManageQuestions.Size = new System.Drawing.Size(166, 33);
            this.btnManageQuestions.TabIndex = 1;
            this.btnManageQuestions.Text = "إدارة أسئلة الامتحان";
            this.btnManageQuestions.UseVisualStyleBackColor = false;
            this.btnManageQuestions.Click += new System.EventHandler(this.btnManageQuestions_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(678, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "المدة بالدقائق :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاريخ الانتهاء :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(693, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاريخ البدء :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الامتحان :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnNotActive);
            this.groupBox1.Controls.Add(this.rdBtnActive);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.nudPeriodTime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtExamName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1203, 270);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تفاصيل الامتحان :";
            // 
            // rdBtnNotActive
            // 
            this.rdBtnNotActive.AutoSize = true;
            this.rdBtnNotActive.Location = new System.Drawing.Point(396, 201);
            this.rdBtnNotActive.Name = "rdBtnNotActive";
            this.rdBtnNotActive.Size = new System.Drawing.Size(79, 23);
            this.rdBtnNotActive.TabIndex = 11;
            this.rdBtnNotActive.TabStop = true;
            this.rdBtnNotActive.Text = "غير مفعل";
            this.rdBtnNotActive.UseVisualStyleBackColor = true;
            // 
            // rdBtnActive
            // 
            this.rdBtnActive.AutoSize = true;
            this.rdBtnActive.Location = new System.Drawing.Point(538, 201);
            this.rdBtnActive.Name = "rdBtnActive";
            this.rdBtnActive.Size = new System.Drawing.Size(57, 23);
            this.rdBtnActive.TabIndex = 10;
            this.rdBtnActive.TabStop = true;
            this.rdBtnActive.Text = "مفعل";
            this.rdBtnActive.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(732, 487);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(16, 8);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvExams);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(34, 459);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1203, 190);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "الامتحانات :";
            // 
            // dgvExams
            // 
            this.dgvExams.AllowUserToAddRows = false;
            this.dgvExams.AllowUserToDeleteRows = false;
            this.dgvExams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExams.CausesValidation = false;
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExams.Location = new System.Drawing.Point(3, 23);
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.ReadOnly = true;
            this.dgvExams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExams.Size = new System.Drawing.Size(1197, 164);
            this.dgvExams.TabIndex = 0;
            this.dgvExams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExams_CellClick);
            // 
            // btnInsertExam
            // 
            this.btnInsertExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInsertExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertExam.Location = new System.Drawing.Point(249, 50);
            this.btnInsertExam.Name = "btnInsertExam";
            this.btnInsertExam.Size = new System.Drawing.Size(113, 33);
            this.btnInsertExam.TabIndex = 6;
            this.btnInsertExam.Text = "حفظ الامتحان";
            this.btnInsertExam.UseVisualStyleBackColor = false;
            this.btnInsertExam.Click += new System.EventHandler(this.btnInsertExam_Click);
            // 
            // FrmManageExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1270, 661);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmManageExams";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الامتحانات :";
            this.Load += new System.EventHandler(this.FrmManageExams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPeriodTime)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteExam;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.NumericUpDown nudPeriodTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExamName;
        private System.Windows.Forms.Button btnAddNewExam;
        private System.Windows.Forms.Button btnEditExam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnManageQuestions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvExams;
        private System.Windows.Forms.RadioButton rdBtnActive;
        private System.Windows.Forms.RadioButton rdBtnNotActive;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnInsertExam;
    }
}