namespace QLGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HeGiangDay")]
    public partial class HeGiangDay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HeGiangDay()
        {
            GiangDays = new HashSet<GiangDay>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string TenHeGiangDay { get; set; }

        public int? NhomGiangDay_id { get; set; }

        public double? QuyDoiGioChuan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiangDay> GiangDays { get; set; }

        public virtual NhomGiangDay NhomGiangDay { get; set; }
    }
}
