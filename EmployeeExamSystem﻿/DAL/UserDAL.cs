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

        public bool ValidateUser(string userName, string password, out bool isAdmin, out int employeeId)
        {
            isAdmin = false;
            employeeId = -1;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string userQuery = "SELECT ID, IsAdmin FROM [User] WHERE UserName=@UserName AND Pass=@Pass";
                using (SqlCommand cmd = new SqlCommand(userQuery, con))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Pass", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employeeId = Convert.ToInt32(reader["ID"]);
                            isAdmin = Convert.ToBoolean(reader["IsAdmin"]);
                            return true;
                        }
                    }
                }

                string empQuery = "SELECT ID FROM Employees WHERE Email=@Email AND NotActive=0";
                using (SqlCommand cmd = new SqlCommand(empQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Email", userName);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        employeeId = Convert.ToInt32(result);
                        isAdmin = false;
                        return true;
                    }
                }
            }

            return false;
        }



    }
}
