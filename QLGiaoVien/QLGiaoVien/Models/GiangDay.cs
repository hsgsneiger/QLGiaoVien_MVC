namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiangDay")]
    public partial class GiangDay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiangDay()
        {
            GiaoVien_GiangDay = new HashSet<GiaoVien_GiangDay>();
        }

        public int id { get; set; }

        public int? NhomGiangDay_id { get; set; }

        [StringLength(255)]
        public string TenHocPhan { get; set; }

        [StringLength(50)]
        public string Lop { get; set; }

        [StringLength(30)]
        public string NamHoc { get; set; }

        public byte? SoTinChi { get; set; }

        public short? SoTiet { get; set; }

        [StringLength(255)]
        public string GhiChu { get; set; }

        public int? LoaiSiSo_id { get; set; }

        public int? HeGiangDay_id { get; set; }

        public double? GioChuan { get; set; }

        public virtual HeGiangDay HeGiangDay { get; set; }

        public virtual LoaiSiSo LoaiSiSo { get; set; }

        public virtual NhomGiangDay NhomGiangDay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_GiangDay> GiaoVien_GiangDay { get; set; }
    }
}
