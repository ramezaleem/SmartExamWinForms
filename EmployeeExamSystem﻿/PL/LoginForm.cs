using EmployeeExamSystem_.BL;
using EmployeeExamSystem_.PL.AdminDahboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeExamSystem_.PL
{
    public partial class LoginForm : Form
    {
        UserManager userManager = new UserManager();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmAdminDashboard frmAdmin = new FrmAdminDashboard();
            bool isAdmin;
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("يرجى إدخال اسم المستخدم وكلمة المرور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {   
                UserManager userManager = new UserManager();
                bool loginSuccess = userManager.Login(userName, password, out isAdmin);

                if (loginSuccess)
                {
                    if (isAdmin)
                    {
                        MessageBox.Show("تم تسجيل الدخول كمسؤول (Admin)", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmAdmin.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("تم تسجيل الدخول كموظف", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("خطأ في اسم المستخدم أو كلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("خطأ في الاتصال بقاعدة البيانات: " + sqlEx.Message, "خطأ اتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ غير متوقع أثناء عملية تسجيل الدخول: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Green;
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = btnCancel.BackColor;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
