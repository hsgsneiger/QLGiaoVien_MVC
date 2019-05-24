using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLGiaoVien.Controllers
{
    public class NghienCuuController : BaseController
    {
        // GET: NghienCuu
        public ActionResult Index()
        {

            List<LecturerDAO> lstLecturers = SearchInfo_Service.GetAllLecturers();
            List<YearDAO> lstYears = SearchInfo_Service.GetAllYears();
            ViewBag.lstYears = lstYears;
            return View(lstLecturers);
        }
        public PartialViewResult _DanhSach(int MaGV = 0, int? MaNamHoc = null)
        {
            List<ResearchView> list = new List<ResearchView>();
            //List<GuideView> list = HuongDan_Service.GetAll(MaGV, MaNamHoc);
            try
            {
                list = Research_Service.GetAll(MaGV, MaNamHoc);
            } catch(Exception e)
            {
                throw e;
            }
            return PartialView(list);
        }
    }
}