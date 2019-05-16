namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GiaoVien_HuongNghienCuu
    {
        public int id { get; set; }

        public int GiaoVien_id { get; set; }

        public int HuongNghienCuuChinh_id { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual HuongNghienCuuChinh HuongNghienCuuChinh { get; set; }
    }
}
