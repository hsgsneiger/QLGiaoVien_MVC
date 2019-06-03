using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DAO
{
    public class KhaoThiProc
    {
        public int id { set; get; }
        public string TenKhaoThi { set; get; }
        public string TenLop { set; get; }
        public int SoBai { set; get; }
        public int LoaiKhaoThi_id { set; get; }
        public string TenLoaiKhaoThi { set; get; }
        public double TiLeQuyDoi { set; get; }
    }
}
