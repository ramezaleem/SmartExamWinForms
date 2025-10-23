using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

                // لو مفيش بيانات نرجع بدري
                if (questions == null || questions.Rows.Count == 0)
                {
                    dgvQuestions.DataSource = null;
                    return;
                }

                // التأكد من وجود العمود QuestionNumber
                if (!questions.Columns.Contains("QuestionNumber"))
                    questions.Columns.Add("QuestionNumber", typeof(int));

                // ترتيب الأسئلة حسب QuestionID (لضمان الترتيب الصحيح)
                var orderedRows = questions.AsEnumerable()
                                           .OrderBy(r => Convert.ToInt32(r["QuestionID"]))
                                           .ToList();

                // تعبئة أرقام الأسئلة المتسلسلة
                for (int i = 0; i < orderedRows.Count; i++)
                {
                    orderedRows[i]["QuestionNumber"] = i + 1;
                }

                // إعادة تحميل البيانات بعد الترتيب
                dgvQuestions.DataSource = orderedRows.CopyToDataTable();

                // إخفاء عمود QuestionID
                if (dgvQuestions.Columns.Contains("QuestionID"))
                    dgvQuestions.Columns["QuestionID"].Visible = false;

                // تنسيق عمود رقم السؤال
                if (dgvQuestions.Columns.Contains("QuestionNumber"))
                {
                    dgvQuestions.Columns["QuestionNumber"].HeaderText = "رقم السؤال";
                    dgvQuestions.Columns["QuestionNumber"].Width = 80;
                    dgvQuestions.Columns["QuestionNumber"].DisplayIndex = 0;
                }

                // تنسيقات الأعمدة الأخرى
                if (dgvQuestions.Columns.Contains("QuestionText"))
                {
                    dgvQuestions.Columns["QuestionText"].HeaderText = "نص السؤال";
                    dgvQuestions.Columns["QuestionText"].Width = 500;
                }
                if (dgvQuestions.Columns.Contains("OptionA"))
                {
                    dgvQuestions.Columns["OptionA"].HeaderText = "الاختيار أ";
                    dgvQuestions.Columns["OptionA"].Width = 160;
                }
                if (dgvQuestions.Columns.Contains("OptionB"))
                {
                    dgvQuestions.Columns["OptionB"].HeaderText = "الاختيار ب";
                    dgvQuestions.Columns["OptionB"].Width = 160;
                }
                if (dgvQuestions.Columns.Contains("OptionC"))
                {
                    dgvQuestions.Columns["OptionC"].HeaderText = "الاختيار ج";
                    dgvQuestions.Columns["OptionC"].Width = 160;
                }
                if (dgvQuestions.Columns.Contains("OptionD"))
                {
                    dgvQuestions.Columns["OptionD"].HeaderText = "الاختيار د";
                    dgvQuestions.Columns["OptionD"].Width = 160;
                }
                if (dgvQuestions.Columns.Contains("CorrectOption"))
                {
                    dgvQuestions.Columns["CorrectOption"].HeaderText = "الإجابة الصحيحة";
                    dgvQuestions.Columns["CorrectOption"].Width = 128;
                }

                // إعدادات العرض العامة
                dgvQuestions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvQuestions.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvQuestions.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvQuestions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvQuestions.ReadOnly = true;
                dgvQuestions.ClearSelection();
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
