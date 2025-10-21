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
            RefreshExamGrid();
            SetInitialState();
        }

        private void SetInitialState()
        {
            btnAddExam.Enabled = true;
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
        }

        private void RefreshExamGrid()
        {
            dgvExams.DataSource = examsManager.GetAllExams();
            dgvExams.Columns["ExamID"].HeaderText = "رقم الامتحان";
            dgvExams.Columns["ExamName"].HeaderText = "اسم الامتحان";
            dgvExams.Columns["PeriodTimeInMinutes"].HeaderText = "المدة بالدقائق";
            dgvExams.Columns["EndDate"].HeaderText = "تاريخ النهاية";
            dgvExams.Columns["CreatedAt"].HeaderText = "تاريخ الإنشاء";
            dgvExams.Columns["LastModifiedDate"].HeaderText = "آخر تعديل";
            dgvExams.Columns["IsActive"].HeaderText = "فعال";

            dgvExams.Columns["ExamID"].Width = 70;
            dgvExams.Columns["ExamName"].Width = 250;
            dgvExams.Columns["PeriodTimeInMinutes"].Width = 100;
            dgvExams.Columns["EndDate"].Width = 220;
            dgvExams.Columns["CreatedAt"].Width = 220;
            dgvExams.Columns["LastModifiedDate"].Width = 220;
            dgvExams.Columns["IsActive"].Width = 75;

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

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            currentMode = FormMode.Add;

            txtExamName.ReadOnly = false;
            nudPeriodTime.ReadOnly = false;
            dtpEndDate.Enabled = true;
            rdBtnActive.Enabled = true;
            rdBtnNotActive.Enabled = true;

            btnSaveEdit.Enabled = true;
            btnAddExam.Enabled = false;
            btnEditExam.Enabled = false;
            btnDeleteExam.Enabled = false;

            ClearForm(); 
        }

        private void btnEditExam_Click(object sender, EventArgs e)
        {
            if (selectedExamId <= 0) return;

            currentMode = FormMode.Edit;

            txtExamName.ReadOnly = false;
            nudPeriodTime.ReadOnly = false;
            dtpEndDate.Enabled = true;
            rdBtnActive.Enabled = true;
            rdBtnNotActive.Enabled = true;

            btnSaveEdit.Enabled = true;
            btnAddExam.Enabled = false;
            btnEditExam.Enabled = false;
            btnDeleteExam.Enabled = false;
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
            bool isActive = rdBtnActive.Checked;

            if (currentMode == FormMode.Add)
            {
                if (examsManager.AddExam(txtExamName.Text, (int)nudPeriodTime.Value, dtpEndDate.Value, isActive))
                {
                    MessageBox.Show("تم إضافة الامتحان بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshExamGrid();
                    SetInitialState();
                }
            }
            else if (currentMode == FormMode.Edit)
            {
                if (examsManager.UpdateExam(selectedExamId, txtExamName.Text, (int)nudPeriodTime.Value, dtpEndDate.Value, isActive))
                {
                    MessageBox.Show("تم تعديل بيانات الامتحان بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshExamGrid();
                    SetInitialState();
                }
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
                dtpEndDate.Value = Convert.ToDateTime(row.Cells["EndDate"].Value);
                rdBtnActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
                rdBtnNotActive.Checked = !rdBtnActive.Checked;

                txtExamName.ReadOnly = true;
                nudPeriodTime.ReadOnly = true;
                dtpEndDate.Enabled = false;
                rdBtnActive.Enabled = false;
                rdBtnNotActive.Enabled = false;

                btnEditExam.Enabled = true;
                btnDeleteExam.Enabled = true;
                btnSaveEdit.Enabled = false;
                btnAddExam.Enabled = true;
            }
        }

        private void btnManageQuestions_Click(object sender, EventArgs e)
        {
            if (selectedExamId <= 0)
            {
                MessageBox.Show("يرجى اختيار امتحان أولاً لإدارة أسئلته", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmManageQuestions frmQuestions = new FrmManageQuestions(selectedExamId);
            frmQuestions.ShowDialog();
        }

        private void btnSaveEdit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
