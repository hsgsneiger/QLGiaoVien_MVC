namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NamHoc")]
    public partial class NamHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NamHoc()
        {
            GiaoVien_DeTaiNghienCuuKHCN = new HashSet<GiaoVien_DeTaiNghienCuuKHCN>();
            GiaoVien_GiangDay = new HashSet<GiaoVien_GiangDay>();
            GiaoVien_HuongDan = new HashSet<GiaoVien_HuongDan>();
            GiaoVien_KhaoThi = new HashSet<GiaoVien_KhaoThi>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string TenNamHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_DeTaiNghienCuuKHCN> GiaoVien_DeTaiNghienCuuKHCN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_GiangDay> GiaoVien_GiangDay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_HuongDan> GiaoVien_HuongDan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_KhaoThi> GiaoVien_KhaoThi { get; set; }
    }
}
