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
        protected HuongDanBL HuongDan_Service = new HuongDanBL();
        protected SearchInfoBL SearchInfo_Service = new SearchInfoBL();

    }
}