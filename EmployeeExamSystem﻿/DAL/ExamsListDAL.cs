using System;
using System.Data;
using System.Data.SqlClient;

public class ExamsListDAL
{
    private readonly string connectionString = "Server=.;Database=EmployeesTestDB;Trusted_Connection=True;";

    public DataTable GetExamsWithStatus()
    {
        DataTable dt = new DataTable();

        string query = @"
        SELECT 
            ExamID, 
            ExamName, 
            StartDate, 
            EndDate, 
            PeriodTimeInMinutes,
            CASE
                WHEN IsActive = 1 THEN N'متاح'
                ELSE N'غير متاح'
            END AS Status
        FROM Exams";

        using (SqlConnection conn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("حدث خطأ أثناء جلب بيانات الامتحانات: " + ex.Message);
            }
        }
        return dt;
    }
}
