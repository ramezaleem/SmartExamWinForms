using EmployeeExamSystem_.BL;
using EmployeeExamSystem_.PL.AdminDahboard;
using EmployeeExamSystem_.PL.EmployeeDashboard;
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
            this.BackColor = ColorTranslator.FromHtml("#ECF0F1");

            lblWelcomeEmployees.ForeColor = ColorTranslator.FromHtml("#2C3E50");
            lblWelcomeEmployees.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblWelcomeEmployees.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcomeEmployees.Dock = DockStyle.Top;
            lblWelcomeEmployees.Height = 60;

            TextBox[] txts = { txtUserName, txtPassword };
            foreach (var txt in txts)
            {
                txt.BackColor = Color.White;
                txt.ForeColor = ColorTranslator.FromHtml("#34495E");
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.Font = new Font("Segoe UI", 10);
            }

            SetupButton(btnLogin, "#2E86C1", "#5DADE2", "#1B4F72");
            SetupButton(btnCancel, "#7B7D7D", "#A6ACAF", "#626567");
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
                int employeeId;
                bool loginSuccess = userManager.Login(userName, password, out isAdmin, out employeeId); 

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
                        FrmExamList frmExamList = new FrmExamList(employeeId, userName);
                        MessageBox.Show("تم تسجيل الدخول كموظف", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmExamList.ShowDialog();
                        this.Close();
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
