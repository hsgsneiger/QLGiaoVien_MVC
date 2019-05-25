using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace BusinessLogic
{
    public class ResearchBL
    {
        public List<ResearchView> GetAll(int MaGV, int? NamHoc = null)
        {
            List<ResearchProc> lstResearch_Proc = new SqlHelper<ResearchProc>().ExecuteProcAndGetData("CTNghienCuu_GetAll", MaGV, MaGV);
            IEnumerable<int> lstId = lstResearch_Proc.Select(x => x.NhomNCKH_id).Distinct();
            List<ResearchView> listResearch_View = new List<ResearchView>();

            foreach (int id in lstId)
            {
                ResearchView researchView = new ResearchView();
                IEnumerable<ResearchProc> tmp = lstResearch_Proc.Where(x=>x.NhomNCKH_id.Equals(id));

                researchView.TenNhomNCKH = tmp.FirstOrDefault().TenNhomNCKH;

                researchView.ChiTiet = tmp.Select(x => new ResearchDaoForList() { SoGioChuan = x.SoGioChuan * x.TyLeLoai + x.SoGioChuan*x.TyLeVaiTro/x.SoTacGia, SoTacGia = x.SoTacGia, TenDeTai = x.TenDeTai, TenLoai = x.TenLoai, TenVaiTro = x.TenVaiTro}).ToList();
                researchView.TongSoGio = researchView.ChiTiet.Sum(x=>x.SoGioChuan);

                listResearch_View.Add(researchView);
            }

            return listResearch_View;
        }
    }
}
