namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhomNCKH")]
    public partial class NhomNCKH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhomNCKH()
        {
            DeTaiNghienCuuKHCNs = new HashSet<DeTaiNghienCuuKHCN>();
            LoaiNCKHs = new HashSet<LoaiNCKH>();
            VaiTroes = new HashSet<VaiTro>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string TenNhomNCKH { get; set; }

        public double? SoGioChuan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeTaiNghienCuuKHCN> DeTaiNghienCuuKHCNs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoaiNCKH> LoaiNCKHs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VaiTro> VaiTroes { get; set; }
    }
}
