namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocHamHocVi")]
    public partial class HocHamHocVi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocHamHocVi()
        {
            DinhMucGiangDays = new HashSet<DinhMucGiangDay>();
            DinhMucNghienCuus = new HashSet<DinhMucNghienCuu>();
            GiaoVien_HocHamHocVi = new HashSet<GiaoVien_HocHamHocVi>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string TenHocHamHocVi { get; set; }

        public bool? LaHocHam { get; set; }

        public byte? XepHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DinhMucGiangDay> DinhMucGiangDays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DinhMucNghienCuu> DinhMucNghienCuus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_HocHamHocVi> GiaoVien_HocHamHocVi { get; set; }
    }
}
