using EmployeeExamSystem_.BL;
using EmployeeExamSystem_.PL.AdminDahboard.Results;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeExamSystem_.PL.AdminDahboard
{
    public partial class FrmViewResults : Form
    {
        private readonly ResultsBL _resultsBL;

        public FrmViewResults()
        {
            InitializeComponent();
            _resultsBL = new ResultsBL();
            this.BackColor = ColorTranslator.FromHtml("#F8F9F9");

            dgvExamsResults.BackgroundColor = Color.White;
            dgvExamsResults.EnableHeadersVisualStyles = false;
            dgvExamsResults.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E86C1");
            dgvExamsResults.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvExamsResults.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#34495E");
            dgvExamsResults.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5DADE2");
            dgvExamsResults.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvExamsResults.GridColor = ColorTranslator.FromHtml("#D6DBDF");

            SetupButton(btnViewExamResults, "#2E86C1", "#5DADE2", "#1B4F72");
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

        private void FrmViewResults_Load(object sender, EventArgs e)
        {
            LoadAllExams();
        }

        private void LoadAllExams()
        {
            try
            {
                DataTable dt = _resultsBL.GetAllExams();
                dgvExamsResults.DataSource = dt;

                if (dgvExamsResults.Columns.Contains("ExamID"))
                {
                    dgvExamsResults.Columns["ExamID"].HeaderText = "رقم الامتحان";
                    dgvExamsResults.Columns["ExamID"].Width = 100;
                }

                if (dgvExamsResults.Columns.Contains("ExamName"))
                {
                    dgvExamsResults.Columns["ExamName"].HeaderText = "اسم الامتحان";
                    dgvExamsResults.Columns["ExamName"].Width = 503;
                }

                dgvExamsResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvExamsResults.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvExamsResults.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvExamsResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvExamsResults.ReadOnly = true;
                dgvExamsResults.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل الامتحانات:\n{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewExamResults_Click(object sender, EventArgs e)
        {
            if (dgvExamsResults.SelectedRows.Count == 0)
            {
                MessageBox.Show("من فضلك اختر امتحان أولًا لعرض نتائجه.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int examId = Convert.ToInt32(dgvExamsResults.SelectedRows[0].Cells["ExamID"].Value);
            string examName = dgvExamsResults.SelectedRows[0].Cells["ExamName"].Value.ToString();

            FrmViewResultOfExam frm = new FrmViewResultOfExam(examId, examName);
            frm.ShowDialog();
        }

    }
}
