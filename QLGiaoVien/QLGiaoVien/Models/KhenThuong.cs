namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhenThuong")]
    public partial class KhenThuong
    {
        public int id { get; set; }

        public int GiaoVien_id { get; set; }

        [StringLength(255)]
        public string TenKhenThuong { get; set; }

        public string NoiDung { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }
    }
}
