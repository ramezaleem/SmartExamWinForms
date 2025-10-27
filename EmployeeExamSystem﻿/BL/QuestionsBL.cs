using System.Data;
using EmployeeExamSystem_.DAL;

namespace EmployeeExamSystem_.BL
{
    public class QuestionsBL
    {
        private readonly QuestionsDAL _questionsDAL;

        public QuestionsBL()
        {
            _questionsDAL = new QuestionsDAL();
        }

        public DataTable GetQuestionsByExamId(int examId)
        {
            return _questionsDAL.GetQuestionsByExamId(examId);
        }

        public void AddQuestion(int examId, string questionText, string optionA, string optionB, string optionC, string optionD, string correctOption)
        {
            if (string.IsNullOrWhiteSpace(questionText))
                throw new System.Exception("نص السؤال لا يمكن أن يكون فارغًا");

            if (string.IsNullOrWhiteSpace(correctOption))
                throw new System.Exception("يجب تحديد الإجابة الصحيحة");

            int nextQuestionId = _questionsDAL.GetNextQuestionId(examId);

            _questionsDAL.InsertQuestion(nextQuestionId, examId, questionText, optionA, optionB, optionC, optionD, correctOption);
        }

        public void EditQuestion(int questionId, string questionText, string optionA, string optionB, string optionC, string optionD, string correctOption)
        {
            if (questionId <= 0)
                throw new System.Exception("رقم السؤال غير صالح");

            if (string.IsNullOrWhiteSpace(questionText))
                throw new System.Exception("نص السؤال لا يمكن أن يكون فارغًا");

            _questionsDAL.UpdateQuestion(questionId, questionText, optionA, optionB, optionC, optionD, correctOption);
        }

        public void DeleteQuestion(int questionId)
        {
            if (questionId <= 0)
                throw new System.Exception("رقم السؤال غير صالح");

            _questionsDAL.DeleteQuestion(questionId);
        }
    }
}
