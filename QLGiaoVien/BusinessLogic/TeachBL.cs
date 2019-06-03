using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace BusinessLogic
{
    public class TeachBL
    {
        public List<TeachTableView> GetListTeaches(int gv_id, int? namHoc_id)
        {
            List<Teach_DAO> lstTeaches = new SqlHelper<Teach_DAO>().ExecuteProcAndGetData("GetListTeaches", gv_id, namHoc_id);
            List<GroupTeachDAO> lstGroupTeaches = new SqlHelper<GroupTeachDAO>().ExecuteProcAndGetData("GetListGroupTeaches");
            IEnumerable<int> lstId = lstTeaches.Select(x => x.id).Distinct();
            List<TeachTableView> result = new List<TeachTableView>();

            foreach(var group in lstGroupTeaches)
            {
                TeachTableView gr = new TeachTableView()
                {
                    NhomGiangDay_id = group.id,
                    TenLoaiGiangDay = group.TenNhomGiangDay,
                    lstGiangDay = lstTeaches.Where(x => x.NhomGiangDay_id == group.id).ToList()
                };
                result.Add(gr);
            }

            return result;
        }

        public List<ClassSizeDAO> GetListClassSize ()
        {
            List<ClassSizeDAO> lstClassSize = new SqlHelper<ClassSizeDAO>().ExecuteProcAndGetData("GetListClassSize");

            return lstClassSize;
        }

        public List<HeGiangDayDAO> GetListHeGD()
        {
            List<HeGiangDayDAO> lstHeGD = new SqlHelper<HeGiangDayDAO>().ExecuteProcAndGetData("GetListHeGD");

            return lstHeGD;
        }

        public Teach_DAO Find(int id)
        {
            return new SqlHelper<Teach_DAO>().ExecuteProcAndGetData("GetTeachByID", id).FirstOrDefault();
        }

        public bool UpdateTeach(Teach_DAO t)
        {
            return new SqlHelper<Teach_DAO>().ExecuteProcTeach("TeachInsertUpdateDelete", t, "Update");
        }

        public bool InsertTeach(Teach_DAO t)
        {
            return new SqlHelper<Teach_DAO>().ExecuteProcTeach("TeachInsertUpdateDelete", t, "Insert");
        }

        public bool DeleteTeach(int id)
        {
            return new SqlHelper<int>().RemoveRecord("RemoveTeach",id);
        }

    }
}
