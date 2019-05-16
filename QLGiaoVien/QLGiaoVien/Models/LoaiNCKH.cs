namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiNCKH")]
    public partial class LoaiNCKH
    {
        public int id { get; set; }

        [StringLength(50)]
        public string TenLoai { get; set; }

        public int? NhomNCKH_id { get; set; }

        public double? SoGioChuan { get; set; }

        public virtual NhomNCKH NhomNCKH { get; set; }
    }
}
