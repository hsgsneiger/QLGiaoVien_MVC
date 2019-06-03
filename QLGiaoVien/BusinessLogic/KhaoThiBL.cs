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
        public List<KhaoThiView> GetAll(int MaGV, int? MaNamHoc = null)
        {
            List<KhaoThiProc> lstKhaoThi = new List<KhaoThiProc>();
            lstKhaoThi = new SqlHelper<KhaoThiProc>().ExecuteProcAndGetData("KhaoThi_GetAll", MaGV, MaNamHoc);
            List<KhaoThiView> lstKT_View = new List<KhaoThiView>();
            IEnumerable<int> lstID = lstKhaoThi.Select(x => x.LoaiKhaoThi_id).Distinct();
            foreach(int id in lstID)
            {
                KhaoThiView KT_View = new KhaoThiView();
                IEnumerable<KhaoThiProc> tmp = lstKhaoThi.Where(x => x.LoaiKhaoThi_id.Equals(id));
                KT_View.TenLoaiKhaoThi = tmp.FirstOrDefault().TenLoaiKhaoThi;
                KT_View.chiTiet = tmp.Select(x => new KhaoThiList() {id=x.id, TenKhaoThi = x.TenKhaoThi, TenLop = x.TenLop, SoBai = x.SoBai, SoGio= x.SoBai * x.TiLeQuyDoi}).ToList();
                KT_View.TongSoGio = KT_View.chiTiet.Sum(x => x.SoGio);
                lstKT_View.Add(KT_View);
            }
            return lstKT_View;
        }
        public List<KhaoThi_Insert_Update> GetByID(int id)
        {
            return new SqlHelper<KhaoThi_Insert_Update>().ExecuteProcAndGetData("KhaoThi_GetByID", "id", id);
        }
        public bool Insert(KhaoThi_Insert_Update obj)
        {
            return new SqlHelper<KhaoThi_Insert_Update>().ExecuteProc("KhaoThi_Insert", obj);
        }
        public bool Update(KhaoThi_Insert_Update obj)
        {
            return new SqlHelper<KhaoThi_Insert_Update>().ExecuteProc("KhaoThi_Update", obj);
        }
        public bool Delete(int ID)
        {
            return new SqlHelper<KhaoThi_Insert_Update>().ExecuteProc("KhaoThi_Delete", "ID", ID);
        }
    }
}
