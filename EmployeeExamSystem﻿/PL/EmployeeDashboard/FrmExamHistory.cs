using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeExamSystem_.PL.EmployeeDashboard
{
    public partial class FrmExamHistory : Form
    {
        private int employeeId;
        private ExamsResultsBL examsResultsBL = new ExamsResultsBL();

        public FrmExamHistory(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            this.Load += FrmExamHistory_Load;

            this.Size = new Size(984, 456);
            this.BackColor = ColorTranslator.FromHtml("#F8F9F9");
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "سجل امتحاناتك";

            dgvExamsResult.BackgroundColor = Color.White;
            dgvExamsResult.EnableHeadersVisualStyles = false;
            dgvExamsResult.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E86C1");
            dgvExamsResult.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvExamsResult.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#34495E");
            dgvExamsResult.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5DADE2");
            dgvExamsResult.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvExamsResult.GridColor = ColorTranslator.FromHtml("#D6DBDF");

            dgvExamsResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExamsResult.ColumnHeadersHeight = 35;
            dgvExamsResult.RowTemplate.Height = 30;
            dgvExamsResult.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvExamsResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        private void FrmExamHistory_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtResults = examsResultsBL.GetExamResultsByEmployee(employeeId);

                if (dtResults == null || dtResults.Rows.Count == 0)
                {
                    MessageBox.Show("لم تقم بأداء أي امتحان سابقاً.", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }

                dgvExamsResult.DataSource = dtResults;

                dgvExamsResult.Columns["ExamID"].Visible = false;

                dgvExamsResult.Columns["ExamName"].HeaderText = "اسم الامتحان";
                dgvExamsResult.Columns["Score"].HeaderText = "الدرجة";
                dgvExamsResult.Columns["DurationInMinutes"].HeaderText = "مدة الامتحان (دقائق)";
                dgvExamsResult.Columns["StartTimeExam"].HeaderText = "بداية الامتحان";
                dgvExamsResult.Columns["EndTimeExam"].HeaderText = "نهاية الامتحان";
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل نتائج الامتحانات: " + ex.Message,
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

    }
}
