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
            List<LecturerDAO> lstLecturers = Configuration_Service.GetAllLecturers();
            List<YearDAO> lstYears = Configuration_Service.GetAllYears();
            ViewBag.lstYears = lstYears;
            return View(lstLecturers);
        }
        public PartialViewResult _DanhSach(int MaGV = 0, int? MaNamHoc=null)
        {
            List<GuideView> list = new List<GuideView>();
            try
            {
                list = Guide_Service.GetAll(MaGV, MaNamHoc);
            } catch(Exception e)
            {
                throw e;
            }
            return PartialView(list);
        }
        public ActionResult ThemMoi(int MaGV = 0, int MaNamHoc=0)
        {
            
            return View();
        }

        public PartialViewResult _ChiTiet(int ID=0)
        {
            List<GuideTypeDAO> lstGuideType = new List<GuideTypeDAO>();
            Guide_Insert_Update guideInfo = new Guide_Insert_Update();
            List<GuideSystemDAO> lstGuideSystem = new List<GuideSystemDAO>();
            try
            {
                lstGuideType = Configuration_Service.GetAllGuideType();
                ViewBag.lstGuideType = lstGuideType;
                if (!ID.Equals(0))
                {
                    guideInfo = Guide_Service.GetByID(ID).FirstOrDefault();
                    lstGuideSystem = Configuration_Service.GetAllGuideSystemBy(guideInfo.LoaiHuongDan_id);
                }
                ViewBag.lstGuideSystem = lstGuideSystem;               
            }
            catch (Exception e)
            {
                throw e;
            }
            return PartialView(guideInfo);
        }
        public PartialViewResult _HeHuongDan(int LoaiHuongDan_id=0)
        {
            List<GuideSystemDAO> lstGuideSystem = new List<GuideSystemDAO>();
            try
            {
                lstGuideSystem = Configuration_Service.GetAllGuideSystemBy(LoaiHuongDan_id);
            }
            catch (Exception e)
            {
                throw e;
            }
            return PartialView(lstGuideSystem);
        }
    }
}