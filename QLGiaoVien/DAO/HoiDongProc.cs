using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DAO
{
     public class HoiDongProc
    {
        public string TenHoiDong { set; get; }
        public int SoLuong { set; get; }
        public double SoGioQuyDoi { set; get; }
        public string TenLoaiHoiDong { set; get; } 
        public int LoaiHoiDong_id { set; get; }
    }
}
