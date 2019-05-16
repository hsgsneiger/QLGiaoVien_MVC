using QLGiaoVien.DatabaseAccess;
using QLGiaoVien.Models;
using QLGiaoVien.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLGiaoVien.Controllers
{
    public class GiaoVienController : Controller
    {
        // GET: GiaoVien
        public ActionResult Index()
        {
            GiaoVienRepository model = new GiaoVienRepository();
            
            return View(model);
        }
    }
}