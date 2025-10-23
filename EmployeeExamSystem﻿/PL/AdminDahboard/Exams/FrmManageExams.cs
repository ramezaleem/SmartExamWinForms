using EmployeeExamSystem_.BL;
using EmployeeExamSystem_.PL.AdminDahboard.Questions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeExamSystem_.PL.AdminDahboard
{
    public partial class FrmManageExams : Form
    {
        ExamsManager examsManager = new ExamsManager();
        private enum FormMode { None, Add, Edit }
        private FormMode currentMode = FormMode.None;
        int selectedExamId = 0;

        public FrmManageExams()
        {

            InitializeComponent();
        }

        private void FrmManageExams_Load(object sender, EventArgs e)
        {
            try
            {
                dgvExams.AutoGenerateColumns = true;
                dgvExams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvExams.MultiSelect = false;
                dgvExams.ReadOnly = true;
                dgvExams.AllowUserToAddRows = false;
                dgvExams.AllowUserToDeleteRows = false;

                RefreshExamGrid();

                SetInitialState();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل الصفحة:\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetInitialState()
        {
            btnAddNewExam.Enabled = true;
            btnEditExam.Enabled = false;
            btnDeleteExam.Enabled = false;
            btnSaveEdit.Enabled = false;
            btnManageQuestions.Enabled = false;

            txtExamName.ReadOnly = true;
            nudPeriodTime.Enabled = false;
            dtpEndDate.Enabled = false;
            dtpStartDate.Enabled = false;
            rdBtnActive.Enabled = false;
            rdBtnNotActive.Enabled = false;

            ClearForm();
        }

        private void RefreshExamGrid()
        {
            dgvExams.DataSource = examsManager.GetAllExams();

            if (dgvExams.Columns.Contains("ExamID"))
            {
                dgvExams.Columns["ExamID"].HeaderText = "رقم الامتحان";
                dgvExams.Columns["ExamID"].Width = 70;
            }

            if (dgvExams.Columns.Contains("ExamName"))
            {
                dgvExams.Columns["ExamName"].HeaderText = "اسم الامتحان";
                dgvExams.Columns["ExamName"].Width = 230;
            }

            if (dgvExams.Columns.Contains("PeriodTimeInMinutes"))
            {
                dgvExams.Columns["PeriodTimeInMinutes"].HeaderText = "المدة بالدقائق";
                dgvExams.Columns["PeriodTimeInMinutes"].Width = 100;
            }

            if (dgvExams.Columns.Contains("StartDate"))
            {
                dgvExams.Columns["StartDate"].HeaderText = "تاريخ البداية";
                dgvExams.Columns["StartDate"].Width = 215;
            }

            if (dgvExams.Columns.Contains("EndDate"))
            {
                dgvExams.Columns["EndDate"].HeaderText = "تاريخ النهاية";
                dgvExams.Columns["EndDate"].Width = 215;
            }

            if (dgvExams.Columns.Contains("CreatedAt"))
            {
                dgvExams.Columns["CreatedAt"].HeaderText = "تاريخ الإنشاء";
                dgvExams.Columns["CreatedAt"].Width = 215;
            }

            if (dgvExams.Columns.Contains("LastModifiedDate"))
            {
                dgvExams.Columns["LastModifiedDate"].HeaderText = "آخر تعديل";
                dgvExams.Columns["LastModifiedDate"].Width = 222;
            }

            if (dgvExams.Columns.Contains("IsActive"))
            {
                dgvExams.Columns["IsActive"].HeaderText = "فعال";
                dgvExams.Columns["IsActive"].Width = 75;
            }
            dgvExams.ClearSelection();
            ClearForm();
        }

        private void ClearForm()
        {
            txtExamName.Text = "";
            nudPeriodTime.Value = 1;
            dtpEndDate.Value = DateTime.Now.AddDays(1);
            rdBtnActive.Checked = false;
            rdBtnNotActive.Checked = true;
            selectedExamId = 0;
        }

        private void btnAddNewExam_Click(object sender, EventArgs e)
        {
            txtExamName.ReadOnly = false;
            nudPeriodTime.Enabled = true;
            dtpEndDate.Enabled = true;
            dtpStartDate.Enabled = true;
            rdBtnActive.Enabled = true;
            rdBtnNotActive.Enabled = true;

            btnInsertExam.Enabled = true;
            btnEditExam.Enabled = false;
            btnSaveEdit.Enabled = false;
            btnDeleteExam.Enabled = false;
            btnAddNewExam.Enabled = false; 

            ClearForm();
        }

        private void btnEditExam_Click(object sender, EventArgs e)
        {
            if (selectedExamId <= 0)
            {
                MessageBox.Show("يرجى اختيار امتحان للتعديل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtExamName.ReadOnly = false;
            nudPeriodTime.Enabled = true;
            dtpEndDate.Enabled = true;
            dtpStartDate.Enabled = true; 
            rdBtnActive.Enabled = true;
            rdBtnNotActive.Enabled = true;

            btnAddNewExam.Enabled = false;
            btnEditExam.Enabled = false;
            btnDeleteExam.Enabled = false;
            btnManageQuestions.Enabled = false;
            btnInsertExam.Enabled = false;

            btnSaveEdit.Enabled = true;
        }

        private void btnDeleteExam_Click(object sender, EventArgs e)
        {
            if (selectedExamId <= 0)
            {
                MessageBox.Show("يرجى اختيار امتحان للحذف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("هل أنت متأكد من حذف الامتحان؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (examsManager.DeleteExam(selectedExamId))
                {
                    MessageBox.Show("تم حذف الامتحان بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshExamGrid();
                }
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (selectedExamId <= 0)
            {
                MessageBox.Show("يرجى اختيار امتحان أولاً للتعديل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string examName = txtExamName.Text.Trim();
            DateTime startDate = dtpStartDate.Value;
            int periodTime = (int)nudPeriodTime.Value;
            DateTime endDate = dtpEndDate.Value;
            bool isActive = rdBtnActive.Checked;

            if (string.IsNullOrWhiteSpace(examName))
            {
                MessageBox.Show("اسم الامتحان مطلوب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExamName.Focus();
                return;
            }

            if (examName.Length < 3)
            {
                MessageBox.Show("اسم الامتحان قصير جدًا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExamName.Focus();
                return;
            }

            if (periodTime <= 0)
            {
                MessageBox.Show("مدة الامتحان يجب أن تكون أكبر من صفر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudPeriodTime.Focus();
                return;
            }

            if (endDate <= DateTime.Now)
            {
                MessageBox.Show("تاريخ النهاية يجب أن يكون بعد تاريخ اليوم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Focus();
                return;
            }

            try
            {
                bool updated = examsManager.UpdateExam(selectedExamId, examName, periodTime, dtpStartDate.Value, dtpEndDate.Value, isActive);

                if (updated)
                {
                    MessageBox.Show("تم تعديل بيانات الامتحان بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshExamGrid();
                    SetInitialState();
                }
                else
                {
                    MessageBox.Show("حدث خطأ أثناء تعديل الامتحان", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvExams.Rows[e.RowIndex];
                selectedExamId = Convert.ToInt32(row.Cells["ExamID"].Value);

                txtExamName.Text = row.Cells["ExamName"].Value.ToString();
                nudPeriodTime.Value = Convert.ToInt32(row.Cells["PeriodTimeInMinutes"].Value);

                dtpStartDate.Value = Convert.ToDateTime(row.Cells["StartDate"].Value);
                dtpEndDate.Value = Convert.ToDateTime(row.Cells["EndDate"].Value);

                rdBtnActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
                rdBtnNotActive.Checked = !rdBtnActive.Checked;

                txtExamName.ReadOnly = true;
                nudPeriodTime.Enabled = false;
                dtpEndDate.Enabled = false;
                dtpStartDate.Enabled = false;
                rdBtnActive.Enabled = false;
                rdBtnNotActive.Enabled = false;

                btnEditExam.Enabled = true;
                btnDeleteExam.Enabled = true;
                btnSaveEdit.Enabled = false;
                btnAddNewExam.Enabled = true;
            }
        }

        private void dgvExams_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvExams == null || dgvExams.SelectedRows == null)
                return;

            bool hasSelection = dgvExams.SelectedRows.Count > 0;

            btnEditExam.Enabled = hasSelection;
            btnDeleteExam.Enabled = hasSelection;
            btnManageQuestions.Enabled = hasSelection;

            btnAddNewExam.Enabled = true;
            btnInsertExam.Enabled = false;
        }

        private void btnManageQuestions_Click(object sender, EventArgs e)
        {
            if (dgvExams.SelectedRows.Count == 0)
            {
                MessageBox.Show("من فضلك اختر امتحان أولًا لإدارة أسئلته.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int examId = Convert.ToInt32(dgvExams.SelectedRows[0].Cells["ExamID"].Value);
            FrmManageQuestions frm = new FrmManageQuestions(examId);
            frm.ShowDialog();
        }

        private void btnInsertExam_Click(object sender, EventArgs e)
        {
            string examName = txtExamName.Text.Trim();
            int periodTime = (int)nudPeriodTime.Value;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            bool isActive = rdBtnActive.Checked;

            if (string.IsNullOrWhiteSpace(examName))
            {
                MessageBox.Show("اسم الامتحان مطلوب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExamName.Focus();
                return;
            }

            if (examName.Length < 3)
            {
                MessageBox.Show("اسم الامتحان قصير جدًا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExamName.Focus();
                return;
            }

            if (periodTime <= 0)
            {
                MessageBox.Show("مدة الامتحان يجب أن تكون أكبر من صفر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudPeriodTime.Focus();
                return;
            }

            if (endDate <= DateTime.Now)
            {
                MessageBox.Show("تاريخ النهاية يجب أن يكون بعد تاريخ اليوم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Focus();
                return;
            }

            try
            {
                bool added = examsManager.AddExam(examName, periodTime, dtpStartDate.Value, dtpEndDate.Value, isActive);

                if (added)
                {
                    MessageBox.Show("تم إضافة الامتحان بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshExamGrid();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("حدث خطأ أثناء إضافة الامتحان", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvExams_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int examId = Convert.ToInt32(dgvExams.Rows[e.RowIndex].Cells["ExamID"].Value);
                    string examName = dgvExams.Rows[e.RowIndex].Cells["ExamName"].Value.ToString();

                    FrmViewQuestions frm = new FrmViewQuestions(examId, examName);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء فتح صفحة عرض الأسئلة:\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
    }
}
