using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLGiaoVien.Controllers
{
    public class BaseController : Controller
    {
        protected GuideBL HuongDan_Service = new GuideBL();
        protected SearchInfoBL SearchInfo_Service = new SearchInfoBL();
        protected ResearchBL Research_Service = new ResearchBL();


        // toanpn
        protected LecturerBL lecturer_service = new LecturerBL();
        protected DepartmentBL department_service = new DepartmentBL();
    }
}