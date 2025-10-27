using System;
using System.Data;

public class ExamQuestionsBL
{
    private ExamQuestionsDAL examDAL = new ExamQuestionsDAL();

    public DataTable GetQuestionsByExamId(int examId)
    {
        return examDAL.GetExamQuestions(examId);
    }

    public bool HasEmployeeTakenExam(int employeeId, int examId)
    {
        return examDAL.EmployeeHasTakenExam(employeeId, examId);
    }

    public bool ExamHasQuestions(int examId)
    {
        return examDAL.CountQuestionsByExamId(examId) > 0;
    }

    public int CalculateResult(int employeeId, int examId)
    {
        return examDAL.CalculateScore(employeeId, examId);
    }

    public int GetExamPeriodTime(int examId)
    {
        return examDAL.GetExamPeriodTime(examId);
    }

    public string GetExamName(int examId)
    {
        return examDAL.GetExamName(examId);
    }

    public int GetRemainingTime(int employeeId, int examId)
    {
        return examDAL.GetRemainingTime(employeeId, examId);
    }

    public void SaveResult(int employeeId, int examId, int score, int timeLeftInSeconds)
    {
        examDAL.SaveExamResult(employeeId, examId, score, timeLeftInSeconds);
    }

    public void UpdateRemainingTime(int employeeId, int examId, int timeLeftInSeconds)
    {
        examDAL.UpdateRemainingTime(employeeId, examId, timeLeftInSeconds);
    }
}
