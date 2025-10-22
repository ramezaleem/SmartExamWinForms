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
    public partial class FrmAdminDashboard : Form
    {

        public FrmAdminDashboard()
        {
            InitializeComponent();

            // من Properties:
            btnManageExams.BackColor = ColorTranslator.FromHtml("#2980B9");
            btnManageExams.ForeColor = Color.White;
            btnManageExams.FlatStyle = FlatStyle.Flat;
            btnManageExams.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#1F618D");
            btnManageExams.FlatAppearance.BorderSize = 1;

            btnManageQuestions.BackColor = ColorTranslator.FromHtml("#5D6D7E");
            btnManageQuestions.ForeColor = Color.White;
            btnManageQuestions.FlatStyle = FlatStyle.Flat;
            btnManageQuestions.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#4A5863");
            btnManageQuestions.FlatAppearance.BorderSize = 1;


            // Hover effect:
            btnManageQuestions.MouseEnter += (s, e) =>
            {
                btnManageQuestions.BackColor = ColorTranslator.FromHtml("#85929E");
            };
            btnManageQuestions.MouseLeave += (s, e) =>
            {
                btnManageQuestions.BackColor = ColorTranslator.FromHtml("#5D6D7E");
            };

            btnManageExams.MouseEnter += (s, e) =>
            {
                btnManageExams.BackColor = ColorTranslator.FromHtml("#3498DB"); // أزرق فاتح
            };
            btnManageExams.MouseLeave += (s, e) =>
            {
                btnManageExams.BackColor = ColorTranslator.FromHtml("#2980B9"); // الأزرق الأساسي
            };

            btnViewResults.MouseEnter += (s, e) =>
            {
                btnViewResults.BackColor = ColorTranslator.FromHtml("#6E8B74"); // فاتح شوية
            };

            btnViewResults.MouseLeave += (s, e) =>
            {
                btnViewResults.BackColor = ColorTranslator.FromHtml("#4E7253"); // اللون الأساسي
            };

            btnExit.MouseEnter += (s, e) =>
            {
                btnExit.BackColor = ColorTranslator.FromHtml("#E74C3C"); // أحمر أفتح وقت المرور
            };

            btnExit.MouseLeave += (s, e) =>
            {
                btnExit.BackColor = ColorTranslator.FromHtml("#C0392B"); // يرجع للون الأساسي
            };
        }

        private void btnManageExams_Click(object sender, EventArgs e)
        {
            FrmManageExams frm = new FrmManageExams();
            frm.ShowDialog();
        }


        private void btnViewResults_Click(object sender, EventArgs e)
        {
            FrmViewResults frm = new FrmViewResults();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdminDashboard_Load(object sender, EventArgs e)
        {

        }

        //private void btnManageQuetions_Click(object sender, EventArgs e)
        //{
        //    FrmManageQuestions frm = new FrmManageQuestions();
        //    frm.ShowDialog();
        //}


    }
}
