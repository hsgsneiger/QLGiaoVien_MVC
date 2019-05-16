using QLGiaoVien.DatabaseAccess;
using QLGiaoVien.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QLGiaoVien.Repository
{
    public class GiaoVienRepository : DBConnectionBase
    {
        private SqlConnection connection = new SqlConnection();
        
        // khởi tạo connection
        public GiaoVienRepository()
        {
            connection = base.GetConnection();
        }

        public List<GiaoVien> GetList()
        {

            List<GiaoVien> list = new List<GiaoVien>();

           // get list

            return list;
        }

    }
}