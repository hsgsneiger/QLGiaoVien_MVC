namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DinhMucChucVu")]
    public partial class DinhMucChucVu
    {
        public int id { get; set; }

        public int? ChucVu_id { get; set; }

        public double? TyLeThap { get; set; }

        public double? TyLeCao { get; set; }

        public virtual ChucVu ChucVu { get; set; }
    }
}
