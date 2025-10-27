using System;
using System.Data;
using System.Data.SqlClient;

public class ExamsResultsDAL
{
    private readonly string connectionString = "Server=.;Database=EmployeesTestDB;Trusted_Connection=True;";

    public DataTable GetExamResultsByEmployee(int employeeId)
    {
        DataTable dt = new DataTable();

        string query = @"
        SELECT 
            ER.ExamID,
            E.ExamName,
            ER.Score,
            DATEDIFF(MINUTE, ER.StartTimeExam, ER.EndTimeExam) AS DurationInMinutes,
            ER.StartTimeExam,
            ER.EndTimeExam
        FROM EmployeeExamResults ER
        INNER JOIN Exams E ON ER.ExamID = E.ExamID
        WHERE ER.EmployeeID = @EmployeeID
        ORDER BY ER.EndTimeExam DESC";

        using (SqlConnection conn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        }

        return dt;
    }


}
