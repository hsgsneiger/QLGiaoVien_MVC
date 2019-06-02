using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLGiaoVien.Controllers
{
    public class BaseController : Controller
    {
        protected GuideBL Guide_Service = new GuideBL();
        protected ConfigurationBL Configuration_Service = new ConfigurationBL();
        protected ResearchBL Research_Service = new ResearchBL();
        protected KhaoThiBL KhaoThi_Service = new KhaoThiBL();
        protected HoiDongBL Hoidong_Service = new HoiDongBL();
    }
}