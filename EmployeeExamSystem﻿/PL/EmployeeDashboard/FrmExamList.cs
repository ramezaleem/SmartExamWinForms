using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeExamSystem_.PL.EmployeeDashboard
{
    public partial class FrmExamList : Form
    {
        private ExamsListBL examsBL = new ExamsListBL();
        private ExamQuestionsBL examQuestionsBL = new ExamQuestionsBL();
        private string userName;
        private int employeeId;

        public FrmExamList()
        {
            InitializeComponent();
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


        public FrmExamList(int employeeId, string user)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#F8F9F9");

            lblWelcomeEmployee.ForeColor = ColorTranslator.FromHtml("#2C3E50");
            lblWelcomeEmployee.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblWelcomeEmployee.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcomeEmployee.Dock = DockStyle.Top;
            lblWelcomeEmployee.Height = 50;

            dgvExamsList.BackgroundColor = Color.White;
            dgvExamsList.EnableHeadersVisualStyles = false;
            dgvExamsList.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E86C1");
            dgvExamsList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvExamsList.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#34495E");
            dgvExamsList.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5DADE2");
            dgvExamsList.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvExamsList.GridColor = ColorTranslator.FromHtml("#D6DBDF");

            SetupButton(btnStartExam, "#2E86C1", "#5DADE2", "#1B4F72");
            SetupButton(btnShowExamsHistory, "#5D6D7E", "#85929E", "#4A5863");

            this.employeeId = employeeId;
            userName = user;
            lblWelcomeEmployee.Text = $"مرحباً بك، {userName}";
            btnStartExam.Enabled = false;
            btnStartExam.Text = "اختيار الامتحان";

            dgvExamsList.SelectionChanged += DgvExamsList_SelectionChanged;
            this.Load += FrmExamList_Load;
        }

        private void FrmExamList_Load(object sender, EventArgs e)
        {
            LoadExams();
        }

        private void LoadExams()
        {
            try
            {
                DataTable dtExams = examsBL.GetExamsForDisplay();
                dgvExamsList.DataSource = dtExams;

                dgvExamsList.DataBindingComplete += (s, e) =>
                {
                    if (dgvExamsList.Columns.Contains("ExamID"))
                    {
                        dgvExamsList.Columns["ExamID"].Visible = true;
                        dgvExamsList.Columns["ExamID"].HeaderText = "رقم الامتحان";
                        dgvExamsList.Columns["ExamID"].Width = 60;
                        dgvExamsList.Columns["ExamID"].DisplayIndex = 0;
                    }

                    if (dgvExamsList.Columns.Contains("ExamName"))
                        dgvExamsList.Columns["ExamName"].HeaderText = "اسم الامتحان";

                    if (dgvExamsList.Columns.Contains("StartDate"))
                        dgvExamsList.Columns["StartDate"].HeaderText = "تاريخ البداية";

                    if (dgvExamsList.Columns.Contains("EndDate"))
                        dgvExamsList.Columns["EndDate"].HeaderText = "تاريخ النهاية";

                    if (dgvExamsList.Columns.Contains("PeriodTimeInMinutes"))
                    {
                        dgvExamsList.Columns["PeriodTimeInMinutes"].HeaderText = "مدة الامتحان (دقائق)";
                        dgvExamsList.Columns["PeriodTimeInMinutes"].Width = 80;
                    }

                    if (dgvExamsList.Columns.Contains("Status"))
                    {
                        dgvExamsList.Columns["Status"].HeaderText = "الحالة";
                        dgvExamsList.Columns["Status"].DisplayIndex = dgvExamsList.Columns.Count - 1;
                        dgvExamsList.Columns["Status"].Width = 100;
                    }

                    dgvExamsList.ReadOnly = true;
                    dgvExamsList.MultiSelect = false;
                    dgvExamsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ في تحميل بيانات الامتحانات:{Environment.NewLine}{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvExamsList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvExamsList.CurrentRow != null)
            {
                string status = dgvExamsList.CurrentRow.Cells["Status"].Value.ToString();

                if (status == "متاح")
                {
                    btnStartExam.Enabled = true;
                    btnStartExam.Text = "ابدأ الامتحان";
                    btnStartExam.BackColor = ColorTranslator.FromHtml("#2E86C1");
                    btnStartExam.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#1B4F72");
                    btnStartExam.ForeColor = Color.White;
                }
                else
                {
                    btnStartExam.Enabled = false;
                    btnStartExam.Text = "الامتحان غير متاح";
                    btnStartExam.BackColor = ColorTranslator.FromHtml("#7B7D7D");
                    btnStartExam.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#626567");
                    btnStartExam.ForeColor = Color.White;
                }
            }
        }

        private void btnStartExam_Click(object sender, EventArgs e)
        {
            if (dgvExamsList.CurrentRow == null)
                return;

            int examId = Convert.ToInt32(dgvExamsList.CurrentRow.Cells["ExamID"].Value);

            bool hasTakenExam = examQuestionsBL.HasEmployeeTakenExam(employeeId, examId);
            if (hasTakenExam)
            {
                MessageBox.Show("لقد قمت بأداء هذا الامتحان من قبل ولا يمكنك إعادة الامتحان.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasQuestions = examQuestionsBL.ExamHasQuestions(examId);
            if (!hasQuestions)
            {
                MessageBox.Show("لا توجد أسئلة لهذا الامتحان، لا يمكن بدء الامتحان.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int remainingTime = examQuestionsBL.GetRemainingTime(employeeId, examId);
            if (remainingTime <= 0)
            {
                int periodTime = examQuestionsBL.GetExamPeriodTime(examId);
                remainingTime = periodTime * 60;
            }

            FrmExam frmExam = new FrmExam(employeeId, examId, remainingTime);
            frmExam.ShowDialog();
        }

        private void btnShowExamsHistory_Click(object sender, EventArgs e)
        {
            try
            {
                ExamsResultsBL resultsBL = new ExamsResultsBL();
                DataTable dtResults = resultsBL.GetExamResultsByEmployee(employeeId);

                if (dtResults == null || dtResults.Rows.Count == 0)
                {
                    MessageBox.Show("لا يوجد نتائج امتحانات لديك.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                FrmExamHistory historyForm = new FrmExamHistory(employeeId);
                historyForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء فتح صفحة نتائج الامتحانات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
