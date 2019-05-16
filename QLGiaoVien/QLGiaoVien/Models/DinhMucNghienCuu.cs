namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DinhMucNghienCuu")]
    public partial class DinhMucNghienCuu
    {
        public int id { get; set; }

        public int? ChucDanhChuyenMon_id { get; set; }

        public int? HocHamHocVi_id { get; set; }

        public short? DinhMucThoiGian { get; set; }

        public short? DinhMucGioChuan { get; set; }

        [StringLength(255)]
        public string GhiChu { get; set; }

        public virtual ChucDanhChuyenMon ChucDanhChuyenMon { get; set; }

        public virtual HocHamHocVi HocHamHocVi { get; set; }
    }
}
