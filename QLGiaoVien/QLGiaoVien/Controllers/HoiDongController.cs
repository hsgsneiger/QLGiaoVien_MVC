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
        public ActionResult Index(int MaGV = 0, int MaNamHoc = 0)
        {
            List<LecturerDAO> dsGV = Configuration_Service.GetAllLecturers();
            List<YearDAO> dsNam = Configuration_Service.GetAllYears();
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
        public PartialViewResult _ChiTietHoiDong(int ID = 0)
        {
            List<HoiDong_LHD> lstLHD = new List<HoiDong_LHD>();
            List<HoiDong_MTG> lstMTG = new List<HoiDong_MTG>();
            HoiDong_Insert_Update HoiDongInfo = new HoiDong_Insert_Update();
            try
            {
                if (!ID.Equals(0))
                {
                    HoiDongInfo = Hoidong_Service.GetByID(ID).FirstOrDefault();
                    lstMTG = Configuration_Service.MucThamGia_GetBy(HoiDongInfo.LoaiHoiDong_id);
                }
                lstLHD = Configuration_Service.LoaiHoiDong_GetAll();
                ViewBag.lstLHD = lstLHD;
                ViewBag.lstMTG = lstMTG;
            }
            catch (Exception e)
            {
                throw e;
            }
            return PartialView(HoiDongInfo);
        }
        public PartialViewResult _MucThamGia(int LoaiHoiDong_id = 0)
        {
            List<HoiDong_MTG> lstMTG = new List<HoiDong_MTG>();
            try
            {
                lstMTG = Configuration_Service.MucThamGia_GetBy(LoaiHoiDong_id);
            }
            catch (Exception e)
            {
                throw e;
            }
            return PartialView(lstMTG);
        }
    }
}