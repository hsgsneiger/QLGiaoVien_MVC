namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiKhaoThi")]
    public partial class LoaiKhaoThi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiKhaoThi()
        {
            KhaoThis = new HashSet<KhaoThi>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string TenLoaiKhaoThi { get; set; }

        [StringLength(50)]
        public string DonViTinh { get; set; }

        public double? SoGioQuyDoi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhaoThi> KhaoThis { get; set; }
    }
}
