namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GiaoVien_GiangDay
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int GiaoVien_id { get; set; }

        public int GiangDay_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGian { get; set; }

        public string GhiChu { get; set; }

        public int? NamHoc_id { get; set; }

        public virtual GiangDay GiangDay { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual NamHoc NamHoc { get; set; }
    }
}
