namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GiaoVien_HocHamHocVi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiaoVien_HocHamHocVi()
        {
            GiaoVien_KhaoThi = new HashSet<GiaoVien_KhaoThi>();
        }

        public int id { get; set; }

        public int? GiaoVien_id { get; set; }

        public int? HocHamHocVi_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianNhan { get; set; }

        [StringLength(255)]
        public string NoiNhan { get; set; }

        [StringLength(50)]
        public string ChuyenNganh { get; set; }

        [StringLength(255)]
        public string TenLuanVan { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual HocHamHocVi HocHamHocVi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_KhaoThi> GiaoVien_KhaoThi { get; set; }
    }
}
