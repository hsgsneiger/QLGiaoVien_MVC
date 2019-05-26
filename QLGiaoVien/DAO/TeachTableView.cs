using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DAO
{
    public class TeachTableView
    {
        [Display(Name = "Tên loại giảng dạy")]
        public string TenLoaiGiangDay { get; set; }
        public int NhomGiangDay_id { get; set; }
        public int TongSoTC { get; set; }
        public int TongSoTiet { get; set; }

        public float TongGioChuan { get; set; }

        public List<Teach_DAO> lstGiangDay { get; set; }
    }
}
