using System;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeExamSystem_.DAL
{
    public class QuestionsDAL
    {
        private readonly string _connectionString = "Data Source=.;Initial Catalog=EmployeesTestDB;Integrated Security=True;";

        public int GetNextQuestionId()
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(QuestionID), 0) + 1 FROM ExamQuestions", con);
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
        public DataTable GetQuestionsByExamId(int examId)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ExamQuestions WHERE ExamID = @ExamID", con);
                cmd.Parameters.AddWithValue("@ExamID", examId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void InsertQuestion(int questionId, int examId, string questionText, string optionA, string optionB, string optionC, string optionD, string correctOption)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO ExamQuestions 
                                (QuestionID, ExamID, QuestionText, OptionA, OptionB, OptionC, OptionD, CorrectOption)
                                 VALUES (@QuestionID, @ExamID, @QuestionText, @OptionA, @OptionB, @OptionC, @OptionD, @CorrectOption)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@QuestionID", questionId);
                cmd.Parameters.AddWithValue("@ExamID", examId);
                cmd.Parameters.AddWithValue("@QuestionText", questionText);
                cmd.Parameters.AddWithValue("@OptionA", optionA);
                cmd.Parameters.AddWithValue("@OptionB", optionB);
                cmd.Parameters.AddWithValue("@OptionC", optionC);
                cmd.Parameters.AddWithValue("@OptionD", optionD);
                cmd.Parameters.AddWithValue("@CorrectOption", correctOption);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }   

        public void UpdateQuestion(int questionId, string questionText, string optionA, string optionB, string optionC, string optionD, string correctOption)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                string query = @"UPDATE ExamQuestions 
                                 SET QuestionText = @QuestionText, OptionA = @OptionA, OptionB = @OptionB, 
                                     OptionC = @OptionC, OptionD = @OptionD, CorrectOption = @CorrectOption
                                 WHERE QuestionID = @QuestionID";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@QuestionID", questionId);
                cmd.Parameters.AddWithValue("@QuestionText", questionText);
                cmd.Parameters.AddWithValue("@OptionA", optionA);
                cmd.Parameters.AddWithValue("@OptionB", optionB);
                cmd.Parameters.AddWithValue("@OptionC", optionC);
                cmd.Parameters.AddWithValue("@OptionD", optionD);
                cmd.Parameters.AddWithValue("@CorrectOption", correctOption);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteQuestion(int questionId)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM ExamQuestions WHERE QuestionID = @QuestionID", con);
                cmd.Parameters.AddWithValue("@QuestionID", questionId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
