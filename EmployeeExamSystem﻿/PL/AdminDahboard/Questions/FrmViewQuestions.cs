using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeExamSystem_.PL.AdminDahboard.Questions
{
    public partial class FrmViewQuestions : Form
    {
        private readonly int _examId;
        private readonly string _examName;

        public FrmViewQuestions(int examId, string examName)
        {
            InitializeComponent();
            _examId = examId;
            _examName = examName;
        }

        private void FrmViewQuestions_Load(object sender, EventArgs e)
        {
            lblNameOfExam.Text = $"الامتحان: {_examName}";

            LoadQuestionsForExam();
        }

        private void LoadQuestionsForExam()
        {
            try
            {
                DataTable questions = GetQuestionsByExamId(_examId);
                dgvQuestions.DataSource = questions;

                if (questions.Columns.Contains("QuestionID"))
                {
                    dgvQuestions.Columns["QuestionID"].HeaderText = "رقم السؤال";
                    dgvQuestions.Columns["QuestionID"].Width = 80;
                }
                if (questions.Columns.Contains("QuestionText"))
                {
                    dgvQuestions.Columns["QuestionText"].HeaderText = "نص السؤال";
                    dgvQuestions.Columns["QuestionText"].Width = 500;
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
                    dgvQuestions.Columns["CorrectOption"].Width = 128;
                }


                dgvQuestions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvQuestions.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvQuestions.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvQuestions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvQuestions.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل الأسئلة:\n{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private DataTable GetQuestionsByExamId(int examId)
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=.;Initial Catalog=EmployeesTestDB;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT QuestionID, QuestionText, OptionA, OptionB, OptionC, OptionD, CorrectOption
                                 FROM ExamQuestions
                                 WHERE ExamID = @ExamID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ExamID", examId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }


    }
}
