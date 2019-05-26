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
            List<LecturerDAO> lstLecturers = Configuration_Service.GetAllLecturers();
            List<YearDAO> lstYears = Configuration_Service.GetAllYears();
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
        public PartialViewResult _ChiTiet(int ID = 0)
        {
            List<ResearchGroupDAO> lstGroup = new List<ResearchGroupDAO>();

            List<ResearchTypeDAO> lstResearchType = new List<ResearchTypeDAO>();
            Research_Insert_Update researchInfo = new Research_Insert_Update();
            List<VaiTro> lstVaiTro = new List<VaiTro>();
            try
            {
                lstGroup = Configuration_Service.ResearchGroupGetAll();
                ViewBag.lstGuideType = lstResearchType;
                if (!ID.Equals(0))
                {
                    researchInfo = Research_Service.GetByID(ID).FirstOrDefault();
                    lstVaiTro = Configuration_Service.VaitroGetAll(researchInfo.NhomNCKH_id);
                    lstResearchType = Configuration_Service.ResearchTypeGetAll(researchInfo.NhomNCKH_id);
                }
                ViewBag.lstResearchType = lstResearchType;
                ViewBag.lstVaiTro = lstVaiTro;
                ViewBag.lstGroup = lstGroup;




            }
            catch (Exception e)
            {
                throw e;
            }
            return PartialView(researchInfo);
        }
        public PartialViewResult _Loai_VaiTro(int NhomNCKH_id = 0)
        {
            List<ResearchTypeDAO> lstResearchType = new List<ResearchTypeDAO>();
            List<VaiTro> lstVaiTro = new List<VaiTro>();
            try
            {
                lstVaiTro = Configuration_Service.VaitroGetAll(NhomNCKH_id);
                lstResearchType = Configuration_Service.ResearchTypeGetAll(NhomNCKH_id);
                ViewBag.lstResearchType = lstResearchType;
                ViewBag.lstVaiTro = lstVaiTro;
        }
            catch (Exception e)
            {
                throw e;
            }
            return PartialView();
        }
    }
}