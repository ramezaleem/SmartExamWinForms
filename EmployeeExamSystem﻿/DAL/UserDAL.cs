using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExamSystem_.DAL
{
    internal class UserDAL
    {
        private string connectionString = "Server=.;Database=EmployeesTestDB;Trusted_Connection=True;";

        public bool ValidateUser(string userName, string password, out bool isAdmin)
        {
            isAdmin = false;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string userQuery = "SELECT IsAdmin FROM [User] WHERE UserName=@UserName AND Pass=@Pass";
                using (SqlCommand cmd = new SqlCommand(userQuery, con))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Pass", password);

                    var result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        isAdmin = Convert.ToBoolean(result);
                        return true;
                    }
                }

                string empQuery = "SELECT COUNT(*) FROM Employees WHERE Email=@Email AND NotActive=0";
                using (SqlCommand cmd = new SqlCommand(empQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Email", userName); 

                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        isAdmin = false;
                        return true;
                    }
                }
            }

            return false; 
        }


    }
}
