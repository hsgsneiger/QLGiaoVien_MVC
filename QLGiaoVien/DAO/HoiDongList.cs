using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DAO
{
    public class HoiDongList
    {
        public int id { set; get; }
        public string TenHoiDong { set; get; }
        public string TenMuc { set; get; }
        public int SoLuong { set; get; }
        public double SoGio { set; get; }
    }
}
