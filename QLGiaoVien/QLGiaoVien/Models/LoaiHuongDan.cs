namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiHuongDan")]
    public partial class LoaiHuongDan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiHuongDan()
        {
            HeHuongDans = new HashSet<HeHuongDan>();
            HuongDans = new HashSet<HuongDan>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string TenLoaiHuongDan { get; set; }

        public double? SoGioDinhMuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HeHuongDan> HeHuongDans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HuongDan> HuongDans { get; set; }
    }
}
