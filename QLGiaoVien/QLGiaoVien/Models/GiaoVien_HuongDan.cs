namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GiaoVien_HuongDan
    {
        public int id { get; set; }

        public int? GiaoVien_id { get; set; }

        public int? HuongDan_id { get; set; }

        public int? NamHoc_id { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual HuongDan HuongDan { get; set; }

        public virtual NamHoc NamHoc { get; set; }
    }
}
