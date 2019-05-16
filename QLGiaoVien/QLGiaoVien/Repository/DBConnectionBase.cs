using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLGiaoVien.DatabaseAccess
{
    public class DBConnectionBase
    {
        private readonly string _connectionString;

        public DBConnectionBase()
        {
            _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionStrings"].ConnectionString;
        }


        protected System.Data.SqlClient.SqlConnection GetConnection()
        {
            return new System.Data.SqlClient.SqlConnection(_connectionString);
        }

    }
}