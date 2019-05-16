namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonViChinh")]
    public partial class DonViChinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonViChinh()
        {
            GiaoVien_ChucVu = new HashSet<GiaoVien_ChucVu>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string TenDonViChinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoVien_ChucVu> GiaoVien_ChucVu { get; set; }
    }
}
