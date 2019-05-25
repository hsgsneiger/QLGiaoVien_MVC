using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using Utils;

namespace BusinessLogic
{
    public class LecturerBL
    {
        public List<Lecturer_DAO1> GetListLecturers()
        {
            List<Lecturer_DAO1> lstLecturers = new SqlHelper<Lecturer_DAO1>().ExecuteProcAndGetData("GetListLecturers");
           
            return lstLecturers;
        }
    }
}
