using DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace BusinessLogic
{
    public class HoiDongBL
    { 
        public List<HoiDongView> GetAll(int MaGV, int? NamHoc)
        {
            List<HoiDongProc> lstHoiDong = new List<HoiDongProc>();
            lstHoiDong = new SqlHelper<HoiDongProc>().ExecuteProcAndGetData("CTHoiDong_GetAll", MaGV, NamHoc);
            List<HoiDongView> HoiDong_View = new List<HoiDongView>();
            IEnumerable<int> lstID = lstHoiDong.Select(x => x.LoaiHoiDong_id).Distinct();
            foreach(int ID in lstID)
            {
                HoiDongView HD_View = new HoiDongView();
                IEnumerable<HoiDongProc> tmp = lstHoiDong.Where(x => x.LoaiHoiDong_id.Equals(ID));
                HD_View.TenLoaiHoiDong = tmp.FirstOrDefault().TenLoaiHoiDong;
                HD_View.chiTiet = tmp.Select(x => new HoiDongList() { TenHoiDong = x.TenHoiDong, SoLuong= x.SoLuong, SoGio= x.SoLuong * tmp.FirstOrDefault().SoGioQuyDoi }).ToList();
                HD_View.TongSoGio = HD_View.chiTiet.Sum(x => x.SoGio);
                HoiDong_View.Add(HD_View);
            }
            return HoiDong_View;
        }
    }
}
