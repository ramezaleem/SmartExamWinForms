using System;
using System.Data;
using System.Data.SqlClient;

public class ExamQuestionsDAL
{
    private readonly string connectionString = "Server=.;Database=EmployeesTestDB;Trusted_Connection=True;";

    public DataTable GetExamQuestions(int examId)
    {
        DataTable dt = new DataTable();
        string query = @"
        SELECT 
            QuestionID, 
            QuestionText, 
            OptionA, 
            OptionB, 
            OptionC, 
            OptionD, 
            CorrectOption
        FROM ExamQuestions
        WHERE ExamID = @ExamID";

        using (SqlConnection conn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@ExamID", examId);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
        }
        return dt;
    }
    public int CalculateScore(int employeeId, int examId)
    {
        int score = 0;

        string query = @"
        SELECT EQ.CorrectOption, EA.SelectedOption
        FROM ExamQuestions EQ
        LEFT JOIN EmployeeAnswers EA ON EQ.QuestionID = EA.QuestionID AND EA.EmployeeID = @EmployeeID
        WHERE EQ.ExamID = @ExamID";

        using (SqlConnection conn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            cmd.Parameters.AddWithValue("@ExamID", examId);
            conn.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string correctOption = reader["CorrectOption"].ToString();
                    string selectedOption = reader["SelectedOption"] != DBNull.Value ? reader["SelectedOption"].ToString() : "";

                    if (!string.IsNullOrEmpty(selectedOption) && selectedOption == correctOption)
                    {
                        score++;
                    }
                }
            }
        }

        return score;
    }

    public int GetExamPeriodTime(int examId)
    {
        int period = 0;
        string query = "SELECT PeriodTimeInMinutes FROM Exams WHERE ExamID = @ExamID";
        using (SqlConnection conn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@ExamID", examId);
            conn.Open();
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                period = Convert.ToInt32(result);
            }
        }
        return period;
    }
    public int GetRemainingTime(int employeeId, int examId)
    {
        int timeLeft = -1;
        string query = "SELECT TimeLeftInSeconds FROM EmployeeExamResults WHERE EmployeeID = @EmployeeID AND ExamID = @ExamID";

        using (SqlConnection conn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            cmd.Parameters.AddWithValue("@ExamID", examId);
            conn.Open();
            object result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
                timeLeft = Convert.ToInt32(result);
        }

        return timeLeft;
    }
    public void UpdateRemainingTime(int employeeId, int examId, int timeLeftInSeconds)
    {
        string query = "UPDATE EmployeeExamResults SET TimeLeftInSeconds = @TimeLeftInSeconds WHERE EmployeeID = @EmployeeID AND ExamID = @ExamID";

        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                cmd.Parameters.AddWithValue("@ExamID", examId);
                cmd.Parameters.AddWithValue("@TimeLeftInSeconds", timeLeftInSeconds);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new Exception("خطأ في تحديث الوقت المتبقي: " + ex.Message);
        }
    }

    public string GetExamName(int examId)
    {
        string examName = "";
        string query = "SELECT ExamName FROM Exams WHERE ExamID = @ExamID";
        using (SqlConnection conn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@ExamID", examId);
            conn.Open();
            object result = cmd.ExecuteScalar();
            if (result != null)
                examName = result.ToString();
        }
        return examName;
    }
    public bool EmployeeHasTakenExam(int employeeId, int examId)
    {
        bool result = false;
        string query = "SELECT COUNT(*) FROM EmployeeExamResults WHERE EmployeeID = @EmployeeID AND ExamID = @ExamID";

        using (SqlConnection conn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            cmd.Parameters.AddWithValue("@ExamID", examId);
            conn.Open();

            int count = (int)cmd.ExecuteScalar();
            result = count > 0;
        }

        return result;
    }
    public void SaveExamResult(int employeeId, int examId, int score, int timeLeftInSeconds)
    {
        string query = @"
            IF EXISTS (SELECT 1 FROM EmployeeExamResults WHERE EmployeeID = @EmployeeID AND ExamID = @ExamID)
            BEGIN
                UPDATE EmployeeExamResults
                SET Score = @Score,
                    StartTimeExam = CASE WHEN StartTimeExam IS NULL THEN GETDATE() ELSE StartTimeExam END,
                    EndTimeExam = GETDATE(),
                    TimeLeftInSeconds = @TimeLeftInSeconds
                WHERE EmployeeID = @EmployeeID AND ExamID = @ExamID
            END
            ELSE
            BEGIN
                INSERT INTO EmployeeExamResults(EmployeeID, ExamID, Score, StartTimeExam, EndTimeExam, TimeLeftInSeconds)
                VALUES(@EmployeeID, @ExamID, @Score, GETDATE(), GETDATE(), @TimeLeftInSeconds)
            END";

        using (SqlConnection conn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            cmd.Parameters.AddWithValue("@ExamID", examId);
            cmd.Parameters.AddWithValue("@Score", score);
            cmd.Parameters.AddWithValue("@TimeLeftInSeconds", timeLeftInSeconds);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public int CountQuestionsByExamId(int examId)
    {
        int count = 0;
        string query = "SELECT COUNT(*) FROM ExamQuestions WHERE ExamID = @ExamID";

        using (SqlConnection conn = new SqlConnection(connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@ExamID", examId);
            conn.Open();
            count = (int)cmd.ExecuteScalar();
        }
        return count;
    }




}
