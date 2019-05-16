namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HeHuongDan")]
    public partial class HeHuongDan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HeHuongDan()
        {
            HuongDans = new HashSet<HuongDan>();
        }

        public int id { get; set; }

        public int LoaiHuongDan_id { get; set; }

        [StringLength(255)]
        public string TenHeHuongDan { get; set; }

        public virtual LoaiHuongDan LoaiHuongDan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HuongDan> HuongDans { get; set; }
    }
}
