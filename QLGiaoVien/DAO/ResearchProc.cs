using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class ResearchProc
    {
        public int id { get; set; }
        public string TenNhomNCKH { get; set; }
        public double SoGioChuan { get; set; }
        public string TenVaiTro { get; set; }
        public double TyLeNhan { get; set; }
        public string TenLoai { get; set; }
        public double TongSoGio { get; set; }
        public string TenDeTai { get; set; }
        public int SoTacGia { get; set; }
        public int NhomNCKH_id { get; set; }
    }
}
