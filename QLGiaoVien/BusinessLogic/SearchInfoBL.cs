using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace BusinessLogic
{
    public class SearchInfoBL
    {
        public List<LecturerDAO> GetAllLecturers()
        {
            return new SqlHelper<LecturerDAO>().ExecuteProcAndGetData("CTLecturer_GetAll");
        }

        public List<YearDAO> GetAllYears()
        {
            return new SqlHelper<YearDAO>().ExecuteProcAndGetData("CTYear_GetAll");
        }
    }
}
