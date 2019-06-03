using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public PartialViewResult DataGrid(int MaGV = 0, int? MaNamHoc = 0)
        {
            List<TeachTableView> data = teach_service.GetListTeaches(MaGV, MaNamHoc);

            List<ClassSizeDAO> lstClassSize = teach_service.GetListClassSize();
            List<HeGiangDayDAO> lstHeGD = teach_service.GetListHeGD();

            ViewBag.lstClassSize = lstClassSize.ToList();
            ViewBag.lstHeGD = lstHeGD.ToList();
            return PartialView(data);
        }

        public ActionResult KeKhai()
        {
            
            return View();
        }

        [HttpPost]
        public JsonResult Edit(int? id, string thp, string Lop, int? lss, int? hgd, int? SoTinChi, int? SoTiet)
            {
            Teach_DAO t = new Teach_DAO() { };
            t = teach_service.Find(id??1);
            t.TenHocPhan = thp;
            t.GhiChu = "";
            t.HeGiangDay_id = hgd ?? t.HeGiangDay_id;
            t.LoaiSiSo_id = lss ?? t.LoaiSiSo_id;
            t.Lop = Lop;
            t.SoTinChi = SoTinChi??t.SoTinChi;
            t.SoTiet = SoTiet ?? t.SoTiet;


            teach_service.UpdateTeach(t);

            return Json("Success");
        }

        //[HttpPost]
        //public JsonResult Create(int? id, string thp, string Lop, int? lss, int? hgd, int?idn , int? SoTinChi, int? SoTiet)
        //{
        //    if (idn == null) idn = 1;
        //    Teach_DAO t = new Teach_DAO() {
        //    };
        //    t.TenHocPhan = thp;
        //    t.GhiChu = "";
        //    t.HeGiangDay_id = hgd ?? t.HeGiangDay_id;
        //    t.LoaiSiSo_id = lss ?? t.LoaiSiSo_id;
        //    t.Lop = Lop;
        //    t.SoTinChi = SoTinChi ?? t.SoTinChi;
        //    t.SoTiet = SoTiet ?? t.SoTiet;
        //    t.NhomGiangDay_id = idn??3;

        //    teach_service.InsertTeach(t);
        //    return Json("Success");
        //}

        [HttpPost]
        public JsonResult Create(int? gv_id, int? nam, string thp ,int? lss, int? ngd, int? hgd, string lop, int? st, int? stc, string gc)
        {
            if(ngd == null) ngd = 1;
            if(gv_id == null) gv_id = 1;
            if(nam == null) nam = 3;
            Teach_DAO t = new Teach_DAO()
            {
            };
            t.TenHocPhan = thp;
            t.GhiChu = "";
            t.HeGiangDay_id = hgd ?? t.HeGiangDay_id;
            t.LoaiSiSo_id = lss ?? t.LoaiSiSo_id;
            t.Lop = lop;
            t.SoTinChi = stc ?? 0;
            t.SoTiet = st ?? 0;
            t.NhomGiangDay_id = ngd ?? 1;
            t.NamHoc_id = nam??3;
            t.GiaoVien_id = gv_id??1;
            // giaos vien, bh phai them truong gv vs nam hoc vao teachdao
            teach_service.InsertTeach(t);
            return Json("Success");
        }


        [HttpPost]
        public JsonResult Delete(int? id)
        {
            if(id == null)
            {
                return Json("Error");
            }
            else
            {
                teach_service.DeleteTeach(id ?? 0);
                return Json("Success");
            }
        }
    }
}