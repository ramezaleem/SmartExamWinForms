using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeExamSystem_.PL.EmployeeDashboard
{
    public partial class FrmExam : Form
    {
        private ExamQuestionsBL examBL = new ExamQuestionsBL();

        private bool examFinished = false;
        private int employeeId;
        private int examId;
        private DataTable questionsTable;
        private int currentQuestionIndex = 0;
        private int totalQuestions = 0;
        private Dictionary<int, string> userAnswers = new Dictionary<int, string>();

        private int periodTimeInMinutes;
        private int remainingSeconds;
        private Timer examTimer;

        public FrmExam(int employeeId, int examId, int remainingSeconds = 0)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#F8F9F9");

            lblNameOfExam.ForeColor = ColorTranslator.FromHtml("#2C3E50");
            lblNameOfExam.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblNameOfExam.TextAlign = ContentAlignment.MiddleCenter;
            lblNameOfExam.Dock = DockStyle.Top;
            lblNameOfExam.Height = 50;

            lblTimer.ForeColor = ColorTranslator.FromHtml("#C0392B");
            lblTimer.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            lblQuestionNameAndNumber.ForeColor = ColorTranslator.FromHtml("#2C3E50");
            lblQuestionNameAndNumber.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            RadioButton[] radios = { radioBtnOptianA, radioBtnOptianB, radioBtnOptianC, radioBtnOptianD };
            foreach (var r in radios)
            {
                r.ForeColor = ColorTranslator.FromHtml("#34495E");
                r.Font = new Font("Segoe UI", 10);
                r.BackColor = this.BackColor;
            }

            Label[] lbls = { lblFirstQuestion, lblSecondQuestion, lblThirdQuestion, lblFourthQuestion, lblNumberOfQuestions };
            foreach (var lbl in lbls)
            {
                lbl.ForeColor = ColorTranslator.FromHtml("#34495E");
                lbl.Font = new Font("Segoe UI", 10);
            }

            lblResult.ForeColor = ColorTranslator.FromHtml("#117A65");
            lblResult.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            SetupButton(btnNext, "#2E86C1", "#5DADE2", "#1B4F72");
            SetupButton(btnPrevious, "#7B7D7D", "#A6ACAF", "#626567");
            SetupButton(btnEndExam, "#C0392B", "#E74C3C", "#922B21");

            this.employeeId = employeeId;
            this.examId = examId;
            this.remainingSeconds = remainingSeconds;

            this.Load += FrmExam_Load;
            this.FormClosing += FrmExam_FormClosing;
        }

        private void SetupButton(Button btn, string mainColor, string hoverColor, string borderColor)
        {
            btn.BackColor = ColorTranslator.FromHtml(mainColor);
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml(borderColor);
            btn.FlatAppearance.BorderSize = 1;

            btn.MouseEnter += (s, e) => btn.BackColor = ColorTranslator.FromHtml(hoverColor);
            btn.MouseLeave += (s, e) => btn.BackColor = ColorTranslator.FromHtml(mainColor);
        }
        private void FrmExam_Load(object sender, EventArgs e)
        {
            try
            {
                int savedTimeLeft = examBL.GetRemainingTime(employeeId, examId);

                if (savedTimeLeft > 0)
                {
                    remainingSeconds = savedTimeLeft;
                }
                else
                {
                    int periodTimeInMinutes = examBL.GetExamPeriodTime(examId);
                    remainingSeconds = periodTimeInMinutes * 60;
                }

                InitializeTimer();

                LoadQuestions();

                lblNameOfExam.Text = "أسئلة امتحان: " + examBL.GetExamName(examId);
                lblTimer.Text = TimeSpan.FromSeconds(remainingSeconds).ToString(@"mm\:ss");
                lblResult.Text = "";

                radioBtnOptianA.Checked = false;
                radioBtnOptianB.Checked = false;
                radioBtnOptianC.Checked = false;
                radioBtnOptianD.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل الامتحان: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        protected override CreateParams CreateParams
        {
            get
            {
                const int CP_NOCLOSE_BUTTON = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CP_NOCLOSE_BUTTON;
                return cp;
            }
        }


        private void FrmExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            examBL.UpdateRemainingTime(employeeId, examId, remainingSeconds);
        }

        private void SaveCurrentAnswer()
        {
            string selectedOption = GetSelectedOption();
            if (!string.IsNullOrEmpty(selectedOption))
            {
                int questionId = Convert.ToInt32(questionsTable.Rows[currentQuestionIndex]["QuestionID"]);
                userAnswers[questionId] = selectedOption;
            }
        }

        private int CalculateScore()
        {
            int score = 0;
            foreach (DataRow row in questionsTable.Rows)
            {
                int questionId = (int)row["QuestionID"];
                string correctOption = row["CorrectOption"].ToString();

                if (userAnswers.ContainsKey(questionId) && userAnswers[questionId] == correctOption)
                {
                    score++; 
                }
            }
            return score;
        }

        private void InitializeTimer()
        {
            if (examTimer != null)
            {
                examTimer.Stop();
                examTimer.Tick -= ExamTimer_Tick;
                examTimer.Dispose();
            }

            examTimer = new Timer
            {
                Interval = 1000 
            };
            examTimer.Tick += ExamTimer_Tick;
            examTimer.Start();
        }

        private void ExamTimer_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
                lblTimer.Text = TimeSpan.FromSeconds(remainingSeconds).ToString(@"mm\:ss");

                if (remainingSeconds <= 300) 
                {
                    lblTimer.ForeColor = Color.Red;
                }
                else
                {
                    lblTimer.ForeColor = Color.Black;
                }

                if (remainingSeconds % 60 == 0)
                {
                    examBL.UpdateRemainingTime(employeeId, examId, remainingSeconds);
                }
            }
            else
            {
                examTimer.Stop();
                MessageBox.Show("انتهى الوقت المخصص للامتحان.");
                this.Close();
            }
        }

        private void LoadQuestions()
        {
            try
            {
                questionsTable = examBL.GetQuestionsByExamId(examId);

                if (questionsTable == null || questionsTable.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد أسئلة لهذا الامتحان.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }

                totalQuestions = questionsTable.Rows.Count;
                currentQuestionIndex = 0; 

                DisplayQuestion(currentQuestionIndex);
                lblNumberOfQuestions.Text = $"السؤال {currentQuestionIndex + 1} من {totalQuestions}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل الأسئلة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void DisplayQuestion(int index)
        {
            if (index >= 0 && index < totalQuestions)
            {
                DataRow row = questionsTable.Rows[index];
                lblQuestionNameAndNumber.Text = $"السؤال {index + 1}: {row["QuestionText"].ToString()}";

                lblFirstQuestion.Text = "A. "+ row["OptionA"].ToString();
                lblSecondQuestion.Text = "b. " + row["OptionB"].ToString();
                lblThirdQuestion.Text = "c. " + row["OptionC"].ToString();
                lblFourthQuestion.Text = "d. " + row["OptionD"].ToString();

                radioBtnOptianA.Checked = false;
                radioBtnOptianB.Checked = false;
                radioBtnOptianC.Checked = false;
                radioBtnOptianD.Checked = false;

                lblNumberOfQuestions.Text = $"السؤال {index + 1} من {totalQuestions}";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();

            if (currentQuestionIndex < totalQuestions - 1)
            {
                currentQuestionIndex++;
                DisplayQuestion(currentQuestionIndex);
            }
            else
            {
                MessageBox.Show("هذا هو السؤال الأخير.");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer(); 

            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                DisplayQuestion(currentQuestionIndex);
            }
            else
            {
                MessageBox.Show("هذا هو السؤال الأول.");
            }
        }

        private string GetSelectedOption()
        {
            if (radioBtnOptianA.Checked) return "A";
            if (radioBtnOptianB.Checked) return "B";
            if (radioBtnOptianC.Checked) return "C";
            if (radioBtnOptianD.Checked) return "D";
            return null;
        }

        private void btnEndExam_Click(object sender, EventArgs e)
        {
            SaveCurrentAnswer();

            List<int> unanswered = new List<int>();
            for (int i = 0; i < totalQuestions; i++)
            {
                int questionId = Convert.ToInt32(questionsTable.Rows[i]["QuestionID"]);
                if (!userAnswers.ContainsKey(questionId) || string.IsNullOrEmpty(userAnswers[questionId]))
                {
                    unanswered.Add(i + 1);
                }
            }

            if (unanswered.Count > 0)
            {
                string questionsList = string.Join(", ", unanswered);
                MessageBox.Show(
                    $"لم تقم بالإجابة على السؤال/الأسئلة رقم: {questionsList}. يرجى الإجابة على جميع الأسئلة قبل إنهاء الامتحان.",
                    "تنبيه",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show(
                "هل أنت متأكد من رغبتك في إنهاء الامتحان؟",
                "تأكيد",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.No)
            {
                return;
            }

            int score = CalculateScore();

            examBL.SaveResult(employeeId, examId, score, remainingSeconds);

            lblResult.Text = $"لقد حصلت على {score} نقطة من أصل {totalQuestions}.";
            MessageBox.Show("تم إنهاء الامتحان. شكراً لمشاركتك.", "مبروك", MessageBoxButtons.OK, MessageBoxIcon.Information);

            examFinished = true; 
            this.Close();
        }


    }
}
