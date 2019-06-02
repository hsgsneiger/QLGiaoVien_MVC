using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;

namespace QLGiaoVien.Controllers
{
    public class HoiDongController : BaseController
    {
        // GET: HoiDong
        public ActionResult Index()
        {
            List<LecturerDAO> dsGV = SearchInfo_Service.GetAllLecturers();
            List<YearDAO> dsNam = SearchInfo_Service.GetAllYears();
            ViewBag.dsNam = dsNam;
            return View(dsGV);
        }
        public PartialViewResult _DanhSachHoiDong(int MaGV=0, int? NamHoc=0)
        {
            List<HoiDongView> lstHoiDong = new List<HoiDongView>();
            try
            {
                lstHoiDong = Hoidong_Service.GetAll(MaGV, NamHoc);
            }
            catch(Exception e)
            {
                throw e;
            }          
            return PartialView(lstHoiDong);
        }
    }
}