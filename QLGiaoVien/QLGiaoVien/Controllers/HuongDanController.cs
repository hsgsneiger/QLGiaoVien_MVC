using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLGiaoVien.Controllers
{
    public class HuongDanController : BaseController
    {
        // GET: HuongDan
        public ActionResult Index(int MaGV = 0, int MaNamHoc = 0)
        {
            List<LecturerDAO> lstLecturers = SearchInfo_Service.GetAllLecturers();
            List<YearDAO> lstYears = SearchInfo_Service.GetAllYears();
            ViewBag.lstYears = lstYears;
            return View(lstLecturers);
        }
        public PartialViewResult _DanhSach(int MaGV = 0, int? MaNamHoc=null)
        {
            List<GuideView> list = HuongDan_Service.GetAll(MaGV, MaNamHoc);
            return PartialView(list);
        }
    }
}