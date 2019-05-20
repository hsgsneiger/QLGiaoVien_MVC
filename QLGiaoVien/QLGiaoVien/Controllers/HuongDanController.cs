using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLGiaoVien.Controllers
{
    public class HuongDanController : Controller
    {
        // GET: HuongDan
        public ActionResult Index(int MaGV = 0, int MaNamHoc = 0)
        {
            return View();
        }
    }
}