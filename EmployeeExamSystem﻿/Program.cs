using EmployeeExamSystem_.PL;
using EmployeeExamSystem_.PL.AdminDahboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeExamSystem﻿
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            //Application.Run(new FrmAdminDashboard());
            //Application.Run(new FrmManageQuestions());
            Application.Run(new FrmManageExams());
        }
    }
}
