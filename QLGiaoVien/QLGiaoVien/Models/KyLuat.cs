namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KyLuat")]
    public partial class KyLuat
    {
        public int id { get; set; }

        public int GiaoVien_id { get; set; }

        [StringLength(255)]
        public string TenKyLuat { get; set; }

        public string NoiDungKyLuat { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }
    }
}
