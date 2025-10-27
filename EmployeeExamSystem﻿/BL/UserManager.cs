using EmployeeExamSystem_.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExamSystem_.BL
{
    internal class UserManager
    {
        UserDAL userDAL = new UserDAL();

        public bool Login(string userName, string password, out bool isAdmin, out int employeeId)
        {
            return userDAL.ValidateUser(userName, password, out isAdmin, out employeeId);
        }


    }
}
