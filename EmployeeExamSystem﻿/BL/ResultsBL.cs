using System.Data;
using EmployeeExamSystem_.DAL;

namespace EmployeeExamSystem_.BL
{
    public class ResultsBL
    {
        private readonly ResultsDAL _resultsDAL;

        public ResultsBL()
        {
            _resultsDAL = new ResultsDAL();
        }

        public DataTable GetAllExams()
        {
            return _resultsDAL.GetAllExams();
        }

        public DataTable GetExamResults(int examId)
        {
            if (examId <= 0)
                throw new System.Exception("رقم الامتحان غير صالح");

            return _resultsDAL.GetExamResults(examId);
        }
    }
}
