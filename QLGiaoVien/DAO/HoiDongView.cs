using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DAO
{
    public class HoiDongView
    {
        public string TenLoaiHoiDong { set; get; }
        public double TongSoGio { set; get; }
        public List<HoiDongList> chiTiet { set; get; }
    }
}
