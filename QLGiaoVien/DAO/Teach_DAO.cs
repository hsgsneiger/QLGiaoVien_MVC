using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class Teach_DAO
    {
        public int id { get; set; }
        public int NhomGiangDay_id { get; set; }
        public string TenHocPhan { get; set; }
        public string Lop { get; set; }
        public int SoTiet { get; set; }
        public string GhiChu { get; set; }
        public int LoaiSiSo_id { get; set; }
        public int HeGiangDay_id { get; set; }
        public int NamHoc_id { get; set; }
        public int SoTinChi { get; set; }
        public double GioChuan { get; set; }
        public int GiaoVien_id { get; set; }
    }
}
