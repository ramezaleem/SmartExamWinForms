namespace EmployeeExamSystem_.PL.EmployeeDashboard
{
    partial class FrmExam
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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblNumberOfQuestions = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.radioBtnOptianB = new System.Windows.Forms.RadioButton();
            this.radioBtnOptianC = new System.Windows.Forms.RadioButton();
            this.radioBtnOptianD = new System.Windows.Forms.RadioButton();
            this.radioBtnOptianA = new System.Windows.Forms.RadioButton();
            this.lblFirstQuestion = new System.Windows.Forms.Label();
            this.lblSecondQuestion = new System.Windows.Forms.Label();
            this.lblThirdQuestion = new System.Windows.Forms.Label();
            this.lblFourthQuestion = new System.Windows.Forms.Label();
            this.lblQuestionNameAndNumber = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnEndExam = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNameOfExam
            // 
            this.lblNameOfExam.AutoSize = true;
            this.lblNameOfExam.Location = new System.Drawing.Point(12, 22);
            this.lblNameOfExam.Name = "lblNameOfExam";
            this.lblNameOfExam.Size = new System.Drawing.Size(119, 19);
            this.lblNameOfExam.TabIndex = 0;
            this.lblNameOfExam.Text = "أسئلة امتحان :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.lblNumberOfQuestions);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.radioBtnOptianB);
            this.groupBox1.Controls.Add(this.radioBtnOptianC);
            this.groupBox1.Controls.Add(this.radioBtnOptianD);
            this.groupBox1.Controls.Add(this.radioBtnOptianA);
            this.groupBox1.Controls.Add(this.lblFirstQuestion);
            this.groupBox1.Controls.Add(this.lblSecondQuestion);
            this.groupBox1.Controls.Add(this.lblThirdQuestion);
            this.groupBox1.Controls.Add(this.lblFourthQuestion);
            this.groupBox1.Controls.Add(this.lblQuestionNameAndNumber);
            this.groupBox1.Location = new System.Drawing.Point(16, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 404);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الأسئلة";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(235, 318);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(143, 30);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.Text = "السؤال السابق";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblNumberOfQuestions
            // 
            this.lblNumberOfQuestions.AutoSize = true;
            this.lblNumberOfQuestions.Location = new System.Drawing.Point(414, 324);
            this.lblNumberOfQuestions.Name = "lblNumberOfQuestions";
            this.lblNumberOfQuestions.Size = new System.Drawing.Size(59, 19);
            this.lblNumberOfQuestions.TabIndex = 3;
            this.lblNumberOfQuestions.Text = "label1";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(561, 318);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(143, 30);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "السؤال التالي";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // radioBtnOptianB
            // 
            this.radioBtnOptianB.AutoSize = true;
            this.radioBtnOptianB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnOptianB.Location = new System.Drawing.Point(766, 164);
            this.radioBtnOptianB.Name = "radioBtnOptianB";
            this.radioBtnOptianB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtnOptianB.Size = new System.Drawing.Size(146, 23);
            this.radioBtnOptianB.TabIndex = 9;
            this.radioBtnOptianB.TabStop = true;
            this.radioBtnOptianB.Text = "الاجابة الصحيحة";
            this.radioBtnOptianB.UseVisualStyleBackColor = true;
            // 
            // radioBtnOptianC
            // 
            this.radioBtnOptianC.AutoSize = true;
            this.radioBtnOptianC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnOptianC.Location = new System.Drawing.Point(766, 204);
            this.radioBtnOptianC.Name = "radioBtnOptianC";
            this.radioBtnOptianC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtnOptianC.Size = new System.Drawing.Size(146, 23);
            this.radioBtnOptianC.TabIndex = 8;
            this.radioBtnOptianC.TabStop = true;
            this.radioBtnOptianC.Text = "الاجابة الصحيحة";
            this.radioBtnOptianC.UseVisualStyleBackColor = true;
            // 
            // radioBtnOptianD
            // 
            this.radioBtnOptianD.AutoSize = true;
            this.radioBtnOptianD.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnOptianD.Location = new System.Drawing.Point(766, 244);
            this.radioBtnOptianD.Name = "radioBtnOptianD";
            this.radioBtnOptianD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtnOptianD.Size = new System.Drawing.Size(146, 23);
            this.radioBtnOptianD.TabIndex = 7;
            this.radioBtnOptianD.TabStop = true;
            this.radioBtnOptianD.Text = "الاجابة الصحيحة";
            this.radioBtnOptianD.UseVisualStyleBackColor = true;
            // 
            // radioBtnOptianA
            // 
            this.radioBtnOptianA.AutoSize = true;
            this.radioBtnOptianA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioBtnOptianA.Location = new System.Drawing.Point(766, 124);
            this.radioBtnOptianA.Name = "radioBtnOptianA";
            this.radioBtnOptianA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioBtnOptianA.Size = new System.Drawing.Size(146, 23);
            this.radioBtnOptianA.TabIndex = 5;
            this.radioBtnOptianA.TabStop = true;
            this.radioBtnOptianA.Text = "الاجابة الصحيحة";
            this.radioBtnOptianA.UseVisualStyleBackColor = true;
            // 
            // lblFirstQuestion
            // 
            this.lblFirstQuestion.AutoSize = true;
            this.lblFirstQuestion.Location = new System.Drawing.Point(78, 126);
            this.lblFirstQuestion.Name = "lblFirstQuestion";
            this.lblFirstQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFirstQuestion.Size = new System.Drawing.Size(59, 19);
            this.lblFirstQuestion.TabIndex = 4;
            this.lblFirstQuestion.Text = "label1";
            // 
            // lblSecondQuestion
            // 
            this.lblSecondQuestion.AutoSize = true;
            this.lblSecondQuestion.Location = new System.Drawing.Point(78, 166);
            this.lblSecondQuestion.Name = "lblSecondQuestion";
            this.lblSecondQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSecondQuestion.Size = new System.Drawing.Size(59, 19);
            this.lblSecondQuestion.TabIndex = 3;
            this.lblSecondQuestion.Text = "label1";
            // 
            // lblThirdQuestion
            // 
            this.lblThirdQuestion.AutoSize = true;
            this.lblThirdQuestion.Location = new System.Drawing.Point(78, 206);
            this.lblThirdQuestion.Name = "lblThirdQuestion";
            this.lblThirdQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThirdQuestion.Size = new System.Drawing.Size(59, 19);
            this.lblThirdQuestion.TabIndex = 2;
            this.lblThirdQuestion.Text = "label1";
            // 
            // lblFourthQuestion
            // 
            this.lblFourthQuestion.AutoSize = true;
            this.lblFourthQuestion.Location = new System.Drawing.Point(78, 246);
            this.lblFourthQuestion.Name = "lblFourthQuestion";
            this.lblFourthQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFourthQuestion.Size = new System.Drawing.Size(59, 19);
            this.lblFourthQuestion.TabIndex = 1;
            this.lblFourthQuestion.Text = "label1";
            // 
            // lblQuestionNameAndNumber
            // 
            this.lblQuestionNameAndNumber.AutoSize = true;
            this.lblQuestionNameAndNumber.Location = new System.Drawing.Point(259, 47);
            this.lblQuestionNameAndNumber.Name = "lblQuestionNameAndNumber";
            this.lblQuestionNameAndNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQuestionNameAndNumber.Size = new System.Drawing.Size(59, 19);
            this.lblQuestionNameAndNumber.TabIndex = 0;
            this.lblQuestionNameAndNumber.Text = "label1";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(752, 22);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(116, 19);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "الوقت المتبقي";
            // 
            // btnEndExam
            // 
            this.btnEndExam.Location = new System.Drawing.Point(408, 588);
            this.btnEndExam.Name = "btnEndExam";
            this.btnEndExam.Size = new System.Drawing.Size(175, 34);
            this.btnEndExam.TabIndex = 4;
            this.btnEndExam.Text = "إنهاء الامتحان ";
            this.btnEndExam.UseVisualStyleBackColor = false;
            this.btnEndExam.Click += new System.EventHandler(this.btnEndExam_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(33, 596);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(70, 19);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "النتيجة :";
            // 
            // FrmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1013, 659);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnEndExam);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNameOfExam);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmExam";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الامتحان :";
            this.Load += new System.EventHandler(this.FrmExam_Load);
            this.FormClosing += FrmExam_FormClosing;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameOfExam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQuestionNameAndNumber;
        private System.Windows.Forms.RadioButton radioBtnOptianB;
        private System.Windows.Forms.RadioButton radioBtnOptianC;
        private System.Windows.Forms.RadioButton radioBtnOptianD;
        private System.Windows.Forms.RadioButton radioBtnOptianA;
        private System.Windows.Forms.Label lblFirstQuestion;
        private System.Windows.Forms.Label lblSecondQuestion;
        private System.Windows.Forms.Label lblThirdQuestion;
        private System.Windows.Forms.Label lblFourthQuestion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblNumberOfQuestions;
        private System.Windows.Forms.Button btnEndExam;
        private System.Windows.Forms.Label lblResult;
    }
}