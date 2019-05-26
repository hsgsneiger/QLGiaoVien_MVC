using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLGiaoVien.Controllers
{
    public class GiangDayController : BaseController
    {
        public ActionResult Index()
        {
            List<Lecturer_DAO1> lstLecturers = lecturer_service.GetListLecturers();
            List<YearDAO> lstYears = SearchInfo_Service.GetAllYears();
            ViewBag.lstYears = lstYears;
            return View(lstLecturers);
        }
        public PartialViewResult DataGrid(int MaGV = 0, int? MaNamHoc = 3)
        {
            List<TeachTableView> data = teach_service.GetListTeaches(MaGV, MaNamHoc);

            List<ClassSizeDAO> lstClassSize = teach_service.GetListClassSize();

            ViewBag.lstClassSize = lstClassSize.ToList();
            return PartialView(data);
        }

        public ActionResult KeKhai()
        {
                        
            return View();
        }
    }
}