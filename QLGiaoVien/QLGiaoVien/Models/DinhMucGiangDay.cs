namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DinhMucGiangDay")]
    public partial class DinhMucGiangDay
    {
        public int id { get; set; }

        public int ChucDanhChuyenMon_id { get; set; }

        public int HocHamHocVi_id { get; set; }

        public short? DinhMucMonChung { get; set; }

        public short? DinhMucMuonQuocPhong { get; set; }

        [StringLength(255)]
        public string GhiChu { get; set; }

        public virtual ChucDanhChuyenMon ChucDanhChuyenMon { get; set; }

        public virtual HocHamHocVi HocHamHocVi { get; set; }
    }
}
