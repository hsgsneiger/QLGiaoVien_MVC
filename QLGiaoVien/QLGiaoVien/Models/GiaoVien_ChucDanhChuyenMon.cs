namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GiaoVien_ChucDanhChuyenMon
    {
        public int id { get; set; }

        public int? GiaoVien_id { get; set; }

        public int? ChucDanhChuyenMon_id { get; set; }

        public int? ThoiGianNhan { get; set; }

        public virtual ChucDanhChuyenMon ChucDanhChuyenMon { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }
    }
}
