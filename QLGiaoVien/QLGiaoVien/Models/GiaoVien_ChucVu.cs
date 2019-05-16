namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GiaoVien_ChucVu
    {
        public int id { get; set; }

        public int? GiaoVien_id { get; set; }

        public int? ChucVu_id { get; set; }

        public int? DonViChinh_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianNhanChuc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianKetThuc { get; set; }

        public virtual ChucVu ChucVu { get; set; }

        public virtual DonViChinh DonViChinh { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }
    }
}
