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
            List<LecturerDAO> dsGV = Configuration_Service.GetAllLecturers();
            List<YearDAO> dsNam = Configuration_Service.GetAllYears();
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

        public PartialViewResult _ChiTietKhaoThi(int ID = 0)
        {
            List<KhaoThi_LoaiKT> lstLKT = new List<KhaoThi_LoaiKT>();
            KhaoThi_Insert_Update KhaoThiInfo = new KhaoThi_Insert_Update();
            try
            {
                if (!ID.Equals(0))
                {
                    KhaoThiInfo = KhaoThi_Service.GetByID(ID).FirstOrDefault();                                   
                }
                lstLKT = Configuration_Service.LoaiKhaoThi_GetAll();
                ViewBag.lstLKT = lstLKT;
            }
            catch(Exception e)
            {
                throw e;
            }

            return PartialView(KhaoThiInfo);
        }
    }
}