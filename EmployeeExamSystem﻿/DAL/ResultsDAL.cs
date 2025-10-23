using System.Data;
using System.Data.SqlClient;

namespace EmployeeExamSystem_.DAL
{
    public class ResultsDAL
    {
        private readonly string _connectionString =
            "Data Source=.;Initial Catalog=EmployeesTestDB;Integrated Security=True;TrustServerCertificate=True;";

        public DataTable GetAllExams()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"SELECT ExamID, ExamName FROM Exams ORDER BY ExamID";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
            }

            return dt;
        }

        public DataTable GetExamResults(int examId)
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=.;Initial Catalog=EmployeesTestDB;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                em.EmpName AS EmployeeName,
                e.ExamName,
                er.Score,
                er.StartTimeExam,
                er.EndTimeExam
            FROM EmployeeExamResults er
            INNER JOIN Employees em ON em.ID = er.EmployeeID
            INNER JOIN Exams e ON e.ExamID = er.ExamID
            WHERE er.ExamID = @ExamID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ExamID", examId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }


    }
}
