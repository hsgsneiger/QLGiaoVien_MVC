using DAO;
using QLGiaoVien.ExtendModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLGiaoVien.Controllers
{
    public class GiaoVienController : BaseController
    {
        // GET: GiaoVien
        public ActionResult Index()
        {
            List<Lecturer_DAO1> lstLecturers = lecturer_service.GetListLecturers();


            var lstDepartments = department_service.GetListDepartments();

            var lstComboBoxDepartment = new List<ComboBoxOptions>
            {
                //new ComboBoxOptions("0", "")
            };

            try
            {
                foreach (var item in lstDepartments)
                {
                    lstComboBoxDepartment.Add(new ComboBoxOptions(item.id.ToString(), item.TenBoMon.ToString()));
                }
            }
            catch (Exception e)
            {
            }
            ViewBag.lstLopChuyenNganh = lstComboBoxDepartment;

            return View(lstLecturers);
        }

        public ActionResult Create()
        {
            //List<SelectListItem> lstLopChuyenNganh = new List<SelectListItem>();

            var lstDepartments = department_service.GetListDepartments();
            //foreach(var item in lstDepartments)
            //{
            //    lstLopChuyenNganh.Add(new SelectListItem()
            //    {
            //        Value = item.id.ToString(),
            //        Text = item.TenBoMon
            //    });
            //}

            SelectList cateList = new SelectList(lstDepartments, "id", "TenBoMon");

            ViewBag.customValue = lstDepartments;
            return View();
        }

        [HttpPost]
        public void Create(Lecturer_DAO1 gv)
        {
            Lecturer_DAO1 lec = new Lecturer_DAO1()
            {
                BoMon_id = gv.BoMon_id,
                DienThoaiDD = gv.DienThoaiDD,
                DienThoaiNR = gv.DienThoaiNR,
                Email = gv.Email,
                GioiTinh = gv.GioiTinh,
                HoTen = gv.HoTen,
                LaPhuNuCoConNho = gv.LaPhuNuCoConNho,
                //NgaySinh = DateTime.Parse(gv.NgaySinh.ToString()),
                PhuongXa = gv.PhuongXa,
                QuanHuyen = gv.QuanHuyen,
                QueQuan = gv.QueQuan,
                ThoiGianNghiViec = gv.ThoiGianNghiViec,
                TinhThanhPho = gv.TinhThanhPho
            };

            try
            {
                lecturer_service.InsertLecturer(lec);
            }
            catch (Exception e) { }
        }
    }
}