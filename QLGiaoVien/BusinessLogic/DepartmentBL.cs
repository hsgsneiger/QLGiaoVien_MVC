using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace BusinessLogic
{
    public class DepartmentBL
    {
        public List<Department_DAO> GetListDepartments()
        {
            List<Department_DAO> lstDepartments = new SqlHelper<Department_DAO>().ExecuteProcAndGetData("GetListDepartments");

            return lstDepartments;
        }
      
    }
}
