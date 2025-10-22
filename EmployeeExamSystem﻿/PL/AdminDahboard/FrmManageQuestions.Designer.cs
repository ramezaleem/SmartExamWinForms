namespace EmployeeExamSystem_.PL.AdminDahboard
{
    partial class FrmManageQuestions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOptionD = new System.Windows.Forms.TextBox();
            this.txtOptionC = new System.Windows.Forms.TextBox();
            this.txtOptionB = new System.Windows.Forms.TextBox();
            this.txtOptionA = new System.Windows.Forms.TextBox();
            this.txtRefQuestion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddNewQuestion = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.radioBtnCorrectOptionA = new System.Windows.Forms.RadioButton();
            this.radioBtnCorrectOptionD = new System.Windows.Forms.RadioButton();
            this.radioBtnCorrectOptionC = new System.Windows.Forms.RadioButton();
            this.radioBtnCorrectOptionB = new System.Windows.Forms.RadioButton();
            this.btnSaveEditQuestion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.radioBtnCorrectOptionB);
            this.groupBox1.Controls.Add(this.radioBtnCorrectOptionC);
            this.groupBox1.Controls.Add(this.radioBtnCorrectOptionD);
            this.groupBox1.Controls.Add(this.radioBtnCorrectOptionA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtOptionD);
            this.groupBox1.Controls.Add(this.txtOptionC);
            this.groupBox1.Controls.Add(this.txtOptionB);
            this.groupBox1.Controls.Add(this.txtOptionA);
            this.groupBox1.Controls.Add(this.txtRefQuestion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أسئلة الامتحان :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "الاختيارات :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtOptionD
            // 
            this.txtOptionD.Location = new System.Drawing.Point(297, 247);
            this.txtOptionD.Name = "txtOptionD";
            this.txtOptionD.Size = new System.Drawing.Size(256, 27);
            this.txtOptionD.TabIndex = 9;
            this.txtOptionD.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtOptionC
            // 
            this.txtOptionC.Location = new System.Drawing.Point(297, 203);
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.Size = new System.Drawing.Size(256, 27);
            this.txtOptionC.TabIndex = 8;
            this.txtOptionC.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtOptionB
            // 
            this.txtOptionB.Location = new System.Drawing.Point(297, 159);
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.Size = new System.Drawing.Size(256, 27);
            this.txtOptionB.TabIndex = 7;
            this.txtOptionB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtOptionA
            // 
            this.txtOptionA.Location = new System.Drawing.Point(297, 115);
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.Size = new System.Drawing.Size(256, 27);
            this.txtOptionA.TabIndex = 6;
            this.txtOptionA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtRefQuestion
            // 
            this.txtRefQuestion.Location = new System.Drawing.Point(297, 28);
            this.txtRefQuestion.Name = "txtRefQuestion";
            this.txtRefQuestion.Size = new System.Drawing.Size(256, 27);
            this.txtRefQuestion.TabIndex = 5;
            this.txtRefQuestion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "الاختيار الأول :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "الاختيار الثاني :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "الاختيار الثالث :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاختيار الرابع :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "نص السؤال :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveEditQuestion);
            this.groupBox2.Controls.Add(this.btnAddNewQuestion);
            this.groupBox2.Controls.Add(this.btnEditQuestion);
            this.groupBox2.Controls.Add(this.btnSaveQuestion);
            this.groupBox2.Controls.Add(this.btnDeleteQuestion);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 348);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة :";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnAddNewQuestion
            // 
            this.btnAddNewQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddNewQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewQuestion.Location = new System.Drawing.Point(556, 45);
            this.btnAddNewQuestion.Name = "btnAddNewQuestion";
            this.btnAddNewQuestion.Size = new System.Drawing.Size(164, 33);
            this.btnAddNewQuestion.TabIndex = 8;
            this.btnAddNewQuestion.Text = "إضافة سؤال جديد";
            this.btnAddNewQuestion.UseVisualStyleBackColor = false;
            this.btnAddNewQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEditQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditQuestion.Location = new System.Drawing.Point(451, 45);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(75, 33);
            this.btnEditQuestion.TabIndex = 7;
            this.btnEditQuestion.Text = "تعديل";
            this.btnEditQuestion.UseVisualStyleBackColor = false;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveQuestion.Location = new System.Drawing.Point(193, 45);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(123, 33);
            this.btnSaveQuestion.TabIndex = 6;
            this.btnSaveQuestion.Text = "حفظ السؤال";
            this.btnSaveQuestion.UseVisualStyleBackColor = false;
            this.btnSaveQuestion.Click += new System.EventHandler(this.btnSaveQuestion_Click);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteQuestion.Location = new System.Drawing.Point(346, 45);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(75, 33);
            this.btnDeleteQuestion.TabIndex = 5;
            this.btnDeleteQuestion.Text = "حذف";
            this.btnDeleteQuestion.UseVisualStyleBackColor = false;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvQuestions);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(26, 454);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(748, 254);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "أسئلة الامتحان :";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Location = new System.Drawing.Point(0, 26);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.Size = new System.Drawing.Size(748, 228);
            this.dgvQuestions.TabIndex = 0;
            this.dgvQuestions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExams_CellContentClick);
            // 
            // radioBtnCorrectOptionA
            // 
            this.radioBtnCorrectOptionA.AutoSize = true;
            this.radioBtnCorrectOptionA.Location = new System.Drawing.Point(17, 117);
            this.radioBtnCorrectOptionA.Name = "radioBtnCorrectOptionA";
            this.radioBtnCorrectOptionA.Size = new System.Drawing.Size(146, 23);
            this.radioBtnCorrectOptionA.TabIndex = 11;
            this.radioBtnCorrectOptionA.TabStop = true;
            this.radioBtnCorrectOptionA.Text = "الإجابة الصحيحة";
            this.radioBtnCorrectOptionA.UseVisualStyleBackColor = true;
            // 
            // radioBtnCorrectOptionD
            // 
            this.radioBtnCorrectOptionD.AutoSize = true;
            this.radioBtnCorrectOptionD.Location = new System.Drawing.Point(17, 249);
            this.radioBtnCorrectOptionD.Name = "radioBtnCorrectOptionD";
            this.radioBtnCorrectOptionD.Size = new System.Drawing.Size(146, 23);
            this.radioBtnCorrectOptionD.TabIndex = 13;
            this.radioBtnCorrectOptionD.TabStop = true;
            this.radioBtnCorrectOptionD.Text = "الإجابة الصحيحة";
            this.radioBtnCorrectOptionD.UseVisualStyleBackColor = true;
            // 
            // radioBtnCorrectOptionC
            // 
            this.radioBtnCorrectOptionC.AutoSize = true;
            this.radioBtnCorrectOptionC.Location = new System.Drawing.Point(17, 205);
            this.radioBtnCorrectOptionC.Name = "radioBtnCorrectOptionC";
            this.radioBtnCorrectOptionC.Size = new System.Drawing.Size(146, 23);
            this.radioBtnCorrectOptionC.TabIndex = 14;
            this.radioBtnCorrectOptionC.TabStop = true;
            this.radioBtnCorrectOptionC.Text = "الإجابة الصحيحة";
            this.radioBtnCorrectOptionC.UseVisualStyleBackColor = true;
            // 
            // radioBtnCorrectOptionB
            // 
            this.radioBtnCorrectOptionB.AutoSize = true;
            this.radioBtnCorrectOptionB.Location = new System.Drawing.Point(17, 161);
            this.radioBtnCorrectOptionB.Name = "radioBtnCorrectOptionB";
            this.radioBtnCorrectOptionB.Size = new System.Drawing.Size(146, 23);
            this.radioBtnCorrectOptionB.TabIndex = 15;
            this.radioBtnCorrectOptionB.TabStop = true;
            this.radioBtnCorrectOptionB.Text = "الإجابة الصحيحة";
            this.radioBtnCorrectOptionB.UseVisualStyleBackColor = true;
            // 
            // btnSaveEditQuestion
            // 
            this.btnSaveEditQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSaveEditQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEditQuestion.Location = new System.Drawing.Point(40, 45);
            this.btnSaveEditQuestion.Name = "btnSaveEditQuestion";
            this.btnSaveEditQuestion.Size = new System.Drawing.Size(123, 33);
            this.btnSaveEditQuestion.TabIndex = 9;
            this.btnSaveEditQuestion.Text = "حفظ التعديل";
            this.btnSaveEditQuestion.UseVisualStyleBackColor = false;
            // 
            // FrmManageQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmManageQuestions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة أسئلة الامتحان";
            this.Load += new System.EventHandler(this.FrmManageQuestions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOptionC;
        private System.Windows.Forms.TextBox txtOptionB;
        private System.Windows.Forms.TextBox txtOptionA;
        private System.Windows.Forms.TextBox txtRefQuestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOptionD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddNewQuestion;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button btnSaveQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.RadioButton radioBtnCorrectOptionB;
        private System.Windows.Forms.RadioButton radioBtnCorrectOptionC;
        private System.Windows.Forms.RadioButton radioBtnCorrectOptionD;
        private System.Windows.Forms.RadioButton radioBtnCorrectOptionA;
        private System.Windows.Forms.Button btnSaveEditQuestion;
    }
}