using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;

namespace QLGiaoVien.Controllers
{
    public class KhaoThiController : BaseController
    {
        // GET: KhaoThi
        public ActionResult Index(int MaGV = 0, int MaNamHoc= 0)
        {
            List<LecturerDAO> dsGV = SearchInfo_Service.GetAllLecturers();
            List<YearDAO> dsNam = SearchInfo_Service.GetAllYears();
            ViewBag.dsNam = dsNam;
            return View(dsGV);
        }

        public PartialViewResult _DanhSachKhaoThi(int MaGV = 0, int? MaNamHoc = 0)
        {
            List<KhaoThiView> lstKhaoThi = new List<KhaoThiView>();
            try
            {
                lstKhaoThi = KhaoThi_Service.GetAll(MaGV, MaNamHoc);
            }
            catch(Exception e)
            {
                throw e;
            }

            return PartialView(lstKhaoThi);
        }
    }
}