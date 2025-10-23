using EmployeeExamSystem_.BL;
using System;
using System.Data;
using System.Windows.Forms;

namespace EmployeeExamSystem_.PL.AdminDahboard.Results
{
    public partial class FrmViewResultOfExam : Form
    {
        private readonly int _examId;
        private readonly string _examName;
        private readonly ResultsBL _resultsBL;

        public FrmViewResultOfExam(int examId, string examName)
        {
            InitializeComponent();
            this.Load += FrmViewResultOfExam_Load;
            _examId = examId;
            _examName = examName;
            _resultsBL = new ResultsBL();
        }

        private void FrmViewResultOfExam_Load(object sender, EventArgs e)
        {
            lblNameOfExam.Text = $"نتائج الامتحان: {_examName}";
            LoadExamResults();
        }

        private void LoadExamResults()
        {
            try
            {
                DataTable dt = _resultsBL.GetExamResults(_examId);

                if (dt == null || dt.Rows.Count == 0)
                {
                    dt = new DataTable();
                    dt.Columns.Add("EmployeeName");
                    dt.Columns.Add("ExamName");
                    dt.Columns.Add("Score");
                    dt.Columns.Add("StartTimeExam");
                    dt.Columns.Add("EndTimeExam");
                }

                dgvExamsResults.AutoGenerateColumns = false;
                dgvExamsResults.DataSource = null;
                dgvExamsResults.Columns.Clear();

                dgvExamsResults.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "EmployeeName",
                    HeaderText = "اسم الموظف",
                    Name = "EmployeeName"
                });
                dgvExamsResults.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ExamName",
                    HeaderText = "اسم الامتحان",
                    Name = "ExamName"
                });
                dgvExamsResults.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Score",
                    HeaderText = "الدرجة",
                    Name = "Score"
                });
                dgvExamsResults.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "StartTimeExam",
                    HeaderText = "بداية الامتحان",
                    Name = "StartTimeExam"
                });
                dgvExamsResults.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "EndTimeExam",
                    HeaderText = "نهاية الامتحان",
                    Name = "EndTimeExam"
                });

                dgvExamsResults.DataSource = dt;

                dgvExamsResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvExamsResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvExamsResults.ReadOnly = true;
                dgvExamsResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvExamsResults.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvExamsResults.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvExamsResults.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل نتائج الامتحان:\n{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
