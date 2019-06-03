using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO
{
    public class HoiDong_Insert_Update
    {
        public int id { set; get; }
        public string TenHoiDong { set; get; }
        public int LoaiHoiDong_id { set; get; }
        public int MucThamGia_id { set; get; }
        public int SoLuong {set; get;}
        public int MaGV { set; get; }
        public int MaNamHoc { set; get; }
    }
}
