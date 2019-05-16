namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GiaoVien_HoiDong
    {
        public int id { get; set; }

        public int GiaoVien_id { get; set; }

        public int HoiDong_id { get; set; }

        public byte? SoLuong { get; set; }

        [StringLength(255)]
        public string GhiChu { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual HoiDong HoiDong { get; set; }
    }
}
