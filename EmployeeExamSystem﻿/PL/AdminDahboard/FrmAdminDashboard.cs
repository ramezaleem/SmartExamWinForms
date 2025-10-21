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
        }

        private void btnMnageExams_Click(object sender, EventArgs e)
        {
            FrmManageExams frm = new FrmManageExams();
            frm.ShowDialog();  
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


    }
}
