using System;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeExamSystem_.DAL
{
    internal class ExamsDAL
    {
        private string connectionString = "Server=.;Database=EmployeesTestDB;Trusted_Connection=True;";

        public DataTable GetAllExams()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT ExamID, ExamName, PeriodTimeInMinutes, StartDate, EndDate, CreatedAt, LastModifiedDate, IsActive
                                 FROM Exams";
                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        public bool AddExam(string name, int periodTime, DateTime startDate, DateTime endDate, bool isActive)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"INSERT INTO Exams 
                         (ExamName, PeriodTimeInMinutes, StartDate, EndDate, CreatedAt, LastModifiedDate, IsActive)
                         VALUES (@Name, @Time, @StartDate, @EndDate, GETDATE(), NULL, @IsActive)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Time", periodTime);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    cmd.Parameters.AddWithValue("@IsActive", isActive);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateExam(int examId, string name, int periodTime, DateTime startDate, DateTime endDate, bool isActive)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"UPDATE Exams
                         SET ExamName=@Name, PeriodTimeInMinutes=@Time, StartDate=@StartDate,
                             EndDate=@EndDate, IsActive=@IsActive, LastModifiedDate=GETDATE()
                         WHERE ExamID=@ID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", examId);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Time", periodTime);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    cmd.Parameters.AddWithValue("@IsActive", isActive);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
  
        public bool DeleteExam(int examId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"DELETE FROM Exams WHERE ExamID=@ID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", examId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
