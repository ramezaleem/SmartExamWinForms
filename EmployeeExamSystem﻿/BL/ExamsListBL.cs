using System;
using System.Data;

public class ExamsListBL
{
    private ExamsListDAL examsDAL = new ExamsListDAL();

    public DataTable GetExamsForDisplay()
    {
        DataTable dt = examsDAL.GetExamsWithStatus();
        DataView dv = dt.DefaultView;

        dv.Sort = "StartDate ASC";
        return dv.ToTable();
    }

}
