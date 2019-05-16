namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GiaoVien_ChungChiNgoaiNgu
    {
        public int id { get; set; }

        public int? GiaoVien_id { get; set; }

        public int? ChungChiNgoaiNgu_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianNhan { get; set; }

        public string ChiTietChungChiNgoaiNgu { get; set; }

        public virtual ChungChiNgoaiNgu ChungChiNgoaiNgu { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }
    }
}
