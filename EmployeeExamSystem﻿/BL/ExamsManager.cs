using System;
using System.Data;
using System.Windows.Forms;
using EmployeeExamSystem_.DAL;

namespace EmployeeExamSystem_.BL
{
    internal class ExamsManager
    {
        ExamsDAL examsDAL = new ExamsDAL();

        public DataTable GetAllExams()
        {
            return examsDAL.GetAllExams();
        }

        public bool AddExam(string name, int periodTime, DateTime startDate, DateTime endDate, bool isActive)
        {
            if (!ValidateExamData(name, periodTime, startDate, endDate)) return false;
            return examsDAL.AddExam(name, periodTime, startDate, endDate, isActive);
        }

        public bool UpdateExam(int examId, string name, int periodTime, DateTime startDate, DateTime endDate, bool isActive)
        {
            if (examId <= 0)
            {
                MessageBox.Show("رقم الامتحان غير صالح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidateExamData(name, periodTime, startDate, endDate)) return false;
            return examsDAL.UpdateExam(examId, name, periodTime, startDate, endDate, isActive);
        }


        public bool DeleteExam(int examId)
        {
            if (examId <= 0)
            {
                MessageBox.Show("رقم الامتحان غير صالح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return examsDAL.DeleteExam(examId);
        }

        private bool ValidateExamData(string name, int periodTime, DateTime startDate, DateTime endDate)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("اسم الامتحان مطلوب", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (name.Length < 3)
            {
                MessageBox.Show("اسم الامتحان قصير جدًا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (name.Length > 200)
            {
                MessageBox.Show("اسم الامتحان طويل جدًا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (periodTime <= 0)
            {
                MessageBox.Show("مدة الامتحان يجب أن تكون أكبر من صفر", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (periodTime > 1440)
            {
                MessageBox.Show("مدة الامتحان لا يجب أن تتجاوز 24 ساعة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (startDate < DateTime.Now.Date.AddDays(-1))
            {
                MessageBox.Show("تاريخ البداية لا يمكن أن يكون في الماضي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (startDate >= endDate)
            {
                MessageBox.Show("تاريخ البداية يجب أن يكون قبل تاريخ النهاية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (endDate <= DateTime.Now)
            {
                MessageBox.Show("تاريخ النهاية يجب أن يكون بعد تاريخ اليوم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

    }
}
