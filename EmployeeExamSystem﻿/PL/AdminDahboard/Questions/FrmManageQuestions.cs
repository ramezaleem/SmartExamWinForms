using EmployeeExamSystem_.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeExamSystem_.PL.AdminDahboard
{
    public partial class FrmManageQuestions : Form
    {
        private readonly int _examId;
        private QuestionsBL _questionsBL = new QuestionsBL();
        private int _selectedQuestionId = 0;
        public FrmManageQuestions(int examId)
        {
            InitializeComponent();
            _examId = examId;
            _questionsBL = new QuestionsBL();
        }

        private void FrmManageQuestions_Load(object sender, EventArgs e)
        {
            LoadQuestionsForExam();
            ResetInputs();
        }
        private void ResetInputs()
        {
            txtRefQuestion.Clear();
            txtOptionA.Clear();
            txtOptionB.Clear();
            txtOptionC.Clear();
            txtOptionD.Clear();

            radioBtnCorrectOptionA.Checked = false;
            radioBtnCorrectOptionB.Checked = false;
            radioBtnCorrectOptionC.Checked = false;
            radioBtnCorrectOptionD.Checked = false;

            _selectedQuestionId = 0;
            dgvQuestions.ClearSelection();
        }
        private void LoadQuestionsForExam()
        {
            try
            {
                DataTable questions = _questionsBL.GetQuestionsByExamId(_examId);
                dgvQuestions.DataSource = questions;

                if (questions.Columns.Contains("QuestionID"))
                {
                    dgvQuestions.Columns["QuestionID"].HeaderText = "رقم السؤال";
                    dgvQuestions.Columns["QuestionID"].Width = 60;
                }
                if (questions.Columns.Contains("QuestionText"))
                {
                    dgvQuestions.Columns["QuestionText"].HeaderText = "نص السؤال";
                    dgvQuestions.Columns["QuestionText"].Width = 400;
                }
                if (questions.Columns.Contains("OptionA"))
                {
                    dgvQuestions.Columns["OptionA"].HeaderText = "الاختيار أ";
                    dgvQuestions.Columns["OptionA"].Width = 160;
                }
                if (questions.Columns.Contains("OptionB"))
                {
                    dgvQuestions.Columns["OptionB"].HeaderText = "الاختيار ب";
                    dgvQuestions.Columns["OptionB"].Width = 160;
                }
                if (questions.Columns.Contains("OptionC"))
                {
                    dgvQuestions.Columns["OptionC"].HeaderText = "الاختيار ج";
                    dgvQuestions.Columns["OptionC"].Width = 160;
                }
                if (questions.Columns.Contains("OptionD"))
                {
                    dgvQuestions.Columns["OptionD"].HeaderText = "الاختيار د";
                    dgvQuestions.Columns["OptionD"].Width = 160;
                }
                if (questions.Columns.Contains("CorrectOption"))
                {
                    dgvQuestions.Columns["CorrectOption"].HeaderText = "الإجابة الصحيحة";
                    dgvQuestions.Columns["CorrectOption"].Width = 140;
                }

                dgvQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dgvQuestions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dgvQuestions.RowTemplate.Height = 28;
                dgvQuestions.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل الأسئلة:\n{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddNewQuestion_Click(object sender, EventArgs e)
        {
            ResetInputs();
        }
        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                string questionText = txtRefQuestion.Text.Trim();
                string optionA = txtOptionA.Text.Trim();
                string optionB = txtOptionB.Text.Trim();
                string optionC = txtOptionC.Text.Trim();
                string optionD = txtOptionD.Text.Trim();

                string correctOption = "";
                if (radioBtnCorrectOptionA.Checked) correctOption = "A";
                else if (radioBtnCorrectOptionB.Checked) correctOption = "B";
                else if (radioBtnCorrectOptionC.Checked) correctOption = "C";
                else if (radioBtnCorrectOptionD.Checked) correctOption = "D";

                _questionsBL.AddQuestion(_examId, questionText, optionA, optionB, optionC, optionD, correctOption);

                MessageBox.Show("تمت إضافة السؤال بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadQuestionsForExam();
                ResetInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء الحفظ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            if (_selectedQuestionId == 0)
            {
                MessageBox.Show("من فضلك اختر سؤال أولاً للتعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string questionText = txtRefQuestion.Text.Trim();
                string optionA = txtOptionA.Text.Trim();
                string optionB = txtOptionB.Text.Trim();
                string optionC = txtOptionC.Text.Trim();
                string optionD = txtOptionD.Text.Trim();

                string correctOption = "";
                if (radioBtnCorrectOptionA.Checked) correctOption = "A";
                else if (radioBtnCorrectOptionB.Checked) correctOption = "B";
                else if (radioBtnCorrectOptionC.Checked) correctOption = "C";
                else if (radioBtnCorrectOptionD.Checked) correctOption = "D";

                _questionsBL.EditQuestion(_selectedQuestionId, questionText, optionA, optionB, optionC, optionD, correctOption);

                MessageBox.Show("تم تعديل السؤال بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadQuestionsForExam();
                ResetInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء التعديل: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (_selectedQuestionId == 0)
            {
                MessageBox.Show("من فضلك اختر سؤال أولاً للحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("هل أنت متأكد من حذف هذا السؤال؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _questionsBL.DeleteQuestion(_selectedQuestionId);
                    MessageBox.Show("تم حذف السؤال بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadQuestionsForExam();
                    ResetInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"حدث خطأ أثناء الحذف: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvQuestions.Rows[e.RowIndex];
                _selectedQuestionId = Convert.ToInt32(row.Cells["QuestionID"].Value);
                txtRefQuestion.Text = row.Cells["QuestionText"].Value.ToString();
                txtOptionA.Text = row.Cells["OptionA"].Value.ToString();
                txtOptionB.Text = row.Cells["OptionB"].Value.ToString();
                txtOptionC.Text = row.Cells["OptionC"].Value.ToString();
                txtOptionD.Text = row.Cells["OptionD"].Value.ToString();

                string correct = row.Cells["CorrectOption"].Value.ToString();
                radioBtnCorrectOptionA.Checked = correct == "A";
                radioBtnCorrectOptionB.Checked = correct == "B";
                radioBtnCorrectOptionC.Checked = correct == "C";
                radioBtnCorrectOptionD.Checked = correct == "D";

                _selectedQuestionId = Convert.ToInt32(row.Cells["QuestionID"].Value);
            }
        }

       
    }
}
