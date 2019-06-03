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
            lstHoiDong = new SqlHelper<HoiDongProc>().ExecuteProcAndGetData("HoiDong_GetAll", MaGV, NamHoc);
            List<HoiDongView> HoiDong_View = new List<HoiDongView>();
            IEnumerable<int> lstID = lstHoiDong.Select(x => x.LoaiHoiDong_id).Distinct();
            foreach(int ID in lstID)
            {
                HoiDongView HD_View = new HoiDongView();
                IEnumerable<HoiDongProc> tmp = lstHoiDong.Where(x => x.LoaiHoiDong_id.Equals(ID));
                HD_View.TenLoaiHoiDong = tmp.FirstOrDefault().TenLoaiHoiDong;
                HD_View.chiTiet = tmp.Select(x => new HoiDongList() {id=x.id, TenHoiDong = x.TenHoiDong, SoLuong= x.SoLuong, SoGio= x.SoLuong * x.SoGioQuyDoi, TenMuc=x.TenMuc }).ToList();
                HD_View.TongSoGio = HD_View.chiTiet.Sum(x => x.SoGio);
                HoiDong_View.Add(HD_View);
            }
            return HoiDong_View;
        }
        public List<HoiDong_Insert_Update> GetByID(int id)
        {
            return new SqlHelper<HoiDong_Insert_Update>().ExecuteProcAndGetData("HoiDong_GetByID", "id", id);
        }
        public bool Insert(HoiDong_Insert_Update obj)
        {
            return new SqlHelper<HoiDong_Insert_Update>().ExecuteProc("HoiDong_Insert", obj);
        }
        public bool Update(HoiDong_Insert_Update obj)
        {
            return new SqlHelper<HoiDong_Insert_Update>().ExecuteProc("HoiDong_Update", obj);
        }
        public bool Delete(int ID)
        {
            return new SqlHelper<HoiDong_Insert_Update>().ExecuteProc("HoiDong_Delete", "ID", ID);
        }
    }
}
