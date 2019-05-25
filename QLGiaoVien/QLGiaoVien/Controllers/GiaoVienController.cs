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
            return View();
        }
    }
}