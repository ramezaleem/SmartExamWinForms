using EmployeeExamSystem_.BL;
using EmployeeExamSystem_.PL.AdminDahboard.Results;
using System;
using System.Data;
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
