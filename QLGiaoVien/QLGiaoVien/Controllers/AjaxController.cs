using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utils;

namespace QLGiaoVien.Controllers
{
    public class AjaxController : BaseController
    {
        // GET: Ajax
        public JsonResult HuongDan_ThemSua(Guide_Insert_Update obj,bool isUpdate)
        {
            AjaxResultModel result = new AjaxResultModel();
            bool check = false;
            try
            {
                if (isUpdate)
                {
                    check = Guide_Service.Update(obj);

                }
                else
                {
                    check = Guide_Service.Insert(obj);
                }
                if (check)
                {
                    result.Code = 0;
                    result.Message = "Thành công";
                } else
                {
                    result.Code = 1;
                    result.Message = "Đã có lỗi xảy ra.";
                }
            } catch(Exception e)
            {
                result.Code = 2;
                result.Message = e.Message;
            }
            return Json(result);
        }

        public JsonResult HuongDan_Xoa(int ID)
        {
            AjaxResultModel result = new AjaxResultModel();
            bool check = false;
            try
            {
                check = Guide_Service.Delete(ID);
                if (check)
                {
                    result.Code = 0;
                    result.Message = "Thành công";
                }
                else
                {
                    result.Code = 1;
                    result.Message = "Đã có lỗi xảy ra.";
                }
            }
            catch (Exception e)
            {
                result.Code = 2;
                result.Message = e.Message;
            }
            return Json(result);
        }

        public JsonResult NghienCuu_ThemSua(Research_Insert_Update obj, bool isUpdate)
        {
            AjaxResultModel result = new AjaxResultModel();
            bool check = false;
            try
            {
                if (isUpdate)
                {
                    check = Research_Service.Update(obj);

                }
                else
                {
                    check = Research_Service.Insert(obj);
                }
                if (check)
                {
                    result.Code = 0;
                    result.Message = "Thành công";
                }
                else
                {
                    result.Code = 1;
                    result.Message = "Đã có lỗi xảy ra.";
                }
            }
            catch (Exception e)
            {
                result.Code = 2;
                result.Message = e.Message;
            }
            return Json(result);
        }

        public JsonResult NghienCuu_Xoa(int ID)
        {
            AjaxResultModel result = new AjaxResultModel();
            bool check = false;
            try
            {
                check = Research_Service.Delete(ID);
                if (check)
                {
                    result.Code = 0;
                    result.Message = "Thành công";
                }
                else
                {
                    result.Code = 1;
                    result.Message = "Đã có lỗi xảy ra.";
                }
            }
            catch (Exception e)
            {
                result.Code = 2;
                result.Message = e.Message;
            }
            return Json(result);
        }
    }
}