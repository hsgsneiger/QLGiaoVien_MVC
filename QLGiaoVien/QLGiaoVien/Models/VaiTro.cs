namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VaiTro")]
    public partial class VaiTro
    {
        public int id { get; set; }

        [StringLength(50)]
        public string TenVaiTro { get; set; }

        public double? TyLeNhan { get; set; }

        public int? NhomNCKH_id { get; set; }

        public virtual NhomNCKH NhomNCKH { get; set; }
    }
}
