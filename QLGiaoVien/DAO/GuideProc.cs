using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DAO
{
    public class GuideProc
    {
        public int id { get; set; }
        public string HoTenHocVien { get; set; }
        public string Lop { get; set; }
        public string TenHeHuongDan { get; set; }
        public string TenLoaiHuongDan { get; set; }
        public double SoGioDinhMuc { get; set; }
        public int SoCBHD { get; set; }
        public int LoaiHuongDan_id { get; set; }
        public string TenDeTai_ChuyenDe { get; set; }
    }
}
