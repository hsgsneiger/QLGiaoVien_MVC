using DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;


namespace BusinessLogic
{
     public class KhaoThiBL
    {
        public List<KhaoThiView> GetAll(int MaGV, int? NamHoc = null)
        {
            List<KhaoThiProc> lstKhaoThi = new List<KhaoThiProc>();
            lstKhaoThi = new SqlHelper<KhaoThiProc>().ExecuteProcAndGetData("CTKhaoThi_GetAll", MaGV, NamHoc);
            List<KhaoThiView> lstKT_View = new List<KhaoThiView>();
            IEnumerable<int> lstID = lstKhaoThi.Select(x => x.LoaiKhaoThi_id).Distinct();
            foreach(int id in lstID)
            {
                KhaoThiView KT_View = new KhaoThiView();
                IEnumerable<KhaoThiProc> tmp = lstKhaoThi.Where(x => x.LoaiKhaoThi_id.Equals(id));
                KT_View.TenLoaiKhaoThi = tmp.FirstOrDefault().TenLoaiKhaoThi;
                KT_View.chiTiet = tmp.Select(x => new KhaoThiList() { TenKhaoThi = x.TenKhaoThi, TenLop = x.TenLop, SoBai = x.SoBai, SoGio= x.SoGioQuyDoi }).ToList();
                KT_View.TongSoGio = KT_View.chiTiet.Sum(x => x.SoGio);
                lstKT_View.Add(KT_View);
            }
            return lstKT_View;
        }
    }
}
