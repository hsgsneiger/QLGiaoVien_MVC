using DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace BusinessLogic
{
    public class HuongDanBL
    {
        public List<GuideView> GetAll(int MaGV,int? NamHoc=null)
        {
            List<GuideProc> listGuides = new List<GuideProc>();
            listGuides = new SqlHelper<GuideProc>().ExecuteProcAndGetData("CTHuongDan_GetAll", MaGV, NamHoc);
            List<GuideView> lstGuide_View = new List<GuideView>();
            IEnumerable<int> lstID = listGuides.Select(x => x.LoaiHuongDan_id).Distinct();
            foreach(int id in lstID)
            {
                GuideView guide_view = new GuideView();
                IEnumerable<GuideProc> tmp = listGuides.Where(x => x.LoaiHuongDan_id.Equals(id));
                guide_view.TenLoaiHuongDan = tmp.FirstOrDefault().TenLoaiHuongDan;
                guide_view.SoGioDinhMuc = tmp.FirstOrDefault().SoGioDinhMuc;
                guide_view.ChiTiet = tmp.Select(x => new GuideDAOForList() { HoTenHocVien = x.HoTenHocVien, Lop = x.Lop, SoCBHD = x.SoCBHD, TenHeHuongDan = x.TenHeHuongDan,SoGio = guide_view.SoGioDinhMuc/x.SoCBHD, TenDeTai_ChuyenDe=x.TenDeTai_ChuyenDe }).ToList();
                lstGuide_View.Add(guide_view);

            }
            return lstGuide_View;
        }
    }
}
