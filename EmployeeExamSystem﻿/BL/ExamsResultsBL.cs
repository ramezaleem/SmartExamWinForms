using System;
using System.Data;

public class ExamsResultsBL
{
    private ExamsResultsDAL resultsDAL = new ExamsResultsDAL();

    public DataTable GetExamResultsByEmployee(int employeeId)
    {
        return resultsDAL.GetExamResultsByEmployee(employeeId);
    }
}
