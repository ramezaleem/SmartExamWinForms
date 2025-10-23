using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

            this.BackColor = ColorTranslator.FromHtml("#F8F9F9");

            lblNameOfExam.ForeColor = ColorTranslator.FromHtml("#2C3E50");
            lblNameOfExam.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            dgvQuestions.BackgroundColor = Color.White;
            dgvQuestions.EnableHeadersVisualStyles = false;
            dgvQuestions.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E86C1");
            dgvQuestions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvQuestions.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#34495E");
            dgvQuestions.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5DADE2");
            dgvQuestions.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvQuestions.GridColor = ColorTranslator.FromHtml("#D6DBDF");
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

                // لو مفيش بيانات هننشئ جدول فاضي بنفس الأعمدة الأساسية
                if (questions == null || questions.Rows.Count == 0)
                {
                    DataTable emptyTable = new DataTable();
                    emptyTable.Columns.Add("QuestionNumber", typeof(int));
                    emptyTable.Columns.Add("QuestionText", typeof(string));
                    emptyTable.Columns.Add("OptionA", typeof(string));
                    emptyTable.Columns.Add("OptionB", typeof(string));
                    emptyTable.Columns.Add("OptionC", typeof(string));
                    emptyTable.Columns.Add("OptionD", typeof(string));
                    emptyTable.Columns.Add("CorrectOption", typeof(string));

                    dgvQuestions.DataSource = emptyTable;
                }
                else
                {
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

                    dgvQuestions.DataSource = orderedRows.CopyToDataTable();
                }

                // إخفاء عمود QuestionID لو موجود
                if (dgvQuestions.Columns.Contains("QuestionID"))
                    dgvQuestions.Columns["QuestionID"].Visible = false;

                // تنسيق الأعمدة
                if (dgvQuestions.Columns.Contains("QuestionNumber"))
                {
                    dgvQuestions.Columns["QuestionNumber"].HeaderText = "رقم السؤال";
                    dgvQuestions.Columns["QuestionNumber"].Width = 80;
                    dgvQuestions.Columns["QuestionNumber"].DisplayIndex = 0;
                }

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
