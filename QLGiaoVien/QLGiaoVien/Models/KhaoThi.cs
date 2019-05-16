namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhaoThi")]
    public partial class KhaoThi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhaoThi()
        {
            GiaoVien_KhaoThi = new HashSet<GiaoVien_KhaoThi>();
        }

        public int id { get; set; }

        public int? LoaiKhaoThi_id { get; set; }

        [StringLength(255)]
        public string TenKhaoThi { get; set; }

        [StringLength(50)]
        public string TenLop { get; set; }

        [StringLength(255)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_KhaoThi> GiaoVien_KhaoThi { get; set; }

        public virtual LoaiKhaoThi LoaiKhaoThi { get; set; }
    }
}
